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


namespace SimpleSerialSender
{
  partial class ShowCertificate
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowCertificate));
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label_issuedTo_serialNumber = new System.Windows.Forms.Label();
      this.label_issuedTo_organisationalUnit = new System.Windows.Forms.Label();
      this.label_issuedTo_organisation = new System.Windows.Forms.Label();
      this.label_issuedTo_commonName = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label_issuedBy_organisationalUnit = new System.Windows.Forms.Label();
      this.label_issuedBy_organisation = new System.Windows.Forms.Label();
      this.label_issuedBy_commonName = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.label_periodOfValidity_ExpiresOn = new System.Windows.Forms.Label();
      this.label_periodOfValidity_beginsOn = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(106, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Common Name (CN):";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 38);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(83, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Organisation(O):";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 57);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(124, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Organisational Unit (OU):";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 76);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(76, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Serial Number:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(6, 22);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(59, 13);
      this.label5.TabIndex = 4;
      this.label5.Text = "Begins On:";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label_issuedTo_serialNumber);
      this.groupBox1.Controls.Add(this.label_issuedTo_organisationalUnit);
      this.groupBox1.Controls.Add(this.label_issuedTo_organisation);
      this.groupBox1.Controls.Add(this.label_issuedTo_commonName);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(576, 99);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Issued To";
      // 
      // label_issuedTo_serialNumber
      // 
      this.label_issuedTo_serialNumber.AutoSize = true;
      this.label_issuedTo_serialNumber.Location = new System.Drawing.Point(136, 76);
      this.label_issuedTo_serialNumber.Name = "label_issuedTo_serialNumber";
      this.label_issuedTo_serialNumber.Size = new System.Drawing.Size(175, 13);
      this.label_issuedTo_serialNumber.TabIndex = 10;
      this.label_issuedTo_serialNumber.Text = "XXXXXXXXXXXXXXXXXXXXXXXX";
      // 
      // label_issuedTo_organisationalUnit
      // 
      this.label_issuedTo_organisationalUnit.AutoSize = true;
      this.label_issuedTo_organisationalUnit.Location = new System.Drawing.Point(136, 57);
      this.label_issuedTo_organisationalUnit.Name = "label_issuedTo_organisationalUnit";
      this.label_issuedTo_organisationalUnit.Size = new System.Drawing.Size(175, 13);
      this.label_issuedTo_organisationalUnit.TabIndex = 9;
      this.label_issuedTo_organisationalUnit.Text = "XXXXXXXXXXXXXXXXXXXXXXXX";
      // 
      // label_issuedTo_organisation
      // 
      this.label_issuedTo_organisation.AutoSize = true;
      this.label_issuedTo_organisation.Location = new System.Drawing.Point(136, 38);
      this.label_issuedTo_organisation.Name = "label_issuedTo_organisation";
      this.label_issuedTo_organisation.Size = new System.Drawing.Size(175, 13);
      this.label_issuedTo_organisation.TabIndex = 8;
      this.label_issuedTo_organisation.Text = "XXXXXXXXXXXXXXXXXXXXXXXX";
      // 
      // label_issuedTo_commonName
      // 
      this.label_issuedTo_commonName.AutoSize = true;
      this.label_issuedTo_commonName.Location = new System.Drawing.Point(136, 19);
      this.label_issuedTo_commonName.Name = "label_issuedTo_commonName";
      this.label_issuedTo_commonName.Size = new System.Drawing.Size(175, 13);
      this.label_issuedTo_commonName.TabIndex = 7;
      this.label_issuedTo_commonName.Text = "XXXXXXXXXXXXXXXXXXXXXXXX";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label_issuedBy_organisationalUnit);
      this.groupBox2.Controls.Add(this.label_issuedBy_organisation);
      this.groupBox2.Controls.Add(this.label_issuedBy_commonName);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.label7);
      this.groupBox2.Controls.Add(this.label8);
      this.groupBox2.Location = new System.Drawing.Point(12, 117);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(576, 76);
      this.groupBox2.TabIndex = 4;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Issued By";
      // 
      // label_issuedBy_organisationalUnit
      // 
      this.label_issuedBy_organisationalUnit.AutoSize = true;
      this.label_issuedBy_organisationalUnit.Location = new System.Drawing.Point(136, 54);
      this.label_issuedBy_organisationalUnit.Name = "label_issuedBy_organisationalUnit";
      this.label_issuedBy_organisationalUnit.Size = new System.Drawing.Size(175, 13);
      this.label_issuedBy_organisationalUnit.TabIndex = 10;
      this.label_issuedBy_organisationalUnit.Text = "XXXXXXXXXXXXXXXXXXXXXXXX";
      // 
      // label_issuedBy_organisation
      // 
      this.label_issuedBy_organisation.AutoSize = true;
      this.label_issuedBy_organisation.Location = new System.Drawing.Point(136, 35);
      this.label_issuedBy_organisation.Name = "label_issuedBy_organisation";
      this.label_issuedBy_organisation.Size = new System.Drawing.Size(175, 13);
      this.label_issuedBy_organisation.TabIndex = 9;
      this.label_issuedBy_organisation.Text = "XXXXXXXXXXXXXXXXXXXXXXXX";
      // 
      // label_issuedBy_commonName
      // 
      this.label_issuedBy_commonName.AutoSize = true;
      this.label_issuedBy_commonName.Location = new System.Drawing.Point(136, 16);
      this.label_issuedBy_commonName.Name = "label_issuedBy_commonName";
      this.label_issuedBy_commonName.Size = new System.Drawing.Size(175, 13);
      this.label_issuedBy_commonName.TabIndex = 8;
      this.label_issuedBy_commonName.Text = "XXXXXXXXXXXXXXXXXXXXXXXX";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(6, 35);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(83, 13);
      this.label6.TabIndex = 4;
      this.label6.Text = "Organisation(O):";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(6, 16);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(106, 13);
      this.label7.TabIndex = 3;
      this.label7.Text = "Common Name (CN):";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(6, 54);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(124, 13);
      this.label8.TabIndex = 5;
      this.label8.Text = "Organisational Unit (OU):";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.label_periodOfValidity_ExpiresOn);
      this.groupBox3.Controls.Add(this.label_periodOfValidity_beginsOn);
      this.groupBox3.Controls.Add(this.label9);
      this.groupBox3.Controls.Add(this.label5);
      this.groupBox3.Location = new System.Drawing.Point(12, 199);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(576, 65);
      this.groupBox3.TabIndex = 6;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Period of Validity";
      // 
      // label_periodOfValidity_ExpiresOn
      // 
      this.label_periodOfValidity_ExpiresOn.AutoSize = true;
      this.label_periodOfValidity_ExpiresOn.Location = new System.Drawing.Point(136, 41);
      this.label_periodOfValidity_ExpiresOn.Name = "label_periodOfValidity_ExpiresOn";
      this.label_periodOfValidity_ExpiresOn.Size = new System.Drawing.Size(175, 13);
      this.label_periodOfValidity_ExpiresOn.TabIndex = 11;
      this.label_periodOfValidity_ExpiresOn.Text = "XXXXXXXXXXXXXXXXXXXXXXXX";
      // 
      // label_periodOfValidity_beginsOn
      // 
      this.label_periodOfValidity_beginsOn.AutoSize = true;
      this.label_periodOfValidity_beginsOn.Location = new System.Drawing.Point(136, 22);
      this.label_periodOfValidity_beginsOn.Name = "label_periodOfValidity_beginsOn";
      this.label_periodOfValidity_beginsOn.Size = new System.Drawing.Size(175, 13);
      this.label_periodOfValidity_beginsOn.TabIndex = 10;
      this.label_periodOfValidity_beginsOn.Text = "XXXXXXXXXXXXXXXXXXXXXXXX";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(6, 41);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(61, 13);
      this.label9.TabIndex = 5;
      this.label9.Text = "Expires On:";
      // 
      // ShowCertificate
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(600, 274);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "ShowCertificate";
      this.Text = "Ceretificate Information";
      this.Load += new System.EventHandler(this.ShowCertificate_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label_issuedTo_serialNumber;
    private System.Windows.Forms.Label label_issuedTo_organisationalUnit;
    private System.Windows.Forms.Label label_issuedTo_organisation;
    private System.Windows.Forms.Label label_issuedTo_commonName;
    private System.Windows.Forms.Label label_issuedBy_organisationalUnit;
    private System.Windows.Forms.Label label_issuedBy_organisation;
    private System.Windows.Forms.Label label_issuedBy_commonName;
    private System.Windows.Forms.Label label_periodOfValidity_ExpiresOn;
    private System.Windows.Forms.Label label_periodOfValidity_beginsOn;
  }
}