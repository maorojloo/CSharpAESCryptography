namespace CSharpAESCryptography
{
    partial class Form1
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
            this.GpTextEncryption = new System.Windows.Forms.GroupBox();
            this.GpFileEncryption = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEncryptedText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPlainText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDecryptedText = new System.Windows.Forms.TextBox();
            this.BtnEncryptText = new System.Windows.Forms.Button();
            this.BtnDecryptText = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtOriginalFilePath = new System.Windows.Forms.TextBox();
            this.BtnBrowseOriginalFile = new System.Windows.Forms.Button();
            this.BtnEncryptFile = new System.Windows.Forms.Button();
            this.BtnDecryptFile = new System.Windows.Forms.Button();
            this.BtbBrowseEncryptedFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEncryptedFilePath = new System.Windows.Forms.TextBox();
            this.GpTextEncryption.SuspendLayout();
            this.GpFileEncryption.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpTextEncryption
            // 
            this.GpTextEncryption.Controls.Add(this.label2);
            this.GpTextEncryption.Controls.Add(this.TxtPassword);
            this.GpTextEncryption.Dock = System.Windows.Forms.DockStyle.Top;
            this.GpTextEncryption.Location = new System.Drawing.Point(0, 0);
            this.GpTextEncryption.Name = "GpTextEncryption";
            this.GpTextEncryption.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GpTextEncryption.Size = new System.Drawing.Size(758, 74);
            this.GpTextEncryption.TabIndex = 0;
            this.GpTextEncryption.TabStop = false;
            this.GpTextEncryption.Text = "تنظیمات";
            // 
            // GpFileEncryption
            // 
            this.GpFileEncryption.Controls.Add(this.BtbBrowseEncryptedFile);
            this.GpFileEncryption.Controls.Add(this.label5);
            this.GpFileEncryption.Controls.Add(this.TxtEncryptedFilePath);
            this.GpFileEncryption.Controls.Add(this.BtnDecryptFile);
            this.GpFileEncryption.Controls.Add(this.BtnEncryptFile);
            this.GpFileEncryption.Controls.Add(this.BtnBrowseOriginalFile);
            this.GpFileEncryption.Controls.Add(this.label7);
            this.GpFileEncryption.Controls.Add(this.TxtOriginalFilePath);
            this.GpFileEncryption.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GpFileEncryption.Location = new System.Drawing.Point(0, 324);
            this.GpFileEncryption.Name = "GpFileEncryption";
            this.GpFileEncryption.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GpFileEncryption.Size = new System.Drawing.Size(758, 202);
            this.GpFileEncryption.TabIndex = 1;
            this.GpFileEncryption.TabStop = false;
            this.GpFileEncryption.Text = "رمزگذاری فایل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "پسورد";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(256, 42);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(230, 26);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.Text = "123456789";
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDecryptText);
            this.groupBox1.Controls.Add(this.BtnEncryptText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtDecryptedText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtEncryptedText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtPlainText);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(758, 233);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "رمزگذاری متن";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(669, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "خروجی";
            // 
            // TxtEncryptedText
            // 
            this.TxtEncryptedText.Location = new System.Drawing.Point(197, 106);
            this.TxtEncryptedText.Name = "TxtEncryptedText";
            this.TxtEncryptedText.ReadOnly = true;
            this.TxtEncryptedText.Size = new System.Drawing.Size(549, 26);
            this.TxtEncryptedText.TabIndex = 2;
            this.TxtEncryptedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(527, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "متنی که میخواهید رمزگذاری شود";
            // 
            // TxtPlainText
            // 
            this.TxtPlainText.Location = new System.Drawing.Point(197, 55);
            this.TxtPlainText.Name = "TxtPlainText";
            this.TxtPlainText.Size = new System.Drawing.Size(549, 26);
            this.TxtPlainText.TabIndex = 0;
            this.TxtPlainText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(560, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "متن رمزگشایی شده";
            // 
            // TxtDecryptedText
            // 
            this.TxtDecryptedText.Location = new System.Drawing.Point(197, 191);
            this.TxtDecryptedText.Name = "TxtDecryptedText";
            this.TxtDecryptedText.ReadOnly = true;
            this.TxtDecryptedText.Size = new System.Drawing.Size(549, 26);
            this.TxtDecryptedText.TabIndex = 6;
            this.TxtDecryptedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnEncryptText
            // 
            this.BtnEncryptText.Location = new System.Drawing.Point(27, 67);
            this.BtnEncryptText.Name = "BtnEncryptText";
            this.BtnEncryptText.Size = new System.Drawing.Size(160, 48);
            this.BtnEncryptText.TabIndex = 8;
            this.BtnEncryptText.Text = "رمزگذاری متن";
            this.BtnEncryptText.UseVisualStyleBackColor = true;
            this.BtnEncryptText.Click += new System.EventHandler(this.BtnEncryptText_Click);
            // 
            // BtnDecryptText
            // 
            this.BtnDecryptText.Location = new System.Drawing.Point(24, 179);
            this.BtnDecryptText.Name = "BtnDecryptText";
            this.BtnDecryptText.Size = new System.Drawing.Size(160, 48);
            this.BtnDecryptText.TabIndex = 9;
            this.BtnDecryptText.Text = "رمزگشایی";
            this.BtnDecryptText.UseVisualStyleBackColor = true;
            this.BtnDecryptText.Click += new System.EventHandler(this.BtnDecryptText_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(442, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(310, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "آدرس فایلی که میخواهید رمزگذاری شود";
            // 
            // TxtOriginalFilePath
            // 
            this.TxtOriginalFilePath.Location = new System.Drawing.Point(275, 79);
            this.TxtOriginalFilePath.Name = "TxtOriginalFilePath";
            this.TxtOriginalFilePath.ReadOnly = true;
            this.TxtOriginalFilePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtOriginalFilePath.Size = new System.Drawing.Size(471, 26);
            this.TxtOriginalFilePath.TabIndex = 8;
            // 
            // BtnBrowseOriginalFile
            // 
            this.BtnBrowseOriginalFile.Location = new System.Drawing.Point(197, 74);
            this.BtnBrowseOriginalFile.Name = "BtnBrowseOriginalFile";
            this.BtnBrowseOriginalFile.Size = new System.Drawing.Size(72, 35);
            this.BtnBrowseOriginalFile.TabIndex = 10;
            this.BtnBrowseOriginalFile.Text = ". . .";
            this.BtnBrowseOriginalFile.UseVisualStyleBackColor = true;
            this.BtnBrowseOriginalFile.Click += new System.EventHandler(this.BtnBrowseOriginalFile_Click);
            // 
            // BtnEncryptFile
            // 
            this.BtnEncryptFile.Location = new System.Drawing.Point(27, 67);
            this.BtnEncryptFile.Name = "BtnEncryptFile";
            this.BtnEncryptFile.Size = new System.Drawing.Size(160, 48);
            this.BtnEncryptFile.TabIndex = 11;
            this.BtnEncryptFile.Text = "رمزگذاری";
            this.BtnEncryptFile.UseVisualStyleBackColor = true;
            this.BtnEncryptFile.Click += new System.EventHandler(this.BtnEncryptFile_Click);
            // 
            // BtnDecryptFile
            // 
            this.BtnDecryptFile.Location = new System.Drawing.Point(27, 132);
            this.BtnDecryptFile.Name = "BtnDecryptFile";
            this.BtnDecryptFile.Size = new System.Drawing.Size(160, 48);
            this.BtnDecryptFile.TabIndex = 12;
            this.BtnDecryptFile.Text = "رمزگشایی";
            this.BtnDecryptFile.UseVisualStyleBackColor = true;
            this.BtnDecryptFile.Click += new System.EventHandler(this.BtnDecryptFile_Click);
            // 
            // BtbBrowseEncryptedFile
            // 
            this.BtbBrowseEncryptedFile.Location = new System.Drawing.Point(197, 139);
            this.BtbBrowseEncryptedFile.Name = "BtbBrowseEncryptedFile";
            this.BtbBrowseEncryptedFile.Size = new System.Drawing.Size(72, 35);
            this.BtbBrowseEncryptedFile.TabIndex = 15;
            this.BtbBrowseEncryptedFile.Text = ". . .";
            this.BtbBrowseEncryptedFile.UseVisualStyleBackColor = true;
            this.BtbBrowseEncryptedFile.Click += new System.EventHandler(this.BtbBrowseEncryptedFile_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(442, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(307, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "آدرس فایلی که میخواهید رمزگشایی شود";
            // 
            // TxtEncryptedFilePath
            // 
            this.TxtEncryptedFilePath.Location = new System.Drawing.Point(275, 144);
            this.TxtEncryptedFilePath.Name = "TxtEncryptedFilePath";
            this.TxtEncryptedFilePath.ReadOnly = true;
            this.TxtEncryptedFilePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtEncryptedFilePath.Size = new System.Drawing.Size(471, 26);
            this.TxtEncryptedFilePath.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 526);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GpFileEncryption);
            this.Controls.Add(this.GpTextEncryption);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SourceSara.Com | C# AES Cryptography";
            this.GpTextEncryption.ResumeLayout(false);
            this.GpTextEncryption.PerformLayout();
            this.GpFileEncryption.ResumeLayout(false);
            this.GpFileEncryption.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GpTextEncryption;
        private System.Windows.Forms.GroupBox GpFileEncryption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtEncryptedText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPlainText;
        private System.Windows.Forms.Button BtnDecryptText;
        private System.Windows.Forms.Button BtnEncryptText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDecryptedText;
        private System.Windows.Forms.Button BtbBrowseEncryptedFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnDecryptFile;
        private System.Windows.Forms.Button BtnEncryptFile;
        private System.Windows.Forms.Button BtnBrowseOriginalFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtEncryptedFilePath;
        private System.Windows.Forms.TextBox TxtOriginalFilePath;
    }
}

