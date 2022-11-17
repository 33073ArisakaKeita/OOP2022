
namespace WeatherApp {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btWeatherGet = new System.Windows.Forms.Button();
            this.cbtihou1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbtihou2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.todaysWether = new System.Windows.Forms.TextBox();
            this.tomorrowsWether = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbweather = new System.Windows.Forms.PictureBox();
            this.dafWeather = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbWeatherInfo = new System.Windows.Forms.TextBox();
            this.概況 = new System.Windows.Forms.Label();
            this.tommorow3 = new System.Windows.Forms.Label();
            this.tommorow4 = new System.Windows.Forms.Label();
            this.tommorow5 = new System.Windows.Forms.Label();
            this.tommorow6 = new System.Windows.Forms.Label();
            this.tommorow3Max = new System.Windows.Forms.Label();
            this.tommorow4Max = new System.Windows.Forms.Label();
            this.tommorow5Max = new System.Windows.Forms.Label();
            this.tommorow6Max = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tommorow6Min = new System.Windows.Forms.Label();
            this.tommorow5Min = new System.Windows.Forms.Label();
            this.tommorow4Min = new System.Windows.Forms.Label();
            this.tommorow3Min = new System.Windows.Forms.Label();
            this.pbIcon1 = new System.Windows.Forms.PictureBox();
            this.pbIcon3 = new System.Windows.Forms.PictureBox();
            this.pbIcon4 = new System.Windows.Forms.PictureBox();
            this.pbIcon5 = new System.Windows.Forms.PictureBox();
            this.pbIcon6 = new System.Windows.Forms.PictureBox();
            this.pbIcon7 = new System.Windows.Forms.PictureBox();
            this.pbIcon2 = new System.Windows.Forms.PictureBox();
            this.tommorowMax = new System.Windows.Forms.Label();
            this.tommorow2Max = new System.Windows.Forms.Label();
            this.todayMax = new System.Windows.Forms.Label();
            this.tommorowMin = new System.Windows.Forms.Label();
            this.tommorow2Min = new System.Windows.Forms.Label();
            this.todayMin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbweather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon2)).BeginInit();
            this.SuspendLayout();
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Location = new System.Drawing.Point(337, 160);
            this.btWeatherGet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(112, 26);
            this.btWeatherGet.TabIndex = 1;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // cbtihou1
            // 
            this.cbtihou1.FormattingEnabled = true;
            this.cbtihou1.Location = new System.Drawing.Point(21, 113);
            this.cbtihou1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbtihou1.Name = "cbtihou1";
            this.cbtihou1.Size = new System.Drawing.Size(290, 24);
            this.cbtihou1.TabIndex = 2;
            this.cbtihou1.SelectedIndexChanged += new System.EventHandler(this.cbtihou1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(15, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "地方";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 4;
            // 
            // cbtihou2
            // 
            this.cbtihou2.FormattingEnabled = true;
            this.cbtihou2.Location = new System.Drawing.Point(21, 160);
            this.cbtihou2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbtihou2.Name = "cbtihou2";
            this.cbtihou2.Size = new System.Drawing.Size(290, 24);
            this.cbtihou2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(18, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "今日の天気";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(18, 281);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "明日の天気";
            // 
            // todaysWether
            // 
            this.todaysWether.Location = new System.Drawing.Point(18, 228);
            this.todaysWether.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.todaysWether.Name = "todaysWether";
            this.todaysWether.Size = new System.Drawing.Size(241, 23);
            this.todaysWether.TabIndex = 8;
            // 
            // tomorrowsWether
            // 
            this.tomorrowsWether.Location = new System.Drawing.Point(21, 317);
            this.tomorrowsWether.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tomorrowsWether.Name = "tomorrowsWether";
            this.tomorrowsWether.Size = new System.Drawing.Size(241, 23);
            this.tomorrowsWether.TabIndex = 8;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(97, 9);
            this.tbDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(199, 23);
            this.tbDate.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "報告日時：";
            // 
            // pbweather
            // 
            this.pbweather.Location = new System.Drawing.Point(474, 67);
            this.pbweather.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbweather.Name = "pbweather";
            this.pbweather.Size = new System.Drawing.Size(285, 208);
            this.pbweather.TabIndex = 12;
            this.pbweather.TabStop = false;
            // 
            // dafWeather
            // 
            this.dafWeather.Location = new System.Drawing.Point(303, 317);
            this.dafWeather.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dafWeather.Name = "dafWeather";
            this.dafWeather.Size = new System.Drawing.Size(241, 23);
            this.dafWeather.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 281);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "明後日の天気";
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.Location = new System.Drawing.Point(21, 376);
            this.tbWeatherInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.Size = new System.Drawing.Size(556, 207);
            this.tbWeatherInfo.TabIndex = 14;
            // 
            // 概況
            // 
            this.概況.AutoSize = true;
            this.概況.Location = new System.Drawing.Point(18, 356);
            this.概況.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.概況.Name = "概況";
            this.概況.Size = new System.Drawing.Size(40, 16);
            this.概況.TabIndex = 7;
            this.概況.Text = "概況";
            // 
            // tommorow3
            // 
            this.tommorow3.AutoSize = true;
            this.tommorow3.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tommorow3.Location = new System.Drawing.Point(584, 386);
            this.tommorow3.Name = "tommorow3";
            this.tommorow3.Size = new System.Drawing.Size(23, 21);
            this.tommorow3.TabIndex = 15;
            this.tommorow3.Text = "/";
            // 
            // tommorow4
            // 
            this.tommorow4.AutoSize = true;
            this.tommorow4.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tommorow4.Location = new System.Drawing.Point(584, 436);
            this.tommorow4.Name = "tommorow4";
            this.tommorow4.Size = new System.Drawing.Size(23, 21);
            this.tommorow4.TabIndex = 15;
            this.tommorow4.Text = "/";
            // 
            // tommorow5
            // 
            this.tommorow5.AutoSize = true;
            this.tommorow5.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tommorow5.Location = new System.Drawing.Point(584, 491);
            this.tommorow5.Name = "tommorow5";
            this.tommorow5.Size = new System.Drawing.Size(23, 21);
            this.tommorow5.TabIndex = 15;
            this.tommorow5.Text = "/";
            // 
            // tommorow6
            // 
            this.tommorow6.AutoSize = true;
            this.tommorow6.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tommorow6.Location = new System.Drawing.Point(584, 546);
            this.tommorow6.Name = "tommorow6";
            this.tommorow6.Size = new System.Drawing.Size(23, 21);
            this.tommorow6.TabIndex = 15;
            this.tommorow6.Text = "/";
            // 
            // tommorow3Max
            // 
            this.tommorow3Max.AutoSize = true;
            this.tommorow3Max.ForeColor = System.Drawing.Color.Red;
            this.tommorow3Max.Location = new System.Drawing.Point(691, 390);
            this.tommorow3Max.Name = "tommorow3Max";
            this.tommorow3Max.Size = new System.Drawing.Size(0, 16);
            this.tommorow3Max.TabIndex = 15;
            // 
            // tommorow4Max
            // 
            this.tommorow4Max.AutoSize = true;
            this.tommorow4Max.ForeColor = System.Drawing.Color.Red;
            this.tommorow4Max.Location = new System.Drawing.Point(691, 441);
            this.tommorow4Max.Name = "tommorow4Max";
            this.tommorow4Max.Size = new System.Drawing.Size(0, 16);
            this.tommorow4Max.TabIndex = 15;
            // 
            // tommorow5Max
            // 
            this.tommorow5Max.AutoSize = true;
            this.tommorow5Max.ForeColor = System.Drawing.Color.Red;
            this.tommorow5Max.Location = new System.Drawing.Point(691, 495);
            this.tommorow5Max.Name = "tommorow5Max";
            this.tommorow5Max.Size = new System.Drawing.Size(0, 16);
            this.tommorow5Max.TabIndex = 15;
            // 
            // tommorow6Max
            // 
            this.tommorow6Max.AutoSize = true;
            this.tommorow6Max.ForeColor = System.Drawing.Color.Red;
            this.tommorow6Max.Location = new System.Drawing.Point(691, 550);
            this.tommorow6Max.Name = "tommorow6Max";
            this.tommorow6Max.Size = new System.Drawing.Size(0, 16);
            this.tommorow6Max.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(691, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "高";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(735, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "低";
            // 
            // tommorow6Min
            // 
            this.tommorow6Min.AutoSize = true;
            this.tommorow6Min.ForeColor = System.Drawing.Color.Blue;
            this.tommorow6Min.Location = new System.Drawing.Point(735, 550);
            this.tommorow6Min.Name = "tommorow6Min";
            this.tommorow6Min.Size = new System.Drawing.Size(0, 16);
            this.tommorow6Min.TabIndex = 15;
            // 
            // tommorow5Min
            // 
            this.tommorow5Min.AutoSize = true;
            this.tommorow5Min.ForeColor = System.Drawing.Color.Blue;
            this.tommorow5Min.Location = new System.Drawing.Point(735, 495);
            this.tommorow5Min.Name = "tommorow5Min";
            this.tommorow5Min.Size = new System.Drawing.Size(0, 16);
            this.tommorow5Min.TabIndex = 15;
            // 
            // tommorow4Min
            // 
            this.tommorow4Min.AutoSize = true;
            this.tommorow4Min.ForeColor = System.Drawing.Color.Blue;
            this.tommorow4Min.Location = new System.Drawing.Point(735, 440);
            this.tommorow4Min.Name = "tommorow4Min";
            this.tommorow4Min.Size = new System.Drawing.Size(0, 16);
            this.tommorow4Min.TabIndex = 15;
            // 
            // tommorow3Min
            // 
            this.tommorow3Min.AutoSize = true;
            this.tommorow3Min.ForeColor = System.Drawing.Color.Blue;
            this.tommorow3Min.Location = new System.Drawing.Point(735, 390);
            this.tommorow3Min.Name = "tommorow3Min";
            this.tommorow3Min.Size = new System.Drawing.Size(0, 16);
            this.tommorow3Min.TabIndex = 15;
            // 
            // pbIcon1
            // 
            this.pbIcon1.Location = new System.Drawing.Point(113, 191);
            this.pbIcon1.Name = "pbIcon1";
            this.pbIcon1.Size = new System.Drawing.Size(40, 33);
            this.pbIcon1.TabIndex = 16;
            this.pbIcon1.TabStop = false;
            // 
            // pbIcon3
            // 
            this.pbIcon3.Location = new System.Drawing.Point(411, 281);
            this.pbIcon3.Name = "pbIcon3";
            this.pbIcon3.Size = new System.Drawing.Size(31, 27);
            this.pbIcon3.TabIndex = 16;
            this.pbIcon3.TabStop = false;
            // 
            // pbIcon4
            // 
            this.pbIcon4.Location = new System.Drawing.Point(660, 380);
            this.pbIcon4.Name = "pbIcon4";
            this.pbIcon4.Size = new System.Drawing.Size(31, 27);
            this.pbIcon4.TabIndex = 16;
            this.pbIcon4.TabStop = false;
            // 
            // pbIcon5
            // 
            this.pbIcon5.Location = new System.Drawing.Point(660, 429);
            this.pbIcon5.Name = "pbIcon5";
            this.pbIcon5.Size = new System.Drawing.Size(31, 27);
            this.pbIcon5.TabIndex = 16;
            this.pbIcon5.TabStop = false;
            // 
            // pbIcon6
            // 
            this.pbIcon6.Location = new System.Drawing.Point(660, 485);
            this.pbIcon6.Name = "pbIcon6";
            this.pbIcon6.Size = new System.Drawing.Size(31, 27);
            this.pbIcon6.TabIndex = 16;
            this.pbIcon6.TabStop = false;
            // 
            // pbIcon7
            // 
            this.pbIcon7.Location = new System.Drawing.Point(660, 540);
            this.pbIcon7.Name = "pbIcon7";
            this.pbIcon7.Size = new System.Drawing.Size(31, 27);
            this.pbIcon7.TabIndex = 16;
            this.pbIcon7.TabStop = false;
            // 
            // pbIcon2
            // 
            this.pbIcon2.Location = new System.Drawing.Point(113, 281);
            this.pbIcon2.Name = "pbIcon2";
            this.pbIcon2.Size = new System.Drawing.Size(31, 27);
            this.pbIcon2.TabIndex = 16;
            this.pbIcon2.TabStop = false;
            // 
            // tommorowMax
            // 
            this.tommorowMax.AutoSize = true;
            this.tommorowMax.ForeColor = System.Drawing.Color.Red;
            this.tommorowMax.Location = new System.Drawing.Point(171, 292);
            this.tommorowMax.Name = "tommorowMax";
            this.tommorowMax.Size = new System.Drawing.Size(0, 16);
            this.tommorowMax.TabIndex = 17;
            // 
            // tommorow2Max
            // 
            this.tommorow2Max.AutoSize = true;
            this.tommorow2Max.ForeColor = System.Drawing.Color.Red;
            this.tommorow2Max.Location = new System.Drawing.Point(477, 292);
            this.tommorow2Max.Name = "tommorow2Max";
            this.tommorow2Max.Size = new System.Drawing.Size(0, 16);
            this.tommorow2Max.TabIndex = 17;
            // 
            // todayMax
            // 
            this.todayMax.AutoSize = true;
            this.todayMax.Location = new System.Drawing.Point(167, 208);
            this.todayMax.Name = "todayMax";
            this.todayMax.Size = new System.Drawing.Size(62, 16);
            this.todayMax.TabIndex = 18;
            this.todayMax.Text = "label10";
            // 
            // tommorowMin
            // 
            this.tommorowMin.AutoSize = true;
            this.tommorowMin.ForeColor = System.Drawing.Color.Blue;
            this.tommorowMin.Location = new System.Drawing.Point(229, 292);
            this.tommorowMin.Name = "tommorowMin";
            this.tommorowMin.Size = new System.Drawing.Size(0, 16);
            this.tommorowMin.TabIndex = 17;
            // 
            // tommorow2Min
            // 
            this.tommorow2Min.AutoSize = true;
            this.tommorow2Min.ForeColor = System.Drawing.Color.Blue;
            this.tommorow2Min.Location = new System.Drawing.Point(525, 292);
            this.tommorow2Min.Name = "tommorow2Min";
            this.tommorow2Min.Size = new System.Drawing.Size(0, 16);
            this.tommorow2Min.TabIndex = 17;
            // 
            // todayMin
            // 
            this.todayMin.AutoSize = true;
            this.todayMin.Location = new System.Drawing.Point(234, 208);
            this.todayMin.Name = "todayMin";
            this.todayMin.Size = new System.Drawing.Size(62, 16);
            this.todayMin.TabIndex = 18;
            this.todayMin.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 600);
            this.Controls.Add(this.todayMin);
            this.Controls.Add(this.todayMax);
            this.Controls.Add(this.tommorow2Min);
            this.Controls.Add(this.tommorow2Max);
            this.Controls.Add(this.tommorowMin);
            this.Controls.Add(this.tommorowMax);
            this.Controls.Add(this.pbIcon7);
            this.Controls.Add(this.pbIcon6);
            this.Controls.Add(this.pbIcon5);
            this.Controls.Add(this.pbIcon4);
            this.Controls.Add(this.pbIcon3);
            this.Controls.Add(this.pbIcon2);
            this.Controls.Add(this.pbIcon1);
            this.Controls.Add(this.tommorow3Min);
            this.Controls.Add(this.tommorow4Min);
            this.Controls.Add(this.tommorow5Min);
            this.Controls.Add(this.tommorow6Min);
            this.Controls.Add(this.tommorow6Max);
            this.Controls.Add(this.tommorow6);
            this.Controls.Add(this.tommorow5Max);
            this.Controls.Add(this.tommorow5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tommorow4Max);
            this.Controls.Add(this.tommorow4);
            this.Controls.Add(this.tommorow3Max);
            this.Controls.Add(this.tommorow3);
            this.Controls.Add(this.tbWeatherInfo);
            this.Controls.Add(this.dafWeather);
            this.Controls.Add(this.pbweather);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tomorrowsWether);
            this.Controls.Add(this.todaysWether);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.概況);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbtihou2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbtihou1);
            this.Controls.Add(this.btWeatherGet);
            this.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbweather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.ComboBox cbtihou1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbtihou2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox todaysWether;
        private System.Windows.Forms.TextBox tomorrowsWether;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbweather;
        private System.Windows.Forms.TextBox dafWeather;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbWeatherInfo;
        private System.Windows.Forms.Label 概況;
        private System.Windows.Forms.Label tommorow3;
        private System.Windows.Forms.Label tommorow4;
        private System.Windows.Forms.Label tommorow5;
        private System.Windows.Forms.Label tommorow6;
        private System.Windows.Forms.Label tommorow3Max;
        private System.Windows.Forms.Label tommorow4Max;
        private System.Windows.Forms.Label tommorow5Max;
        private System.Windows.Forms.Label tommorow6Max;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label tommorow6Min;
        private System.Windows.Forms.Label tommorow5Min;
        private System.Windows.Forms.Label tommorow4Min;
        private System.Windows.Forms.Label tommorow3Min;
        private System.Windows.Forms.PictureBox pbIcon1;
        private System.Windows.Forms.PictureBox pbIcon3;
        private System.Windows.Forms.PictureBox pbIcon4;
        private System.Windows.Forms.PictureBox pbIcon5;
        private System.Windows.Forms.PictureBox pbIcon6;
        private System.Windows.Forms.PictureBox pbIcon7;
        private System.Windows.Forms.PictureBox pbIcon2;
        private System.Windows.Forms.Label tommorowMax;
        private System.Windows.Forms.Label tommorow2Max;
        private System.Windows.Forms.Label todayMax;
        private System.Windows.Forms.Label tommorowMin;
        private System.Windows.Forms.Label tommorow2Min;
        private System.Windows.Forms.Label todayMin;
    }
}

