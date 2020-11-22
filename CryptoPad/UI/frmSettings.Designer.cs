namespace CryptoPad
{
    partial class frmSettings
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
            this.btnClose = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.tabRSA = new System.Windows.Forms.TabPage();
            this.lvRSA = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEncrypt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDecrypt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabRSA.SuspendLayout();
            this.tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(671, 665);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // OFD
            // 
            this.OFD.DefaultExt = "rsa";
            this.OFD.Filter = "RSA keys|*.rsa|All files|*.*";
            this.OFD.Multiselect = true;
            this.OFD.Title = "Select RSA key(s)";
            // 
            // SFD
            // 
            this.SFD.DefaultExt = "rsa";
            this.SFD.Filter = "RSA keys|*.rsa";
            this.SFD.Title = "Save key";
            // 
            // FBD
            // 
            this.FBD.Description = "Save multiple keys";
            // 
            // tabRSA
            // 
            this.tabRSA.Controls.Add(this.btnNew);
            this.tabRSA.Controls.Add(this.btnDelete);
            this.tabRSA.Controls.Add(this.lvRSA);
            this.tabRSA.Location = new System.Drawing.Point(4, 25);
            this.tabRSA.Margin = new System.Windows.Forms.Padding(4);
            this.tabRSA.Name = "tabRSA";
            this.tabRSA.Padding = new System.Windows.Forms.Padding(4);
            this.tabRSA.Size = new System.Drawing.Size(752, 613);
            this.tabRSA.TabIndex = 1;
            this.tabRSA.Text = "RSA Keys";
            this.tabRSA.UseVisualStyleBackColor = true;
            // 
            // lvRSA
            // 
            this.lvRSA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvRSA.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chSize,
            this.chEncrypt,
            this.chDecrypt});
            this.lvRSA.FullRowSelect = true;
            this.lvRSA.HideSelection = false;
            this.lvRSA.Location = new System.Drawing.Point(8, 7);
            this.lvRSA.Margin = new System.Windows.Forms.Padding(4);
            this.lvRSA.Name = "lvRSA";
            this.lvRSA.Size = new System.Drawing.Size(732, 559);
            this.lvRSA.TabIndex = 0;
            this.lvRSA.UseCompatibleStateImageBehavior = false;
            this.lvRSA.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 100;
            // 
            // chSize
            // 
            this.chSize.Text = "Size";
            this.chSize.Width = 100;
            // 
            // chEncrypt
            // 
            this.chEncrypt.Text = "Can Encrypt";
            this.chEncrypt.Width = 100;
            // 
            // chDecrypt
            // 
            this.chDecrypt.Text = "Can Decrypt";
            this.chDecrypt.Width = 100;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(641, 575);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "&Delete...";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(518, 574);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 28);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "&New...";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabRSA);
            this.tabs.Location = new System.Drawing.Point(19, 13);
            this.tabs.Margin = new System.Windows.Forms.Padding(4);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(760, 642);
            this.tabs.TabIndex = 0;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(792, 708);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.tabRSA.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.TabPage tabRSA;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView lvRSA;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.ColumnHeader chEncrypt;
        private System.Windows.Forms.ColumnHeader chDecrypt;
        private System.Windows.Forms.TabControl tabs;
    }
}