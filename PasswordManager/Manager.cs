using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace PasswordManager {
    public partial class PasswordManager : Form {

        private byte[] MasterPassword;
        private List<PasswordElement> Elements = new List<PasswordElement>();
        public SaveData Data;

        public PasswordManager() {
            Data = new SaveData();
            InitializeComponent();
            SaveBackup.Filter = "Backup files|*.backup";
            AskForMaster();

            Search.GotFocus += (s, e) => {
                if(Search.Text == "Search..")
                    Search.Text = "";
                Search.ForeColor = System.Drawing.Color.Black;
            };

            Search.LostFocus += (s, e) => {
                if(string.IsNullOrWhiteSpace(Search.Text))
                    Search.Text = "Search..";
                Search.ForeColor = System.Drawing.Color.Gray;
            };
        }

        public void AskForMaster() {
            var prompt = new MasterPasswordPrompt(Data, SaveBackup);
            var window = prompt.GetForm("Please enter Master Password.");

            prompt.Submit.Click += (s, e) => {
                if(string.IsNullOrEmpty(prompt.PasswordBox.Text)) {
                    "Password can not be empty".ShowAsError("Invalid password.");
                    prompt.PasswordBox.Focus();
                    return;
                }

                MasterPassword = prompt.PasswordBox.Text.GetHash();
                if (!Data.IsEmpty && !Data.TryParse(MasterPassword)) {
                    "Failed to decrypt the file".ShowAsError("Invalid password.");
                    prompt.PasswordBox.SelectAll();
                    return;
                }

                window.FormClosing -= Close;
                window.Close();
                if(!Data.IsEmpty) LoadPasswords();
                if(!Data.Exists) Data.Save();
            };

            if(!Data.Exists) {
                MessageBox.Show("SaveFile hasn't been found. Either create a new file or import a backup.", "SaveFile is not found.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prompt.CreateNew();
            }

            window.FormClosing += Close;
            window.ShowDialog();
        }

        public void Close(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        public void ReplaceElement(PasswordElement oldpe, PasswordElement newpe) {
            if (!Elements.Contains(oldpe)) return;
            var index = Elements.IndexOf(oldpe);
            Elements.RemoveAt(index);
            Elements.Insert(index, newpe);
        }


        public void InsertElement(PasswordElement psw, bool save = true) {
            PasswordsGrid.Controls.Add(psw);
            Elements.Add(psw);
            psw.Delete.Click += (s, m) => {
                if(Windows.Ask("Are you sure you want to delete this password?", "Delete Password") == DialogResult.Yes) {
                    PasswordsGrid.Controls.Remove(psw);
                    Elements.Remove(psw);
                    Save();
                }
            };
            if (save) Save();
        }

        public void LoadPasswords() {
            foreach (var item in Data.GetElements(MasterPassword)) {
                InsertElement(item, false);
            }
        }

        public void Save() {
            Data.SetElements(Elements.ToArray(), MasterPassword);
            Data.Encode(MasterPassword);
            Data.Save();
        }

        private void Create(object sender, EventArgs e) {
            var prompt = new CreatePropmt();
            var window = prompt.GetForm("Add new Password Element");
            prompt.Add.Click += (s, evt) => {
                if (!prompt.IsValid())
                    return;
                InsertElement(prompt.Create(MasterPassword));
                window.Close();
            };
            window.ShowDialog();
        }

        private void SecretLegs_Click(object sender, EventArgs e) {
            PasswordsGrid.BackgroundImage = PasswordsGrid.BackgroundImage == null ? Properties.Resources.legs : null;
        }

        private void ExportBackup_Click(object sender, EventArgs e) {
            if(SaveBackup.ShowDialog() == DialogResult.OK) {
                Data.Save(SaveBackup.FileName);
                MessageBox.Show("Backup has been successfully created!", "Backup saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Search_TextChanged(object sender, EventArgs e) {
            if(Search.Text == "Search.." || string.IsNullOrWhiteSpace(Search.Text)) {
                foreach(var control in PasswordsGrid.Controls) {
                    ((PasswordElement)control).Visible = true;
                }
            } else {
                foreach(var control in PasswordsGrid.Controls) {
                    var element = (PasswordElement)control;
                    element.Visible = element.NameTag.Text.Contains(Search.Text);
                }
            }
        }
    }
}
