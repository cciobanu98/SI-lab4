namespace CryptoPad
{
    partial class frmCryptoModeSelect
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
            this.components = new System.ComponentModel.Container();
            this.cbPassword = new System.Windows.Forms.CheckBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.cbRSA = new System.Windows.Forms.CheckBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.lblRsaName = new System.Windows.Forms.Label();
            this.btnRsaSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPassword
            // 
            this.cbPassword.AutoSize = true;
            this.cbPassword.Location = new System.Drawing.Point(16, 47);
            this.cbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPassword.Name = "cbPassword";
            this.cbPassword.Size = new System.Drawing.Size(91, 21);
            this.cbPassword.TabIndex = 6;
            this.cbPassword.Text = "Password";
            this.ttMain.SetToolTip(this.cbPassword, "Allows decryption using an ordinary password.");
            this.cbPassword.UseVisualStyleBackColor = true;
            this.cbPassword.CheckedChanged += new System.EventHandler(this.cbPassword_CheckedChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Enabled = false;
            this.tbPassword.Location = new System.Drawing.Point(131, 47);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(465, 22);
            this.tbPassword.TabIndex = 7;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(16, 11);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(168, 17);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Select encryption method";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(519, 126);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(640, 126);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ttMain
            // 
            this.ttMain.AutoPopDelay = 32767;
            this.ttMain.InitialDelay = 1;
            this.ttMain.ReshowDelay = 1;
            this.ttMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttMain.ToolTipTitle = "Crypto mode information";
            this.ttMain.UseAnimation = false;
            this.ttMain.UseFading = false;
            // 
            // cbRSA
            // 
            this.cbRSA.AutoSize = true;
            this.cbRSA.Location = new System.Drawing.Point(16, 86);
            this.cbRSA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRSA.Name = "cbRSA";
            this.cbRSA.Size = new System.Drawing.Size(86, 21);
            this.cbRSA.TabIndex = 8;
            this.cbRSA.Text = "RSA Key";
            this.ttMain.SetToolTip(this.cbRSA, "Encrypts using the RSA algorithm\r\nMost useful to encrypt a file for someone else\r" +
        "\n");
            this.cbRSA.UseVisualStyleBackColor = true;
            this.cbRSA.CheckedChanged += new System.EventHandler(this.cbRSA_CheckedChanged);
            // 
            // lblRsaName
            // 
            this.lblRsaName.AutoSize = true;
            this.lblRsaName.Enabled = false;
            this.lblRsaName.Location = new System.Drawing.Point(140, 90);
            this.lblRsaName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRsaName.Name = "lblRsaName";
            this.lblRsaName.Size = new System.Drawing.Size(125, 17);
            this.lblRsaName.TabIndex = 9;
            this.lblRsaName.Text = "<No key selected>";
            // 
            // btnRsaSelect
            // 
            this.btnRsaSelect.Enabled = false;
            this.btnRsaSelect.Location = new System.Drawing.Point(637, 90);
            this.btnRsaSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRsaSelect.Name = "btnRsaSelect";
            this.btnRsaSelect.Size = new System.Drawing.Size(100, 28);
            this.btnRsaSelect.TabIndex = 10;
            this.btnRsaSelect.Text = "&Select...";
            this.btnRsaSelect.UseVisualStyleBackColor = true;
            this.btnRsaSelect.Click += new System.EventHandler(this.btnRsaSelect_Click);
            // 
            // frmCryptoModeSelect
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(753, 167);
            this.Controls.Add(this.btnRsaSelect);
            this.Controls.Add(this.lblRsaName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.cbRSA);
            this.Controls.Add(this.cbPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCryptoModeSelect";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Encryption mode selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip ttMain;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.CheckBox cbRSA;
        private System.Windows.Forms.Label lblRsaName;
        private System.Windows.Forms.Button btnRsaSelect;
    }
}