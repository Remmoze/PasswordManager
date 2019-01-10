using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace PasswordManager {
    public partial class CreatePropmt : UserControl {
        static Random random;
        public CreatePropmt() {
            random = new Random();
            InitializeComponent();
        }

        private void ShowError(string text) {
            MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool IsValid() {
            if (string.IsNullOrWhiteSpace(NameBox.Text)) {
                ShowError("Please enter the Name.");
                return false;
            }
            if(string.IsNullOrWhiteSpace(PasswordBox.Text)) {
                ShowError("Please enter the Password.");
                return false;
            }
            return true;
        }

        public PasswordElement Create(byte[] master) {
            return new PasswordElement(NameBox.Text, PasswordBox.Text, master, IconBox.Image);
        }

        private void Scrolled(object sender, EventArgs e) {
            LengthDisplay.Text = $"Length ({LengthSlider.Value}):";
        }

        private void OptionsCheck(object sender, EventArgs e) {
            var check = (CheckBox)sender;
            var sum = 0;
            if (UpperCaseCheck.Checked) sum++;
            if (LowerCaseCheck.Checked) sum++;
            if (SymbolsCheck.Checked) sum++;
            if (NumbersCheck.Checked) sum++;
            if (sum == 0) check.Checked = true;
        }

        private void ScrambleBTN_Click(object sender, EventArgs e) {
            var upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var lower = "abcdefghijklmnopqrstuvwxyz";
            var numbers = "0123456789";
            var symbols = "*$-+?_&=!%{}/";

            var alphabet = "";
            if (UpperCaseCheck.Checked) alphabet += upper;
            if (LowerCaseCheck.Checked) alphabet += lower;
            if (SymbolsCheck.Checked) alphabet += symbols;
            if (NumbersCheck.Checked) alphabet += numbers;

            var password = "";
            for (int i = 0; i < LengthSlider.Value; i++) {
                password += alphabet[random.Next(0, alphabet.Length)];
            }
            PasswordBox.Text = password;
        }

        private void SelectFile_Click(object sender, EventArgs e) {
            FilePath.Filter = "Png Files|*.png;";
            if (FilePath.ShowDialog() == DialogResult.OK) {
                IconBox.Image = new Bitmap(new Bitmap(FilePath.FileName), new Size(32, 32));
            }
        }
    }
}
