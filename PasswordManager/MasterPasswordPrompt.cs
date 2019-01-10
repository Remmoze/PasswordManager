using System;
using System.Windows.Forms;

namespace PasswordManager {
    public partial class MasterPasswordPrompt : UserControl {
        public MasterPasswordPrompt() {
            InitializeComponent();
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter)
                Submit.PerformClick();
        }

        private void Export_Click(object sender, EventArgs e) {
            
        }
    }
}
