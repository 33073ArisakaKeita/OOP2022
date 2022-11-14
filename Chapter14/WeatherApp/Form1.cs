using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WeatherApp.jma;

//salescalcで出来る

namespace WeatherApp {
    public partial class Form1 : Form {
        AreaCode areas;
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

            areas = new AreaCode("areacode.csv");
        }

        private void btWeatherGet_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            
            var areacode = areas.getAreacode((string)cbtihou2.SelectedItem.ToString());
            var str = "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/" + areacode +".json";
            var dString = wc.DownloadString(str);

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            tbWeatherInfo.ResetText();
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
                case 1:
                    cbtihou2.Items.Add("青森県");
                    cbtihou2.Items.Add("岩手県");
                    cbtihou2.Items.Add("宮城県");
                    cbtihou2.Items.Add("秋田県");
                    cbtihou2.Items.Add("山形県");
                    cbtihou2.Items.Add("福島県");
                    break;
                case 2:
                    cbtihou2.Items.Add("茨城県");
                    cbtihou2.Items.Add("栃木県");
                    cbtihou2.Items.Add("群馬県");
                    cbtihou2.Items.Add("埼玉県");
                    cbtihou2.Items.Add("千葉県");
                    cbtihou2.Items.Add("東京都");
                    cbtihou2.Items.Add("神奈川県");
                    cbtihou2.Items.Add("山梨県");
                    cbtihou2.Items.Add("長野県");
                    break;
                case 3:
                    cbtihou2.Items.Add("岐阜県");
                    cbtihou2.Items.Add("静岡県");
                    cbtihou2.Items.Add("愛知県");
                    cbtihou2.Items.Add("三重県");
                    break;
                case 4:
                    cbtihou2.Items.Add("新潟県");
                    cbtihou2.Items.Add("富山県");
                    cbtihou2.Items.Add("石川県");
                    cbtihou2.Items.Add("福井県");
                    break;
                case 5:
                    cbtihou2.Items.Add("滋賀県");
                    cbtihou2.Items.Add("京都府");
                    cbtihou2.Items.Add("大阪府");
                    cbtihou2.Items.Add("兵庫県");
                    cbtihou2.Items.Add("奈良県");
                    cbtihou2.Items.Add("和歌山県");
                    break;
                case 6:
                    cbtihou2.Items.Add("鳥取県");
                    cbtihou2.Items.Add("島根県");
                    cbtihou2.Items.Add("岡山県");
                    cbtihou2.Items.Add("広島県");
                    break;
                case 7:
                    cbtihou2.Items.Add("徳島県");
                    cbtihou2.Items.Add("香川県");
                    cbtihou2.Items.Add("愛媛県");
                    cbtihou2.Items.Add("高知県");
                    break;
                case 8:
                    cbtihou2.Items.Add("山口県");
                    cbtihou2.Items.Add("福岡県");
                    cbtihou2.Items.Add("佐賀県");
                    cbtihou2.Items.Add("長崎県");
                    cbtihou2.Items.Add("熊本県");
                    cbtihou2.Items.Add("大分県");
                    break;
                case 9:
                    cbtihou2.Items.Add("宮崎県");
                    cbtihou2.Items.Add("奄美地方");
                    cbtihou2.Items.Add("鹿児島県（奄美地方除く）");
                    break;
                case 10:
                    cbtihou2.Items.Add("沖縄本島地方");
                    cbtihou2.Items.Add("大東島地方");
                    cbtihou2.Items.Add("宮古島地方");
                    cbtihou2.Items.Add("八重山地方");
                    break;
                default:
                    break;
            }

        }
    }
}
