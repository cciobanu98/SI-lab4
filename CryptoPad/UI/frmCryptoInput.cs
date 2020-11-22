using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CryptoPad
{
    public partial class frmCryptoInput : Form
    {
        public string Keyfile { get; private set; }

        public string Password { get; private set; }

        public RSAKey RsaKey { get; private set; }

        public bool ValidInput
        {
            get
            {
                return
                    !string.IsNullOrEmpty(Keyfile) ||
                    !string.IsNullOrEmpty(Password)
                    || RsaKey != null;
            }
        }

        private IEnumerable<RSAKey> RsaKeys;

        public frmCryptoInput(CryptoMode Modes, IEnumerable<RSAKey> Keys)
        {
            InitializeComponent();

            RsaKeys = Keys == null ? null : Keys.ToArray();

            if (!Modes.HasFlag(CryptoMode.Password))
            {
                cbPassword.Enabled = tbPassword.Enabled = false;
            }
            if (!Modes.HasFlag(CryptoMode.RSA) || Keys == null)
            {
                cbRSA.Enabled = lblRSAName.Enabled = btnRSA.Enabled = false;
            }
        }


        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            cbPassword.Checked = !string.IsNullOrEmpty(tbPassword.Text);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPassword.Text) && cbPassword.Checked)
            {
                Password = tbPassword.Text;
            }
        }

        private void btnRSA_Click(object sender, EventArgs e)
        {
            using (var F = new frmRSASelect(RsaKeys, false, RsaKey))
            {
                if (F.ShowDialog() == DialogResult.OK)
                {
                    cbRSA.Checked = true;
                    RsaKey = F.SelectedKey;
                    lblRSAName.Text = RsaKey.Name;
                }
            }
        }
    }
}
