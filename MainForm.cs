//===============================================================================================================
//  Project     : SimpleSerialSender
//  Filename    : MainForm.cs
//  Author      : Simon Raybould
//  Date        : Tue 16 April 2019
//  Description : TCP <=> Serial Bridge
//===============================================================================================================

//===============================================================================================================
//MIT License
//
//Copyright(c) 2017 Simon John Raybould
//
//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:
//
//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.
//
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.
//===============================================================================================================


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace SimpleSerialSender
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    bool m_comPortOpen = false;

    private void Button_OpenClose_Click(object sender, EventArgs e)
    {
      if (m_comPortOpen) {
        closeComPort();
        m_comPortOpen = false;
      }
      else {
        m_comPortOpen = openComPort();
      }
      updateGuiControls();
    }

    void updateGuiControls()
    {
      if (m_comPortOpen) {
        updateGuiControlsForOpenComPort();
      }
      else {
        updateGuiControlsForClosedComPort();
      }
    }

    void updateGuiControlsForOpenComPort()
    {
      textBox_comPort.Enabled = false;
      textBox_baudRate.Enabled = false;
      checkBox_useTLS.Enabled = false;
      button_openClose.Text = "Close Com Port";
      textBox_hexToSend1.Enabled = true;
      button_send1.Enabled = true;
      textBox_hexToSend2.Enabled = true;
      button_send2.Enabled = true;
      textBox_hexToSend3.Enabled = true;
      button_send3.Enabled = true;
      textBox_hexToSend4.Enabled = true;
      button_send4.Enabled = true;
      textBox_hexToSend5.Enabled = true;
      button_send5.Enabled = true;
      textBox_hexToSend6.Enabled = true;
      button_send6.Enabled = true;
    }

    void updateGuiControlsForClosedComPort()
    {
      textBox_comPort.Enabled = true;
      textBox_baudRate.Enabled = true;
      checkBox_useTLS.Enabled = true;
      button_openClose.Text = "Open Com Port";
      textBox_hexToSend1.Enabled = false;
      button_send1.Enabled = false;
      textBox_hexToSend2.Enabled = false;
      button_send2.Enabled = false;
      textBox_hexToSend3.Enabled = false;
      button_send3.Enabled = false;
      textBox_hexToSend4.Enabled = false;
      button_send4.Enabled = false;
      textBox_hexToSend5.Enabled = false;
      button_send5.Enabled = false;
      textBox_hexToSend6.Enabled = false;
      button_send6.Enabled = false;
    }

    Stream m_commsStream = null;
    SslStream m_tlsStream = null;

    bool openComPort()
    {
      lock (myLock) {
        bool isOpened = false;
        serialPort1.PortName = textBox_comPort.Text;
        int baudRate;
        if (int.TryParse(textBox_baudRate.Text, out baudRate))
        {
          serialPort1.BaudRate = baudRate;
        }
        serialPort1.Parity = System.IO.Ports.Parity.None;
        serialPort1.StopBits = System.IO.Ports.StopBits.One;
        serialPort1.DataBits = 8;
        serialPort1.Handshake = System.IO.Ports.Handshake.None;
        serialPort1.RtsEnable = false;

        try {
          serialPort1.Open();
          m_commsStream = serialPort1.BaseStream;
          isOpened = true;
        }
        catch (Exception e) {
          string errorStr = String.Format("Exception: {0}", e.Message);
          OutputDebugMsg(errorStr);
          MessageBox.Show(e.Message);
        }
        if (isOpened) {
          //System.IO.Stream stream = serialPort1.BaseStream;
          if (checkBox_useTLS.Checked) {
            m_tlsStream = new SslStream(m_commsStream, false, new RemoteCertificateValidationCallback(ValidateServerCertificate), null);
            OutputString("Starting TLS Client Authentication");
            try {
              m_tlsStream.ReadTimeout = 3000; //3s timeout during TLS client authentication
              m_tlsStream.AuthenticateAsClient("");
            }
            catch (Exception e) {
              string errorStr = String.Format("Exception: {0}", e.Message);
              OutputDebugMsg(errorStr);
            }
            m_tlsStream.ReadTimeout = Timeout.Infinite;
            if (m_tlsStream.IsAuthenticated) {
              m_commsStream = m_tlsStream;
              OutputString("TLS Client Authentication Succeeded");
              button_showCertificate.Enabled = true;
            }
            else {
              isOpened = false;
              OutputString("TLS Client Authentication Failed!");
            }
          }
          if (!isOpened) {
            closeComPort();
          }
        }
        if (isOpened) {
          startReceiveThread();
        }
        return isOpened;
      }
    }

    void closeComPort()
    {
      lock (myLock) {
        button_showCertificate.Enabled = false;

        if (m_tlsStream != null) {
          OutputString("Shut down TLS Client");
          try {
            m_tlsStream.ShutdownAsync();
          }
          catch (Exception e) {
            string errorStr = String.Format("TlsClient ShutdownAsync Exception: {0}", e.Message);
            OutputDebugMsg(errorStr);
          }
          try {
            m_tlsStream.Close();
          }
          catch (Exception e) {
            string errorStr = String.Format("TlsClient Close Exception: {0}", e.Message);
            OutputDebugMsg(errorStr);
          }
          m_tlsStream = null;
        }
        m_receivedCertificate = null;

        if (serialPort1.IsOpen) {
          try {
            serialPort1.Close();
          }
          catch (Exception e) {
            string errorStr = String.Format("Exception: {0}", e.Message);
            OutputDebugMsg(errorStr);
          }
        }
        stopReceiveThread();
      }
    }

    private void sendHex(string hexString)
    {
      hexString = hexString.Replace(" ", "");
      hexString.ToUpper();

      if ((hexString.Length % 2) == 1) {
        MessageBox.Show("The hex string cannot have an odd length");
      }
      else {
        byte[] dataToSend = hexStringToByteArray(hexString);
        if (dataToSend.Length > 0) {
          if (m_comPortOpen) {
            m_commsStream.Write(dataToSend, 0, dataToSend.Length);
            string traceStr = String.Format("Sent {0} bytes: ", dataToSend.Length);
            OutputHexArray(traceStr, dataToSend);
          }
        }
      }
    }

    private static byte[] hexStringToByteArray(string hexString)
    {
      return Enumerable.Range(0, hexString.Length)
                     .Where(x => x % 2 == 0)
                     .Select(x => Convert.ToByte(hexString.Substring(x, 2), 16))
                     .ToArray();
    }

    private Object myLock = new Object();

    private void Button_send1_Click(object sender, EventArgs e)
    {
      sendHex(textBox_hexToSend1.Text);
    }

    private void Button_send2_Click(object sender, EventArgs e)
    {
      sendHex(textBox_hexToSend2.Text);
    }

    private void Button_send3_Click(object sender, EventArgs e)
    {
      sendHex(textBox_hexToSend3.Text);
    }

    private void Button_send4_Click(object sender, EventArgs e)
    {
      sendHex(textBox_hexToSend4.Text);
    }

    private void Button_send5_Click(object sender, EventArgs e)
    {
      sendHex(textBox_hexToSend5.Text);
    }

    private void Button_send6_Click(object sender, EventArgs e)
    {
      sendHex(textBox_hexToSend6.Text);
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      textBox_comPort.Text = SimpleSerialSender.Properties.Settings.Default.ComPort;
      textBox_baudRate.Text = SimpleSerialSender.Properties.Settings.Default.BaudRate;
      checkBox_useTLS.Checked = SimpleSerialSender.Properties.Settings.Default.UseTLS;
      textBox_hexToSend1.Text = SimpleSerialSender.Properties.Settings.Default.HexString1;
      textBox_hexToSend2.Text = SimpleSerialSender.Properties.Settings.Default.HexString2;
      textBox_hexToSend3.Text = SimpleSerialSender.Properties.Settings.Default.HexString3;
      textBox_hexToSend4.Text = SimpleSerialSender.Properties.Settings.Default.HexString4;
      textBox_hexToSend5.Text = SimpleSerialSender.Properties.Settings.Default.HexString5;
      textBox_hexToSend6.Text = SimpleSerialSender.Properties.Settings.Default.HexString6;
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      SimpleSerialSender.Properties.Settings.Default.ComPort = textBox_comPort.Text;
      SimpleSerialSender.Properties.Settings.Default.BaudRate = textBox_baudRate.Text;
      SimpleSerialSender.Properties.Settings.Default.UseTLS = checkBox_useTLS.Checked;
      SimpleSerialSender.Properties.Settings.Default.HexString1 = textBox_hexToSend1.Text;
      SimpleSerialSender.Properties.Settings.Default.HexString2 = textBox_hexToSend2.Text;
      SimpleSerialSender.Properties.Settings.Default.HexString3 = textBox_hexToSend3.Text;
      SimpleSerialSender.Properties.Settings.Default.HexString4 = textBox_hexToSend4.Text;
      SimpleSerialSender.Properties.Settings.Default.HexString5 = textBox_hexToSend5.Text;
      SimpleSerialSender.Properties.Settings.Default.HexString6 = textBox_hexToSend6.Text;
      SimpleSerialSender.Properties.Settings.Default.Save();

      closeComPort();
    }

    delegate void OutputStringDelegate(String msg);
    private void OutputString(String message)
    {
      if (listBox_dataTrace.InvokeRequired) {
        OutputStringDelegate update = new OutputStringDelegate(OutputString);
        try {
          listBox_dataTrace.Invoke(update, message);
        }
        catch (Exception /*e*/) {
          //Do nothing. Can come here on exit as the handler thread may have been terminated
        }
      }
      else {
        listBox_dataTrace.Items.Add(message);
        //Debug.WriteLine(message);

        //Restrict the number of lines
        while (listBox_dataTrace.Items.Count > Program.MaxOutputLines) {
          listBox_dataTrace.Items.RemoveAt(0); // remove first line
        }
        // Make sure the last item is visible
        listBox_dataTrace.SelectedIndex = listBox_dataTrace.Items.Count - 1;
        listBox_dataTrace.ClearSelected();
      }
    }

    public void OutputHexArray(String message, byte[] bytes)
    {
      message += byteArrayToString(bytes);
      OutputString(message);
    }

    public void OutputDebugMsg(String message)
    {
#if DEBUG
      OutputString("DEBUG_MSG: " + message);
#endif
    }

    Thread m_receiveThread;

    void startReceiveThread()
    {
      if (!m_threadRunning) {
        m_threadRunning = true;
        m_receiveThread = new Thread(new ThreadStart(receiveThreadMainLoop));
        m_receiveThread.Start();
        Thread.Sleep(10); //Let the thread start before trying to connect to the pipe
      }
    }

    void stopReceiveThread()
    {
      if (m_threadRunning) {
        m_threadRunning = false;
        m_receiveThread.Join();
      }
    }

    bool m_threadRunning = false;

    private void receiveThreadMainLoop()
    {
      const int RxBufferSize = 10240;
      byte[] rxBuffer = new byte[RxBufferSize];

      while (m_threadRunning) {
        if (m_comPortOpen) {
          int bytesReceived = 0;
          try {
            bytesReceived = m_commsStream.Read(rxBuffer, 0, RxBufferSize);
          }
          catch (Exception e) {
            if ((e.HResult & 0x80000000) == 0x80000000) {
              //stop();
            }
            else {
              string errorStr = String.Format("Exception: {0}", e.Message);
              OutputDebugMsg(errorStr);
              //stop();
            }
          }
          if (bytesReceived > 0) {
            byte[] trimmedArray = (byte[])rxBuffer.Clone();
            Array.Resize(ref trimmedArray, bytesReceived);
            string traceStr = String.Format("Received {0} bytes: ", bytesReceived);
            OutputHexArray(traceStr, trimmedArray);
          }
        }
      }
    }

    private static string byteArrayToString(byte[] ba)
    {
      string hex = BitConverter.ToString(ba);
      return hex.Replace("-", "");
    }

    private void Button_clearDataTrace_Click(object sender, EventArgs e)
    {
      listBox_dataTrace.Items.Clear();
    }

    public static bool ValidateServerCertificate(object sender,
                                             X509Certificate certificate,
                                             X509Chain chain,
                                             SslPolicyErrors sslPolicyErrors)
    {
      SslStream sslStream = sender as SslStream;
      m_receivedCertificate = new X509Certificate(certificate);

#if false
      if (sslPolicyErrors == SslPolicyErrors.None)
        return true;

      Console.WriteLine("Certificate error: {0}", sslPolicyErrors);
#endif
      // Do not allow this client to communicate with unauthenticated servers.
      return true;
    }

    public void showTlsCertificate()
    {
      if (m_receivedCertificate != null) {
        ShowCertificate showCertificate = new ShowCertificate(m_receivedCertificate);
        showCertificate.ShowDialog(Program.theAppMainForm);
      }
    }

    static X509Certificate m_receivedCertificate = null;

    private void Button_showCertificate_Click(object sender, EventArgs e)
    {
      showTlsCertificate();
    }
  }
}
