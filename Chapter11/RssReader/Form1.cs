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
            //wbBrowser.Navigate(link[lbRssTitle.SelectedIndex]);
            //wvBrowser.Navigate(link[lbRssTitle.SelectedIndex]);
            wvBrowser.Source = new Uri(link[lbRssTitle.SelectedIndex]);
            RssButtonCheck();

        }

        public void ListClear() {
            lbRssTitle.Items.Clear();
            link.Clear();
        }

        private void btRssForward_Click(object sender, EventArgs e) {
            wvBrowser.GoForward();
        }

        private void btRssBack_Click(object sender, EventArgs e) {
            wvBrowser.GoBack();
        }
        private void RssButtonCheck() {
            btRssBack.Enabled = wvBrowser.CanGoBack;
            btRssForward.Enabled = wvBrowser.CanGoForward;
        }

        private void Form1_Load(object sender, EventArgs e) {
            RssButtonCheck();
        }

        private void wvBrowser_NavigationCompleted(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e) {
            RssButtonCheck();
        }
    }
}