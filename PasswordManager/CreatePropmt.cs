using System;
using System.Windows.Forms;
using System.Drawing;

namespace PasswordManager {
    public partial class CreatePropmt : UserControl {
        static Random random;
        public CreatePropmt() {
            random = new Random();
            InitializeComponent();
            ScrambleBTN.PerformClick();
        }

        public bool IsValid() {
            if (string.IsNullOrWhiteSpace(NameBox.Text)) {
                "Please enter the Name.".ShowAsError();
                return false;
            }
            if(string.IsNullOrWhiteSpace(PasswordBox.Text)) {
                "Please enter the Password.".ShowAsError();
                return false;
            }
            return true;
        }

        public static CreatePropmt Edit(PasswordElement psw, Action<CreatePropmt> callback) {
            var pro = new CreatePropmt();
            pro.NameBox.Text = psw.NameTag.Text;
            pro.PasswordBox.Text = psw.Password;
            pro.IconBox.Image = psw.HasIcon ? psw.icon.Image : Properties.Resources.defaulticon;
            pro.Add.Text = "Edit password";
            pro.Add.Click += (s, m) => callback(pro);
            return pro;
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
                SetIcon(new Bitmap(new Bitmap(FilePath.FileName), new Size(32, 32)));
            }
        }

        private void LoadURL_Click(object sender, EventArgs e) {
            var loader = new IconLoader(SetIcon);
            var form = loader.GetForm("Select the icon");
            loader.Submit.Click += (s, ev) => form.Close();
            form.ShowDialog();
        }

        private void SetIcon(Image icon) {
            IconBox.Image = icon;
        }

        private void Reset_Click(object sender, EventArgs e) {
            SetIcon(Properties.Resources.defaulticon);
        }
    }
}
