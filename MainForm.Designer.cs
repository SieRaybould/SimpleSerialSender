//===============================================================================================================
//  Project     : SimpleSerialSender
//  Filename    : MainForm.Designer.cs
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


namespace SimpleSerialSender
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.label1 = new System.Windows.Forms.Label();
      this.textBox_hexToSend1 = new System.Windows.Forms.TextBox();
      this.button_send1 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox_comPort = new System.Windows.Forms.TextBox();
      this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
      this.textBox_hexToSend2 = new System.Windows.Forms.TextBox();
      this.textBox_hexToSend3 = new System.Windows.Forms.TextBox();
      this.textBox_hexToSend4 = new System.Windows.Forms.TextBox();
      this.textBox_hexToSend5 = new System.Windows.Forms.TextBox();
      this.button_send2 = new System.Windows.Forms.Button();
      this.button_send3 = new System.Windows.Forms.Button();
      this.button_send4 = new System.Windows.Forms.Button();
      this.button_send5 = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.listBox_dataTrace = new System.Windows.Forms.ListBox();
      this.button_openClose = new System.Windows.Forms.Button();
      this.button_clearDataTrace = new System.Windows.Forms.Button();
      this.checkBox_useTLS = new System.Windows.Forms.CheckBox();
      this.button_showCertificate = new System.Windows.Forms.Button();
      this.textBox_baudRate = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.button_send6 = new System.Windows.Forms.Button();
      this.textBox_hexToSend6 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(35, 41);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(29, 13);
      this.label1.TabIndex = 7;
      this.label1.Text = "Hex:";
      // 
      // textBox_hexToSend1
      // 
      this.textBox_hexToSend1.Enabled = false;
      this.textBox_hexToSend1.Location = new System.Drawing.Point(70, 38);
      this.textBox_hexToSend1.Name = "textBox_hexToSend1";
      this.textBox_hexToSend1.Size = new System.Drawing.Size(604, 20);
      this.textBox_hexToSend1.TabIndex = 8;
      // 
      // button_send1
      // 
      this.button_send1.Enabled = false;
      this.button_send1.Location = new System.Drawing.Point(680, 36);
      this.button_send1.Name = "button_send1";
      this.button_send1.Size = new System.Drawing.Size(75, 23);
      this.button_send1.TabIndex = 9;
      this.button_send1.Text = "Send";
      this.button_send1.UseVisualStyleBackColor = true;
      this.button_send1.Click += new System.EventHandler(this.Button_send1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(11, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Com Port:";
      // 
      // textBox_comPort
      // 
      this.textBox_comPort.Location = new System.Drawing.Point(70, 12);
      this.textBox_comPort.Name = "textBox_comPort";
      this.textBox_comPort.Size = new System.Drawing.Size(51, 20);
      this.textBox_comPort.TabIndex = 1;
      // 
      // textBox_hexToSend2
      // 
      this.textBox_hexToSend2.Enabled = false;
      this.textBox_hexToSend2.Location = new System.Drawing.Point(70, 65);
      this.textBox_hexToSend2.Name = "textBox_hexToSend2";
      this.textBox_hexToSend2.Size = new System.Drawing.Size(604, 20);
      this.textBox_hexToSend2.TabIndex = 11;
      // 
      // textBox_hexToSend3
      // 
      this.textBox_hexToSend3.Enabled = false;
      this.textBox_hexToSend3.Location = new System.Drawing.Point(70, 90);
      this.textBox_hexToSend3.Name = "textBox_hexToSend3";
      this.textBox_hexToSend3.Size = new System.Drawing.Size(604, 20);
      this.textBox_hexToSend3.TabIndex = 14;
      // 
      // textBox_hexToSend4
      // 
      this.textBox_hexToSend4.Enabled = false;
      this.textBox_hexToSend4.Location = new System.Drawing.Point(70, 116);
      this.textBox_hexToSend4.Name = "textBox_hexToSend4";
      this.textBox_hexToSend4.Size = new System.Drawing.Size(604, 20);
      this.textBox_hexToSend4.TabIndex = 17;
      // 
      // textBox_hexToSend5
      // 
      this.textBox_hexToSend5.Enabled = false;
      this.textBox_hexToSend5.Location = new System.Drawing.Point(70, 142);
      this.textBox_hexToSend5.Name = "textBox_hexToSend5";
      this.textBox_hexToSend5.Size = new System.Drawing.Size(604, 20);
      this.textBox_hexToSend5.TabIndex = 20;
      // 
      // button_send2
      // 
      this.button_send2.Enabled = false;
      this.button_send2.Location = new System.Drawing.Point(680, 62);
      this.button_send2.Name = "button_send2";
      this.button_send2.Size = new System.Drawing.Size(75, 23);
      this.button_send2.TabIndex = 12;
      this.button_send2.Text = "Send";
      this.button_send2.UseVisualStyleBackColor = true;
      this.button_send2.Click += new System.EventHandler(this.Button_send2_Click);
      // 
      // button_send3
      // 
      this.button_send3.Enabled = false;
      this.button_send3.Location = new System.Drawing.Point(680, 88);
      this.button_send3.Name = "button_send3";
      this.button_send3.Size = new System.Drawing.Size(75, 23);
      this.button_send3.TabIndex = 15;
      this.button_send3.Text = "Send";
      this.button_send3.UseVisualStyleBackColor = true;
      this.button_send3.Click += new System.EventHandler(this.Button_send3_Click);
      // 
      // button_send4
      // 
      this.button_send4.Enabled = false;
      this.button_send4.Location = new System.Drawing.Point(680, 114);
      this.button_send4.Name = "button_send4";
      this.button_send4.Size = new System.Drawing.Size(75, 23);
      this.button_send4.TabIndex = 18;
      this.button_send4.Text = "Send";
      this.button_send4.UseVisualStyleBackColor = true;
      this.button_send4.Click += new System.EventHandler(this.Button_send4_Click);
      // 
      // button_send5
      // 
      this.button_send5.Enabled = false;
      this.button_send5.Location = new System.Drawing.Point(680, 140);
      this.button_send5.Name = "button_send5";
      this.button_send5.Size = new System.Drawing.Size(75, 23);
      this.button_send5.TabIndex = 21;
      this.button_send5.Text = "Send";
      this.button_send5.UseVisualStyleBackColor = true;
      this.button_send5.Click += new System.EventHandler(this.Button_send5_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(35, 67);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(29, 13);
      this.label3.TabIndex = 10;
      this.label3.Text = "Hex:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(35, 93);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(29, 13);
      this.label4.TabIndex = 13;
      this.label4.Text = "Hex:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(35, 119);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(29, 13);
      this.label5.TabIndex = 16;
      this.label5.Text = "Hex:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(35, 145);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(29, 13);
      this.label6.TabIndex = 19;
      this.label6.Text = "Hex:";
      // 
      // listBox_dataTrace
      // 
      this.listBox_dataTrace.FormattingEnabled = true;
      this.listBox_dataTrace.Location = new System.Drawing.Point(14, 206);
      this.listBox_dataTrace.Name = "listBox_dataTrace";
      this.listBox_dataTrace.Size = new System.Drawing.Size(741, 290);
      this.listBox_dataTrace.TabIndex = 25;
      // 
      // button_openClose
      // 
      this.button_openClose.Location = new System.Drawing.Point(303, 10);
      this.button_openClose.Name = "button_openClose";
      this.button_openClose.Size = new System.Drawing.Size(115, 23);
      this.button_openClose.TabIndex = 4;
      this.button_openClose.Text = "Open Com Port";
      this.button_openClose.UseVisualStyleBackColor = true;
      this.button_openClose.Click += new System.EventHandler(this.Button_OpenClose_Click);
      // 
      // button_clearDataTrace
      // 
      this.button_clearDataTrace.Location = new System.Drawing.Point(710, 206);
      this.button_clearDataTrace.Name = "button_clearDataTrace";
      this.button_clearDataTrace.Size = new System.Drawing.Size(45, 22);
      this.button_clearDataTrace.TabIndex = 26;
      this.button_clearDataTrace.Text = "Clear";
      this.button_clearDataTrace.UseVisualStyleBackColor = true;
      this.button_clearDataTrace.Click += new System.EventHandler(this.Button_clearDataTrace_Click);
      // 
      // checkBox_useTLS
      // 
      this.checkBox_useTLS.AutoSize = true;
      this.checkBox_useTLS.Location = new System.Drawing.Point(509, 14);
      this.checkBox_useTLS.Name = "checkBox_useTLS";
      this.checkBox_useTLS.Size = new System.Drawing.Size(68, 17);
      this.checkBox_useTLS.TabIndex = 5;
      this.checkBox_useTLS.Text = "Use TLS";
      this.checkBox_useTLS.UseVisualStyleBackColor = true;
      // 
      // button_showCertificate
      // 
      this.button_showCertificate.Enabled = false;
      this.button_showCertificate.Location = new System.Drawing.Point(583, 10);
      this.button_showCertificate.Name = "button_showCertificate";
      this.button_showCertificate.Size = new System.Drawing.Size(172, 23);
      this.button_showCertificate.TabIndex = 6;
      this.button_showCertificate.Text = "Show Received Certificate";
      this.button_showCertificate.UseVisualStyleBackColor = true;
      this.button_showCertificate.Click += new System.EventHandler(this.Button_showCertificate_Click);
      // 
      // textBox_baudRate
      // 
      this.textBox_baudRate.Location = new System.Drawing.Point(197, 12);
      this.textBox_baudRate.Name = "textBox_baudRate";
      this.textBox_baudRate.Size = new System.Drawing.Size(100, 20);
      this.textBox_baudRate.TabIndex = 3;
      this.textBox_baudRate.Text = "9600";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(130, 15);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(61, 13);
      this.label7.TabIndex = 2;
      this.label7.Text = "Baud Rate:";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(35, 171);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(29, 13);
      this.label8.TabIndex = 22;
      this.label8.Text = "Hex:";
      // 
      // button_send6
      // 
      this.button_send6.Enabled = false;
      this.button_send6.Location = new System.Drawing.Point(680, 166);
      this.button_send6.Name = "button_send6";
      this.button_send6.Size = new System.Drawing.Size(75, 23);
      this.button_send6.TabIndex = 24;
      this.button_send6.Text = "Send";
      this.button_send6.UseVisualStyleBackColor = true;
      this.button_send6.Click += new System.EventHandler(this.Button_send6_Click);
      // 
      // textBox_hexToSend6
      // 
      this.textBox_hexToSend6.Enabled = false;
      this.textBox_hexToSend6.Location = new System.Drawing.Point(70, 168);
      this.textBox_hexToSend6.Name = "textBox_hexToSend6";
      this.textBox_hexToSend6.Size = new System.Drawing.Size(604, 20);
      this.textBox_hexToSend6.TabIndex = 23;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(767, 508);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.button_send6);
      this.Controls.Add(this.textBox_hexToSend6);
      this.Controls.Add(this.textBox_baudRate);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.button_showCertificate);
      this.Controls.Add(this.checkBox_useTLS);
      this.Controls.Add(this.button_clearDataTrace);
      this.Controls.Add(this.button_openClose);
      this.Controls.Add(this.listBox_dataTrace);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.button_send5);
      this.Controls.Add(this.button_send4);
      this.Controls.Add(this.button_send3);
      this.Controls.Add(this.button_send2);
      this.Controls.Add(this.textBox_hexToSend5);
      this.Controls.Add(this.textBox_hexToSend4);
      this.Controls.Add(this.textBox_hexToSend3);
      this.Controls.Add(this.textBox_hexToSend2);
      this.Controls.Add(this.textBox_comPort);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.button_send1);
      this.Controls.Add(this.textBox_hexToSend1);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.Text = "Simple Serial Sender";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox_hexToSend1;
    private System.Windows.Forms.Button button_send1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox_comPort;
    private System.IO.Ports.SerialPort serialPort1;
    private System.Windows.Forms.TextBox textBox_hexToSend2;
    private System.Windows.Forms.TextBox textBox_hexToSend3;
    private System.Windows.Forms.TextBox textBox_hexToSend4;
    private System.Windows.Forms.TextBox textBox_hexToSend5;
    private System.Windows.Forms.Button button_send2;
    private System.Windows.Forms.Button button_send3;
    private System.Windows.Forms.Button button_send4;
    private System.Windows.Forms.Button button_send5;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ListBox listBox_dataTrace;
    private System.Windows.Forms.Button button_openClose;
    private System.Windows.Forms.Button button_clearDataTrace;
    private System.Windows.Forms.CheckBox checkBox_useTLS;
    private System.Windows.Forms.Button button_showCertificate;
    private System.Windows.Forms.TextBox textBox_baudRate;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button button_send6;
    private System.Windows.Forms.TextBox textBox_hexToSend6;
  }
}

