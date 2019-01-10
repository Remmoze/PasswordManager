using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PasswordManager {
    public partial class PasswordManager : Form {

        private byte[] MasterPassword;
        private List<PasswordElement> Elements = new List<PasswordElement>();
        public SaveData Data;

        public PasswordManager() {

            Data = new SaveData("data");
            
            InitializeComponent();
            AskForMaster();
        }

        public void AskForMaster() {
            var window = new Form() {
                Text = "Please enter Master Password.",
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                FormBorderStyle = FormBorderStyle.FixedSingle
            };
            var prompt = new MasterPasswordPrompt();
            prompt.Submit.Click += (s, e) => {
                if(Data.IsEmpty && string.IsNullOrEmpty(prompt.PasswordBox.Text)) {
                    ShowError();
                    return;
                }
                MasterPassword = prompt.PasswordBox.Text.GetHash();
                if (!Data.IsEmpty && !Data.TryParse(MasterPassword)) {
                    ShowError();
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
            window.Controls.Add(prompt);
            window.ShowDialog();
        }

        public void Close(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        public void ShowError() {
            MessageBox.Show("Invalid password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void InsertElement(PasswordElement psw, bool save = true) {
            passwords.Controls.Add(psw);
            Elements.Add(psw);
            psw.Delete.Click += (s, m) => {
                passwords.Controls.Remove(psw);
                Elements.Remove(psw);
                Save();
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
            var window = new Form() {
                Text = "Add new Password Element",
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                FormBorderStyle = FormBorderStyle.FixedDialog
            };
            var prompt = new CreatePropmt();
            prompt.Add.Click += (s, evt) => {
                if (!prompt.IsValid())
                    return;
                InsertElement(prompt.Create(MasterPassword));
                window.Close();
            };
            window.Controls.Add(prompt);
            window.ShowDialog();
        }
    }
}
