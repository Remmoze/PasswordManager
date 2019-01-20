using System;
using System.Windows.Forms;

namespace PasswordManager {
    public partial class MasterPasswordPrompt : UserControl {

        private bool Exported = false;
        private SaveData Data;
        private SaveFileDialog Save;

        public MasterPasswordPrompt(SaveData data, SaveFileDialog sf) {
            Data = data;
            Save = sf;
            InitializeComponent();
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter)
                Submit.PerformClick();
        }

        private void Export_Click(object sender, EventArgs e) {
            if(Data.IsEmpty) {
                MessageBox.Show("There is nothing to export though..\nYou need to create new file!", "SaveFile is not found.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(Save.ShowDialog() == DialogResult.OK) {
                Data.Save(Save.FileName);
                MessageBox.Show("Backup has been successfully created!", "Backup saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Exported = true;
            }
        }

        private void Import_Click(object sender, EventArgs e) {
            if(!Exported && !Data.IsEmpty) {
                var warning = "Would you wish to export all current passwords?\nWarning: You might lose all of your passwords if you don't export them now.";
                var msg = MessageBox.Show(warning, "Export first?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if(msg == DialogResult.Cancel) return;
                if(msg == DialogResult.Yes) {
                    Export.PerformClick();
                    return;
                }
            }

            OpenBackup.Filter = "Backup files|*.backup";
            if(OpenBackup.ShowDialog() == DialogResult.OK) {
                Data = new SaveData(Save.FileName);
                MessageBox.Show("Backup has been imported!", "Backup loaded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Submit.Text = "Submit";
                Create.Visible = true;
                Export.Visible = true;
            }
        }

        private void Create_Click(object sender, EventArgs e) {
            if(!Exported && !Data.IsEmpty) {
                var warning = "Would you wish to export all current passwords?\nWarning: You might lose all of your passwords if you don't export them now.";
                var msg = MessageBox.Show(warning, "Export first?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if(msg == DialogResult.Cancel)
                    return;
                if(msg == DialogResult.Yes) {
                    Export.PerformClick();
                    return;
                }
            }
            CreateNew();
        }

        public void CreateNew() {
            Submit.Text = "Create";
            Create.Visible = false;
            Export.Visible = false;
            Data.Reset();
        }

        private void ShowPass_Click(object sender, EventArgs e) {
            PasswordBox.PasswordChar = PasswordBox.PasswordChar == '*' ? char.MinValue : '*';
        }
    }
}
