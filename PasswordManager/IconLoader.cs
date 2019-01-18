using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace PasswordManager {
    public partial class IconLoader : UserControl {

        private Action<Image> callback;
        public IconLoader(Action<Image> cb) {
            callback = cb;
            InitializeComponent();
        }

        private string GetImageLink() {
            var link = LinkBox.Text;
            if (string.IsNullOrWhiteSpace(link))
                return "";
            return "https://www.google.com/s2/favicons?domain=" + link;
        }

        private void ImageLink_Click(object sender, EventArgs e) {
            var imageLink = GetImageLink();
            if(imageLink== "") {
                "Invalid URI".ShowAsError();
                return;
            }

            using(WebClient client = new WebClient()) {
                Stream stream = client.OpenRead(imageLink);
                Bitmap bitmap = new Bitmap(stream);
                if(bitmap == null) {
                    "Invalid File".ShowAsError();
                    return;
                }
                SetIcon(bitmap);
                stream.Flush();
                stream.Close();
                client.Dispose();
            }
        }

        private void SiteUrl_Click(object sender, EventArgs e) {
            var link = LinkBox.Text;
            if(string.IsNullOrWhiteSpace(link)) {
                "Invalid URL".ShowAsError();
                return;
            }

            // this is terrible
            // but works for now lol
            try {
                if(!link.StartsWith("http"))
                    link = "https://" + link;
                Preview.Load(link);
            } catch(Exception) {
                try {
                    link += "/favicon.ico";
                    Preview.Load(link);
                } catch (Exception) {
                    "Failed to connect.".ShowAsError();
                    return;
                }
            }
        }

        private void SetIcon(Image icon) {
            if(ResizeCheck.Checked) Preview.Image = new Bitmap(icon, new Size(32, 32));
            else Preview.Image = icon;
        }

        private void Submit_Click(object sender, EventArgs e) {
            callback(Preview.Image);
        }
    }
}
