using System;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordManager {
    public partial class PasswordElement : UserControl {
        
        public byte[] EncryptedPassword { get; set; }
        private string DecryptedPassword { get; set; }
        public string Password { get => DecryptedPassword; }

        public bool HasIcon { get; set; }

        private byte[] masterCopy;

        public PasswordElement(string name, string password, byte[] master, Image iconImage = null) {
            DecryptedPassword = password;
            EncryptedPassword = password.EncryptBytes(master);
            masterCopy = master;
            InitializeComponent();

            HasIcon = iconImage != null;
            icon.Image = iconImage ?? Properties.Resources.defaulticon;
            NameTag.Text = name;
        }

        private void Edit(CreatePropmt cp) {
            var newPe = cp.Create(masterCopy);
            NameTag.Text = newPe.NameTag.Text;
            DecryptedPassword = newPe.Password;
            EncryptedPassword = newPe.EncryptedPassword;
            HasIcon = newPe.HasIcon;
            icon.Image = newPe.icon.Image;
        }

        private void CopyBTN_Click(object sender, EventArgs e) {
            Clipboard.SetText(DecryptedPassword);
        }

        private void EditBTN_Click(object sender, EventArgs e) {
            var edit = CreatePropmt.Edit(this, Edit);
            var window = edit.GetForm("Edit Password Element");
            edit.Add.Click += (s, m) => window.Close();
            window.ShowDialog();
        }
    }
}
