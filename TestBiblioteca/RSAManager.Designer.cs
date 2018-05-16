namespace TestBiblioteca
{
  partial class RSAManager
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
      if (disposing && (components != null))
      {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSAManager));
      this.btnGenerateToken = new System.Windows.Forms.Button();
      this.txtPublicKey = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtPrivateKey = new System.Windows.Forms.TextBox();
      this.btnDecodeToken = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txtHeader = new System.Windows.Forms.TextBox();
      this.txtPayLoad = new System.Windows.Forms.TextBox();
      this.txtToken = new System.Windows.Forms.TextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.txtDecodeToken = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtXMLRsaPublic = new System.Windows.Forms.TextBox();
      this.txtXMLRSAPrivate = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.btnRSAPublicGen = new System.Windows.Forms.Button();
      this.btnRSAPrivateGen = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnGenerateToken
      // 
      this.btnGenerateToken.Location = new System.Drawing.Point(166, 508);
      this.btnGenerateToken.Name = "btnGenerateToken";
      this.btnGenerateToken.Size = new System.Drawing.Size(145, 23);
      this.btnGenerateToken.TabIndex = 0;
      this.btnGenerateToken.Text = "Generate Token";
      this.btnGenerateToken.UseVisualStyleBackColor = true;
      this.btnGenerateToken.Click += new System.EventHandler(this.btnGenerateToken_Click);
      // 
      // txtPublicKey
      // 
      this.txtPublicKey.Location = new System.Drawing.Point(12, 31);
      this.txtPublicKey.Multiline = true;
      this.txtPublicKey.Name = "txtPublicKey";
      this.txtPublicKey.Size = new System.Drawing.Size(362, 209);
      this.txtPublicKey.TabIndex = 1;
      this.txtPublicKey.Text = resources.GetString("txtPublicKey.Text");
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(56, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Public key";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(377, 12);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Private key";
      // 
      // txtPrivateKey
      // 
      this.txtPrivateKey.Location = new System.Drawing.Point(380, 31);
      this.txtPrivateKey.Multiline = true;
      this.txtPrivateKey.Name = "txtPrivateKey";
      this.txtPrivateKey.Size = new System.Drawing.Size(362, 209);
      this.txtPrivateKey.TabIndex = 1;
      this.txtPrivateKey.Text = resources.GetString("txtPrivateKey.Text");
      // 
      // btnDecodeToken
      // 
      this.btnDecodeToken.Location = new System.Drawing.Point(317, 508);
      this.btnDecodeToken.Name = "btnDecodeToken";
      this.btnDecodeToken.Size = new System.Drawing.Size(145, 23);
      this.btnDecodeToken.TabIndex = 7;
      this.btnDecodeToken.Text = "Decode";
      this.btnDecodeToken.UseVisualStyleBackColor = true;
      this.btnDecodeToken.Click += new System.EventHandler(this.btnDecodeToken_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(748, 12);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(42, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Header";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(745, 131);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(45, 13);
      this.label5.TabIndex = 5;
      this.label5.Text = "Payload";
      // 
      // txtHeader
      // 
      this.txtHeader.Location = new System.Drawing.Point(748, 31);
      this.txtHeader.Multiline = true;
      this.txtHeader.Name = "txtHeader";
      this.txtHeader.Size = new System.Drawing.Size(362, 89);
      this.txtHeader.TabIndex = 1;
      this.txtHeader.Text = "{\r\n  \"alg\": \"RS256\",\r\n  \"typ\": \"JWT\"\r\n}";
      // 
      // txtPayLoad
      // 
      this.txtPayLoad.Location = new System.Drawing.Point(748, 151);
      this.txtPayLoad.Multiline = true;
      this.txtPayLoad.Name = "txtPayLoad";
      this.txtPayLoad.Size = new System.Drawing.Size(362, 89);
      this.txtPayLoad.TabIndex = 1;
      this.txtPayLoad.Text = "{\r\n  \"name\": \"Generic User\",\r\n  \"admin\": true\r\n}";
      // 
      // txtToken
      // 
      this.txtToken.Location = new System.Drawing.Point(13, 30);
      this.txtToken.Multiline = true;
      this.txtToken.Name = "txtToken";
      this.txtToken.Size = new System.Drawing.Size(349, 177);
      this.txtToken.TabIndex = 8;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.panel1.Controls.Add(this.txtDecodeToken);
      this.panel1.Controls.Add(this.txtToken);
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Location = new System.Drawing.Point(12, 275);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(730, 221);
      this.panel1.TabIndex = 9;
      // 
      // txtDecodeToken
      // 
      this.txtDecodeToken.Location = new System.Drawing.Point(368, 30);
      this.txtDecodeToken.Multiline = true;
      this.txtDecodeToken.Name = "txtDecodeToken";
      this.txtDecodeToken.Size = new System.Drawing.Size(352, 177);
      this.txtDecodeToken.TabIndex = 8;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(365, 10);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(85, 13);
      this.label6.TabIndex = 4;
      this.label6.Text = "Decoded Token";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(14, 10);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(127, 13);
      this.label4.TabIndex = 4;
      this.label4.Text = "JSON Web Token (JWT)";
      // 
      // txtXMLRsaPublic
      // 
      this.txtXMLRsaPublic.Location = new System.Drawing.Point(749, 291);
      this.txtXMLRsaPublic.Multiline = true;
      this.txtXMLRsaPublic.Name = "txtXMLRsaPublic";
      this.txtXMLRsaPublic.Size = new System.Drawing.Size(362, 89);
      this.txtXMLRsaPublic.TabIndex = 1;
      // 
      // txtXMLRSAPrivate
      // 
      this.txtXMLRSAPrivate.Location = new System.Drawing.Point(747, 407);
      this.txtXMLRSAPrivate.Multiline = true;
      this.txtXMLRSAPrivate.Name = "txtXMLRSAPrivate";
      this.txtXMLRSAPrivate.Size = new System.Drawing.Size(362, 89);
      this.txtXMLRSAPrivate.TabIndex = 1;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(753, 275);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(112, 13);
      this.label7.TabIndex = 4;
      this.label7.Text = "XML RSA (Public key)";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(748, 391);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(116, 13);
      this.label8.TabIndex = 5;
      this.label8.Text = "XML RSA (Private key)";
      // 
      // btnRSAPublicGen
      // 
      this.btnRSAPublicGen.Location = new System.Drawing.Point(468, 508);
      this.btnRSAPublicGen.Name = "btnRSAPublicGen";
      this.btnRSAPublicGen.Size = new System.Drawing.Size(177, 23);
      this.btnRSAPublicGen.TabIndex = 0;
      this.btnRSAPublicGen.Text = "Generate XML RSA (Public Key)";
      this.btnRSAPublicGen.UseVisualStyleBackColor = true;
      this.btnRSAPublicGen.Click += new System.EventHandler(this.btnRSAPublicGen_Click);
      // 
      // btnRSAPrivateGen
      // 
      this.btnRSAPrivateGen.Location = new System.Drawing.Point(651, 508);
      this.btnRSAPrivateGen.Name = "btnRSAPrivateGen";
      this.btnRSAPrivateGen.Size = new System.Drawing.Size(176, 23);
      this.btnRSAPrivateGen.TabIndex = 7;
      this.btnRSAPrivateGen.Text = "Generate XML RSA (Private Key)";
      this.btnRSAPrivateGen.UseVisualStyleBackColor = true;
      this.btnRSAPrivateGen.Click += new System.EventHandler(this.btnRSAPrivateGen_Click);
      // 
      // btnClear
      // 
      this.btnClear.Location = new System.Drawing.Point(833, 508);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(145, 23);
      this.btnClear.TabIndex = 10;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // RSAManager
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1121, 543);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.btnRSAPrivateGen);
      this.Controls.Add(this.btnDecodeToken);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtPrivateKey);
      this.Controls.Add(this.txtXMLRSAPrivate);
      this.Controls.Add(this.txtXMLRsaPublic);
      this.Controls.Add(this.txtPayLoad);
      this.Controls.Add(this.txtHeader);
      this.Controls.Add(this.btnRSAPublicGen);
      this.Controls.Add(this.txtPublicKey);
      this.Controls.Add(this.btnGenerateToken);
      this.Name = "RSAManager";
      this.Text = "Sample - RSA Manager (RSA 256) / JSON Web Token (JWT)";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnGenerateToken;
    private System.Windows.Forms.TextBox txtPublicKey;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtPrivateKey;
    private System.Windows.Forms.Button btnDecodeToken;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtHeader;
    private System.Windows.Forms.TextBox txtPayLoad;
    private System.Windows.Forms.TextBox txtToken;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txtDecodeToken;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtXMLRsaPublic;
    private System.Windows.Forms.TextBox txtXMLRSAPrivate;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button btnRSAPublicGen;
    private System.Windows.Forms.Button btnRSAPrivateGen;
    private System.Windows.Forms.Button btnClear;
  }
}

