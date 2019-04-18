//===============================================================================================================
//  Project     : TcpSerialBridge
//  Filename    : ShowCertificate.cs
//  Author      : Simon Raybould
//  Date        : Sat 04 November 2017
//  Description : Shows a TLS certificate in a dialog
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;


namespace SimpleSerialSender
{
  public partial class ShowCertificate : Form
  {
    public ShowCertificate(X509Certificate certificate)
    {
      m_certificate = new X509Certificate(certificate);

      parseCertificate();
      InitializeComponent();
    }

    private void clear()
    {
      clearIssuedTo();
      clearIssuedBy();
    }

    private const string NoSpecifiedInCertificate = "<Not Specified in Certificate>";

    private void clearIssuedTo()
    {
      m_issuedTo.commonName = NoSpecifiedInCertificate;
      m_issuedTo.organisation = NoSpecifiedInCertificate;
      m_issuedTo.organisationalUnit = NoSpecifiedInCertificate;
      m_issuedTo.serialNumber = NoSpecifiedInCertificate;
    }

    private void clearIssuedBy()
    {
      m_issuedBy.commonName = NoSpecifiedInCertificate;
      m_issuedBy.organisation = NoSpecifiedInCertificate;
      m_issuedBy.organisationalUnit = NoSpecifiedInCertificate;
    }

    private void parseCertificate()
    {
      parseIssuedTo();
      parseIssuedBy();
    }

    private static string byteArrayToString(byte[] ba)
    {
      string hex = BitConverter.ToString(ba);
      return hex.Replace("-", ":");
    }

    private void parseIssuedTo()
    {
      clearIssuedTo();

      m_issuedTo.commonName = parseCommaSeparatedKeyAndValue(m_certificate.Subject, "CN");
      m_issuedTo.organisation = parseCommaSeparatedKeyAndValue(m_certificate.Subject, "O");
      m_issuedTo.organisationalUnit = parseCommaSeparatedKeyAndValue(m_certificate.Subject, "OU");
      m_issuedTo.serialNumber = Regex.Replace(m_certificate.GetSerialNumberString(), ".{2}", "$0:").TrimEnd(':');
    }

    private void parseIssuedBy()
    {
      clearIssuedBy();

      m_issuedBy.commonName = parseCommaSeparatedKeyAndValue(m_certificate.Issuer, "CN");
      m_issuedBy.organisation = parseCommaSeparatedKeyAndValue(m_certificate.Issuer, "O");
      m_issuedBy.organisationalUnit = parseCommaSeparatedKeyAndValue(m_certificate.Issuer, "OU");
    }

    private string parseCommaSeparatedKeyAndValue(string inputToParse, string key)
    {
      string value = NoSpecifiedInCertificate;

      //Format is a comma separated list of "Key=Value"
      string regexQuotedValue = key + "=" + "\".*\"";
      string regexUnquotedValue = key + "=" + ".[^,]+";
      Match m = Regex.Match(inputToParse, regexQuotedValue);
      if(!m.Success) {
        m = Regex.Match(inputToParse, regexUnquotedValue);
      }
      if (m.Success) {
        value = Regex.Replace(m.Value, key + "=", String.Empty).Trim('"');
      }

      return value;
    }

    private void ShowCertificate_Load(object sender, EventArgs e)
    {
      updateIssuedTo();
      updateIssuedBy();
      updatePeriodOfValidity();
    }

    private void updateIssuedTo()
    {
      label_issuedTo_commonName.Text = m_issuedTo.commonName;
      label_issuedTo_organisation.Text = m_issuedTo.organisation;
      label_issuedTo_organisationalUnit.Text = m_issuedTo.organisationalUnit;
      label_issuedTo_serialNumber.Text = m_issuedTo.serialNumber;
    }

    private void updateIssuedBy()
    {
      label_issuedBy_commonName.Text = m_issuedBy.commonName;
      label_issuedBy_organisation.Text = m_issuedBy.organisation;
      label_issuedBy_organisationalUnit.Text = m_issuedBy.organisationalUnit;
    }

    private void updatePeriodOfValidity()
    {
      label_periodOfValidity_beginsOn.Text = m_certificate.GetEffectiveDateString();
      label_periodOfValidity_ExpiresOn.Text = m_certificate.GetExpirationDateString();
    }

    struct IssuedTo
    {
      public string commonName;
      public string organisation;
      public string organisationalUnit;
      public string serialNumber;
    };
    struct IssuedBy
    {
      public string commonName;
      public string organisation;
      public string organisationalUnit;
    };

    X509Certificate m_certificate;
    IssuedTo m_issuedTo;
    IssuedBy m_issuedBy;
  }
}
