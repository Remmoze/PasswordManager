using System;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordManager {
    public partial class PasswordElement : UserControl {
        
        public byte[] EncryptedPassword { get; set; }
        private string DecryptedPassword { get; set; }
        public string Password { get => DecryptedPassword; }

        public bool HasIcon { get; set; }

        public PasswordElement(string name, string password, byte[] master, Image iconImage = null) {
            DecryptedPassword = password;
            EncryptedPassword = password.EncryptBytes(master);
            InitializeComponent();

            HasIcon = iconImage != null;
            icon.Image = iconImage ?? Properties.Resources.defaulticon;
            NameTag.Text = name;
        }

        private void CopyBTN_Click(object sender, EventArgs e) {
            Clipboard.SetText(DecryptedPassword);
        }

        private void EditBTN_Click(object sender, EventArgs e) {

        }
    }
}
