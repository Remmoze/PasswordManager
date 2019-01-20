using System.Windows.Forms;

namespace PasswordManager {
    public static class Windows {
        public static Form GetForm(this UserControl uc, string name = "New Window", bool show = false) {
            var window = new Form() {
                Text = name,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                Icon = Properties.Resources.icon
            };
            window.Controls.Add(uc);
            if(show) window.ShowDialog();
            return window;
        }

        public static void ShowAsError(this string ErrorMessage, string ErrorTitle = "Error") {
            MessageBox.Show(ErrorMessage, ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Ask(string question, string title, bool includeCancel = false) {
            return MessageBox.Show(question, title, includeCancel?MessageBoxButtons.RetryCancel:MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
