using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }
        List<string> link = new List<string>();

        private void btRssGet_Click(object sender, EventArgs e) {
            ListClear();
            using (var wc = new WebClient()) {
                var stream = wc.OpenRead(cbRssUrl.Text);
                var xdoc = XDocument.Load(stream);
                var xTitle = xdoc.Root.Descendants("item").Select(x => (string)x.Element("title"));
                var xLink = xdoc.Root.Descendants("item").Select(x => (string)x.Element("link"));

                foreach (var data in xTitle) {
                    lbRssTitle.Items.Add(data);
                }
                foreach (var data in xLink) {
                    link.Add(data);
                }
            }
        }
        private void lbRssTitle_Click(object sender, EventArgs e) {
            var index = lbRssTitle.SelectedIndex;
            cbRssUrl.Text = link[index];
            this.wbBrowser.Navigate(link[index]);
        }
        public void ListClear() {
            lbRssTitle.Items.Clear();
            link.Clear();
        }
    }
}