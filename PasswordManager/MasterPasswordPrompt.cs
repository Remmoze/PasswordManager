using System;
using System.Windows.Forms;

namespace PasswordManager {
    public partial class MasterPasswordPrompt : UserControl {

        private bool Exported = false;
        public MasterPasswordPrompt() {
            InitializeComponent();
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter)
                Submit.PerformClick();
        }

        private void Export_Click(object sender, EventArgs e) {
            Exported = true;
        }

        private void Import_Click(object sender, EventArgs e) {
            if(!Exported) {
                var warning = "Would you wish to export all current passwords?\nWarning: You might lose all of your passwords if you don't export them now.";
                var msg = MessageBox.Show(warning, "Export first?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if(msg == DialogResult.Cancel) return;
                if(msg == DialogResult.Yes) {
                    Export.PerformClick();
                    return;
                }
            }

            MessageBox.Show("imported", "not really");
        }
    }
}
