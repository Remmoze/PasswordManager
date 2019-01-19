using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager {
    public static class Windows {
        public static Form GetForm(this UserControl uc, string name = "New Window", bool show = false) {
            var window = new Form() {
                Text = name,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                FormBorderStyle = FormBorderStyle.FixedDialog
            };
            window.Controls.Add(uc);
            if(show) window.ShowDialog();
            return window;
        }

        public static void ShowAsError(this string ErrorMessage) {
            MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Ask(string question, string title, bool includeCancel = false) {
            return MessageBox.Show(question, title, includeCancel?MessageBoxButtons.RetryCancel:MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
