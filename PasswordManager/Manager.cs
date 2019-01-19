using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PasswordManager {
    public partial class PasswordManager : Form {

        private byte[] MasterPassword;
        private List<PasswordElement> Elements = new List<PasswordElement>();
        public SaveData Data;

        public PasswordManager() {

            Data = new SaveData("data.encrypted");
            
            InitializeComponent();
            AskForMaster();
        }

        public void AskForMaster() {
            var prompt = new MasterPasswordPrompt();
            var window = prompt.GetForm("Please enter Master Password.");

            prompt.Submit.Click += (s, e) => {
                if(Data.IsEmpty && string.IsNullOrEmpty(prompt.PasswordBox.Text)) {
                    "Invalid password.".ShowAsError();
                    return;
                }
                MasterPassword = prompt.PasswordBox.Text.GetHash();
                if (!Data.IsEmpty && !Data.TryParse(MasterPassword)) {
                    "Invalid password.".ShowAsError();
                    return;
                }

                window.FormClosing -= Close;
                window.Close();
                if(!Data.IsEmpty) LoadPasswords();
            };

            if (Data.IsEmpty) {
                MessageBox.Show("Master Password hasn't been found!\nYou have to set a new one.", "Master Password is not found.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                window.Text = "Please enter new Master Password";
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
            passwords.Controls.Add(psw);
            Elements.Add(psw);
            psw.Delete.Click += (s, m) => {
                if(Windows.Ask("Are you sure you want to delete this password?", "Delete Password") == DialogResult.Yes) {
                    passwords.Controls.Remove(psw);
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
    }
}
