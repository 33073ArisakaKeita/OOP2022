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

namespace WeatherApp {
    public partial class Form1 : Form {
        AreaCode areas;
        string areacode;
        public Form1() {
            InitializeComponent();
            cbtihou1.Items.Add("北海道地方");
            cbtihou1.Items.Add("東北地方");
            cbtihou1.Items.Add("関東甲信地方");
            cbtihou1.Items.Add("東海地方");
            cbtihou1.Items.Add("北陸地方");
            cbtihou1.Items.Add("近畿地方");
            cbtihou1.Items.Add("中国地方（山口県を除く）地方");
            cbtihou1.Items.Add("四国地方");
            cbtihou1.Items.Add("九州北部(山口県を含む)地方");
            cbtihou1.Items.Add("九州南部・奄美地方");
            cbtihou1.Items.Add("沖縄地方");

            areas = new AreaCode("areacode.csv");
        }

        private void btWeatherGet_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            areacode = areas.getAreacode((string)cbtihou2.SelectedItem.ToString());
            getWeather(wc);
        }

        private void getWeather(WebClient wc) {
            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/" + areacode + ".json");
            var weather = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/" + areacode + ".json");


            //jsonデータの取得
            var json = JsonConvert.DeserializeObject<Rootobject2>(dString);
            var json_weather = JsonConvert.DeserializeObject<Class1[]>(weather);
            //↓アイコン変数
            var icon_code = json_weather[0].timeSeries[0].areas[0].weatherCodes[0];

            //↓areasの要素数
            var a = json_weather[0].timeSeries[0].areas.Length;

            //消す
            areas0.Text = areas1.Text = areas2.Text = areas3.Text = null;
            areas0Weather.Text = areas1Weather.Text = areas2Weather.Text = areas3Weather.Text = null;
            areas0Max.Text = areas1Max.Text = areas2Max.Text = areas3Max.Text = null;
            areas0Min.Text = areas1Min.Text = areas2Min.Text = areas3Min.Text = null;
            areas0pbIcon.Image = areas1pbIcon.Image = areas2pbIcon.Image = areas3pbIcon.Image = null;


            areas0.Text = json_weather[0].timeSeries[0].areas[0].area.name;
            areas0Weather.Text = json_weather[0].timeSeries[0].areas[0].weathers[0];

            if (a >= 2) {
                areas1.Text = json_weather[0].timeSeries[0].areas[1].area.name;
                areas1Weather.Text = json_weather[0].timeSeries[0].areas[1].weathers[0];
                areas1Max.Text = json_weather[0].timeSeries[2].areas[1].temps[0];
                areas1Min.Text = "-";
                icon_code = json_weather[0].timeSeries[0].areas[1].weatherCodes[0];
                areas1pbIcon.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + icon_code + ".png";
                areas1pbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (a >= 3) {
                areas2.Text = json_weather[0].timeSeries[0].areas[2].area.name;
                areas2Weather.Text = json_weather[0].timeSeries[0].areas[2].weathers[0];
                areas2Max.Text = json_weather[0].timeSeries[2].areas[2].temps[0];
                areas2Min.Text = "-";
                icon_code = json_weather[0].timeSeries[0].areas[2].weatherCodes[0];
                areas2pbIcon.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + icon_code + ".png";
                areas2pbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (a >= 4) {
                areas3.Text = json_weather[0].timeSeries[0].areas[3].area.name;
                areas3Weather.Text = json_weather[0].timeSeries[0].areas[3].weathers[0];
                areas3Max.Text = json_weather[0].timeSeries[2].areas[3].temps[0];
                areas3Min.Text = "-";
                icon_code = json_weather[0].timeSeries[0].areas[3].weatherCodes[0];
                areas3pbIcon.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + icon_code + ".png";
                areas3pbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            //日付
            labelDate.Text = json_weather[0].reportDatetime.ToString("MM/dd");
            labelarea.Text = cbtihou2.Text;
            tommorow.Text = json_weather[1].timeSeries[1].timeDefines[0].ToString("MM/dd");
            tommorow2.Text = json_weather[1].timeSeries[1].timeDefines[1].ToString("MM/dd");
            tommorow3.Text = json_weather[1].timeSeries[1].timeDefines[2].ToString("MM/dd");
            tommorow4.Text = json_weather[1].timeSeries[1].timeDefines[3].ToString("MM/dd");
            tommorow5.Text = json_weather[1].timeSeries[1].timeDefines[4].ToString("MM/dd");
            tommorow6.Text = json_weather[1].timeSeries[1].timeDefines[5].ToString("MM/dd");

            areas0Max.Text = json_weather[0].timeSeries[2].areas[0].temps[0];
            tommorowMax.Text = json_weather[0].timeSeries[2].areas[0].temps[3];
            tommorow2Max.Text = json_weather[1].timeSeries[1].areas[0].tempsMax[1];
            tommorow3Max.Text = json_weather[1].timeSeries[1].areas[0].tempsMax[2];
            tommorow4Max.Text = json_weather[1].timeSeries[1].areas[0].tempsMax[3];
            tommorow5Max.Text = json_weather[1].timeSeries[1].areas[0].tempsMax[4];
            tommorow6Max.Text = json_weather[1].timeSeries[1].areas[0].tempsMax[5];

            //最低気温はないからハイフンとかいれる
            areas0Min.Text = "-";
            tommorowMin.Text = json_weather[0].timeSeries[2].areas[0].temps[2];
            tommorow2Min.Text = json_weather[1].timeSeries[1].areas[0].tempsMin[1];
            tommorow3Min.Text = json_weather[1].timeSeries[1].areas[0].tempsMin[2];
            tommorow4Min.Text = json_weather[1].timeSeries[1].areas[0].tempsMin[3];
            tommorow5Min.Text = json_weather[1].timeSeries[1].areas[0].tempsMin[4];
            tommorow6Min.Text = json_weather[1].timeSeries[1].areas[0].tempsMin[5];

            //アイコン
            icon_code = json_weather[0].timeSeries[0].areas[0].weatherCodes[0];
            areas0pbIcon.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + icon_code + ".png";
            areas0pbIcon.SizeMode = PictureBoxSizeMode.StretchImage;

            icon_code = json_weather[0].timeSeries[0].areas[0].weatherCodes[1];
            pbIcon2.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + icon_code + ".png";
            pbIcon2.SizeMode = PictureBoxSizeMode.StretchImage;

            icon_code = json_weather[1].timeSeries[0].areas[0].weatherCodes[1];
            pbIcon3.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + icon_code + ".png";
            pbIcon3.SizeMode = PictureBoxSizeMode.StretchImage;

            icon_code = json_weather[1].timeSeries[0].areas[0].weatherCodes[2];
            pbIcon4.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + icon_code + ".png";
            pbIcon4.SizeMode = PictureBoxSizeMode.StretchImage;

            icon_code = json_weather[1].timeSeries[0].areas[0].weatherCodes[3];
            pbIcon5.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + icon_code + ".png";
            pbIcon5.SizeMode = PictureBoxSizeMode.StretchImage;

            icon_code = json_weather[1].timeSeries[0].areas[0].weatherCodes[4];
            pbIcon6.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + icon_code + ".png";
            pbIcon6.SizeMode = PictureBoxSizeMode.StretchImage;

            icon_code = json_weather[1].timeSeries[0].areas[0].weatherCodes[5];
            pbIcon7.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/" + icon_code + ".png";
            pbIcon7.SizeMode = PictureBoxSizeMode.StretchImage;


            //概況
            tbWeatherInfo.ResetText();
            tbWeatherInfo.Text += json.text;

            get_weathermap(wc);

        }

        private void cbtihou1_SelectedIndexChanged(object sender, EventArgs e) {
            var index = cbtihou1.SelectedIndex;
            if (index == -1)
                return;
            cbtihou2.Items.Clear();
            cbtihou2.Text = null;
            switch (index) {
                case 0:
                    cbtihou2.Items.Add("宗谷地方");
                    cbtihou2.Items.Add("上川・留萌地方");
                    cbtihou2.Items.Add("網走・北見・紋別地方");
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
                    cbtihou2.Items.Add("鹿児島県");
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
            btWeatherGet_enabled_check();
        }

        private void Form1_Load(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            areacode = "130000";
            cbtihou1.SelectedIndex = 2;
            cbtihou2.SelectedIndex = 5;
            labelarea.Text = cbtihou2.SelectedIndex.ToString();
            getWeather(wc);
            btWeatherGet_enabled_check();
        }

        private void btWeatherGet_enabled_check() {
            if (cbtihou2.SelectedIndex == -1)
                btWeatherGet.Enabled = false;
            if (cbtihou2.SelectedIndex != -1)
                btWeatherGet.Enabled = true;
        }

        private void cbtihou2_SelectedIndexChanged(object sender, EventArgs e) {
            btWeatherGet_enabled_check();
        }

        private void get_weathermap(WebClient wc) {
            var wearher_map = wc.DownloadString("https://www.jma.go.jp/bosai/weather_map/data/list.json");
            var json_wearher_map = JsonConvert.DeserializeObject<Rootobject3>(wearher_map);
            //ピクチャーボックス

            pbweather.ImageLocation = "https://www.jma.go.jp/bosai/weather_map/data/png/" + json_wearher_map.near.ft24[0];


            pbweather.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }

}
