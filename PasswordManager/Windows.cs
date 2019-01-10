using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager {
    public static class Windows {
        public static Form GetForm(this UserControl uc, string name = "New Window") {
            var window = new Form() {
                Text = name,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                FormBorderStyle = FormBorderStyle.FixedDialog
            };
            window.Controls.Add(uc);
            return window;
        }
    }
}
