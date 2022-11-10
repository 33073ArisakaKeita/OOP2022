using Newtonsoft.Json;
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
using static WeatherApp.jma;

//salescalcで出来る

namespace WeatherApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            cbtihou1.Items.Add("北海道地方");
            cbtihou1.Items.Add("東北地方");
            cbtihou1.Items.Add("関東甲信地方");
            cbtihou1.Items.Add("東海地方");
            cbtihou1.Items.Add("北陸地方");
            cbtihou1.Items.Add("近畿地方");
            cbtihou1.Items.Add("中国地方（山形県を除く）地方");
            cbtihou1.Items.Add("四国地方");
            cbtihou1.Items.Add("九州北部(山形県を含む)地方");
            cbtihou1.Items.Add("九州南部・奄美地方");
            cbtihou1.Items.Add("沖縄地方");

            var reagionDict = new Dictionary<string, int>() {

            }
        }

        private void btWeatherGet_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/130000.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            tbWeatherInfo.Text += json.text;

        }

        private void cbtihou1_SelectedIndexChanged(object sender, EventArgs e) {
            var index = cbtihou1.SelectedIndex;
            if (index == -1)
                return;
            cbtihou2.Items.Clear();
            switch (index) {
                case 0:
                    cbtihou2.Items.Add("宗谷地方");
                    cbtihou2.Items.Add("上川・留萌地方");
                    cbtihou2.Items.Add("網走・北見・紋別地方");
                    cbtihou2.Items.Add("十勝地方");
                    cbtihou2.Items.Add("釧路・根室地方");
                    cbtihou2.Items.Add("胆振・日高地方");
                    cbtihou2.Items.Add("石狩・空知・後志地方");
                    cbtihou2.Items.Add("渡島・檜山地方");
                    break;
                case 2:
                    cbtihou2.Items.Add("地方");
                    break;
                case 3:
                    cbtihou2.Items.Add("地方");
                    break;
                case 4:
                    cbtihou2.Items.Add("地方");
                    break;
                case 5:
                    cbtihou2.Items.Add("地方");
                    break;
                case 6:
                    cbtihou2.Items.Add("地方");
                    break;
                case 7:
                    cbtihou2.Items.Add("地方");
                    break;
                case 8:
                    cbtihou2.Items.Add("地方");
                    break;
                case 9:
                    cbtihou2.Items.Add("地方");
                    break;
                case 10:
                    cbtihou2.Items.Add("地方");
                    break;
                case 1:
                    cbtihou2.Items.Add("地方");
                    break;
                default:
                    break;
            }

        }
    }
}
