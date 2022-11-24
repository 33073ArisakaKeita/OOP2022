
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
            this.areas0 = new System.Windows.Forms.Label();
            this.pbweather = new System.Windows.Forms.PictureBox();
            this.tommorow3 = new System.Windows.Forms.Label();
            this.tommorow4 = new System.Windows.Forms.Label();
            this.tommorow5 = new System.Windows.Forms.Label();
            this.tommorow6 = new System.Windows.Forms.Label();
            this.tommorow3Max = new System.Windows.Forms.Label();
            this.tommorow4Max = new System.Windows.Forms.Label();
            this.tommorow5Max = new System.Windows.Forms.Label();
            this.tommorow6Max = new System.Windows.Forms.Label();
            this.tommorow6Min = new System.Windows.Forms.Label();
            this.tommorow5Min = new System.Windows.Forms.Label();
            this.tommorow4Min = new System.Windows.Forms.Label();
            this.tommorow3Min = new System.Windows.Forms.Label();
            this.areas0pbIcon = new System.Windows.Forms.PictureBox();
            this.pbIcon3 = new System.Windows.Forms.PictureBox();
            this.pbIcon4 = new System.Windows.Forms.PictureBox();
            this.pbIcon5 = new System.Windows.Forms.PictureBox();
            this.pbIcon6 = new System.Windows.Forms.PictureBox();
            this.pbIcon7 = new System.Windows.Forms.PictureBox();
            this.pbIcon2 = new System.Windows.Forms.PictureBox();
            this.tommorowMax = new System.Windows.Forms.Label();
            this.tommorow2Max = new System.Windows.Forms.Label();
            this.areas0Max = new System.Windows.Forms.Label();
            this.tommorowMin = new System.Windows.Forms.Label();
            this.tommorow2Min = new System.Windows.Forms.Label();
            this.areas0Min = new System.Windows.Forms.Label();
            this.tommorow2 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.tbWeatherInfo = new System.Windows.Forms.TextBox();
            this.tommorow = new System.Windows.Forms.Label();
            this.areas1 = new System.Windows.Forms.Label();
            this.areas2 = new System.Windows.Forms.Label();
            this.areas3 = new System.Windows.Forms.Label();
            this.areas0Weather = new System.Windows.Forms.Label();
            this.areas1Weather = new System.Windows.Forms.Label();
            this.areas2Max = new System.Windows.Forms.Label();
            this.areas3Weather = new System.Windows.Forms.Label();
            this.areas1Max = new System.Windows.Forms.Label();
            this.areas1Min = new System.Windows.Forms.Label();
            this.areas2Min = new System.Windows.Forms.Label();
            this.areas2Weather = new System.Windows.Forms.Label();
            this.areas3Max = new System.Windows.Forms.Label();
            this.areas3Min = new System.Windows.Forms.Label();
            this.labelarea = new System.Windows.Forms.Label();
            this.areas1pbIcon = new System.Windows.Forms.PictureBox();
            this.areas2pbIcon = new System.Windows.Forms.PictureBox();
            this.areas3pbIcon = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbweather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areas0pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areas1pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areas2pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areas3pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Location = new System.Drawing.Point(63, 416);
            this.btWeatherGet.Margin = new System.Windows.Forms.Padding(4);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(112, 26);
            this.btWeatherGet.TabIndex = 1;
            this.btWeatherGet.Text = "更新";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // cbtihou1
            // 
            this.cbtihou1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtihou1.FormattingEnabled = true;
            this.cbtihou1.Location = new System.Drawing.Point(18, 455);
            this.cbtihou1.Margin = new System.Windows.Forms.Padding(4);
            this.cbtihou1.Name = "cbtihou1";
            this.cbtihou1.Size = new System.Drawing.Size(195, 24);
            this.cbtihou1.TabIndex = 2;
            this.cbtihou1.SelectedIndexChanged += new System.EventHandler(this.cbtihou1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 421);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "地方";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 297);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 4;
            // 
            // cbtihou2
            // 
            this.cbtihou2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtihou2.FormattingEnabled = true;
            this.cbtihou2.Location = new System.Drawing.Point(229, 455);
            this.cbtihou2.Margin = new System.Windows.Forms.Padding(4);
            this.cbtihou2.Name = "cbtihou2";
            this.cbtihou2.Size = new System.Drawing.Size(195, 24);
            this.cbtihou2.TabIndex = 5;
            this.cbtihou2.SelectedIndexChanged += new System.EventHandler(this.cbtihou2_SelectedIndexChanged);
            // 
            // areas0
            // 
            this.areas0.AutoSize = true;
            this.areas0.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.areas0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.areas0.Location = new System.Drawing.Point(15, 80);
            this.areas0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.areas0.Name = "areas0";
            this.areas0.Size = new System.Drawing.Size(88, 16);
            this.areas0.TabIndex = 7;
            this.areas0.Text = "今日の天気";
            // 
            // pbweather
            // 
            this.pbweather.Location = new System.Drawing.Point(444, 436);
            this.pbweather.Margin = new System.Windows.Forms.Padding(4);
            this.pbweather.Name = "pbweather";
            this.pbweather.Size = new System.Drawing.Size(320, 280);
            this.pbweather.TabIndex = 12;
            this.pbweather.TabStop = false;
            // 
            // tommorow3
            // 
            this.tommorow3.AutoSize = true;
            this.tommorow3.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tommorow3.ForeColor = System.Drawing.Color.White;
            this.tommorow3.Location = new System.Drawing.Point(580, 180);
            this.tommorow3.Name = "tommorow3";
            this.tommorow3.Size = new System.Drawing.Size(23, 21);
            this.tommorow3.TabIndex = 15;
            this.tommorow3.Text = "/";
            // 
            // tommorow4
            // 
            this.tommorow4.AutoSize = true;
            this.tommorow4.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tommorow4.ForeColor = System.Drawing.Color.White;
            this.tommorow4.Location = new System.Drawing.Point(580, 230);
            this.tommorow4.Name = "tommorow4";
            this.tommorow4.Size = new System.Drawing.Size(23, 21);
            this.tommorow4.TabIndex = 15;
            this.tommorow4.Text = "/";
            // 
            // tommorow5
            // 
            this.tommorow5.AutoSize = true;
            this.tommorow5.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tommorow5.ForeColor = System.Drawing.Color.White;
            this.tommorow5.Location = new System.Drawing.Point(580, 280);
            this.tommorow5.Name = "tommorow5";
            this.tommorow5.Size = new System.Drawing.Size(23, 21);
            this.tommorow5.TabIndex = 15;
            this.tommorow5.Text = "/";
            // 
            // tommorow6
            // 
            this.tommorow6.AutoSize = true;
            this.tommorow6.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tommorow6.ForeColor = System.Drawing.Color.White;
            this.tommorow6.Location = new System.Drawing.Point(580, 330);
            this.tommorow6.Name = "tommorow6";
            this.tommorow6.Size = new System.Drawing.Size(23, 21);
            this.tommorow6.TabIndex = 15;
            this.tommorow6.Text = "/";
            // 
            // tommorow3Max
            // 
            this.tommorow3Max.AutoSize = true;
            this.tommorow3Max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tommorow3Max.Location = new System.Drawing.Point(692, 184);
            this.tommorow3Max.Name = "tommorow3Max";
            this.tommorow3Max.Size = new System.Drawing.Size(24, 16);
            this.tommorow3Max.TabIndex = 15;
            this.tommorow3Max.Text = "温";
            // 
            // tommorow4Max
            // 
            this.tommorow4Max.AutoSize = true;
            this.tommorow4Max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tommorow4Max.Location = new System.Drawing.Point(692, 234);
            this.tommorow4Max.Name = "tommorow4Max";
            this.tommorow4Max.Size = new System.Drawing.Size(24, 16);
            this.tommorow4Max.TabIndex = 15;
            this.tommorow4Max.Text = "温";
            // 
            // tommorow5Max
            // 
            this.tommorow5Max.AutoSize = true;
            this.tommorow5Max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tommorow5Max.Location = new System.Drawing.Point(692, 284);
            this.tommorow5Max.Name = "tommorow5Max";
            this.tommorow5Max.Size = new System.Drawing.Size(24, 16);
            this.tommorow5Max.TabIndex = 15;
            this.tommorow5Max.Text = "温";
            // 
            // tommorow6Max
            // 
            this.tommorow6Max.AutoSize = true;
            this.tommorow6Max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tommorow6Max.Location = new System.Drawing.Point(692, 334);
            this.tommorow6Max.Name = "tommorow6Max";
            this.tommorow6Max.Size = new System.Drawing.Size(24, 16);
            this.tommorow6Max.TabIndex = 15;
            this.tommorow6Max.Text = "温";
            // 
            // tommorow6Min
            // 
            this.tommorow6Min.AutoSize = true;
            this.tommorow6Min.ForeColor = System.Drawing.Color.Aqua;
            this.tommorow6Min.Location = new System.Drawing.Point(737, 334);
            this.tommorow6Min.Name = "tommorow6Min";
            this.tommorow6Min.Size = new System.Drawing.Size(24, 16);
            this.tommorow6Min.TabIndex = 15;
            this.tommorow6Min.Text = "温";
            // 
            // tommorow5Min
            // 
            this.tommorow5Min.AutoSize = true;
            this.tommorow5Min.ForeColor = System.Drawing.Color.Aqua;
            this.tommorow5Min.Location = new System.Drawing.Point(737, 284);
            this.tommorow5Min.Name = "tommorow5Min";
            this.tommorow5Min.Size = new System.Drawing.Size(24, 16);
            this.tommorow5Min.TabIndex = 15;
            this.tommorow5Min.Text = "温";
            // 
            // tommorow4Min
            // 
            this.tommorow4Min.AutoSize = true;
            this.tommorow4Min.ForeColor = System.Drawing.Color.Aqua;
            this.tommorow4Min.Location = new System.Drawing.Point(737, 234);
            this.tommorow4Min.Name = "tommorow4Min";
            this.tommorow4Min.Size = new System.Drawing.Size(24, 16);
            this.tommorow4Min.TabIndex = 15;
            this.tommorow4Min.Text = "温";
            // 
            // tommorow3Min
            // 
            this.tommorow3Min.AutoSize = true;
            this.tommorow3Min.ForeColor = System.Drawing.Color.Aqua;
            this.tommorow3Min.Location = new System.Drawing.Point(737, 184);
            this.tommorow3Min.Name = "tommorow3Min";
            this.tommorow3Min.Size = new System.Drawing.Size(24, 16);
            this.tommorow3Min.TabIndex = 15;
            this.tommorow3Min.Text = "温";
            // 
            // areas0pbIcon
            // 
            this.areas0pbIcon.Location = new System.Drawing.Point(156, 68);
            this.areas0pbIcon.Name = "areas0pbIcon";
            this.areas0pbIcon.Size = new System.Drawing.Size(40, 33);
            this.areas0pbIcon.TabIndex = 16;
            this.areas0pbIcon.TabStop = false;
            // 
            // pbIcon3
            // 
            this.pbIcon3.Location = new System.Drawing.Point(655, 128);
            this.pbIcon3.Name = "pbIcon3";
            this.pbIcon3.Size = new System.Drawing.Size(31, 27);
            this.pbIcon3.TabIndex = 16;
            this.pbIcon3.TabStop = false;
            // 
            // pbIcon4
            // 
            this.pbIcon4.Location = new System.Drawing.Point(655, 178);
            this.pbIcon4.Name = "pbIcon4";
            this.pbIcon4.Size = new System.Drawing.Size(31, 27);
            this.pbIcon4.TabIndex = 16;
            this.pbIcon4.TabStop = false;
            // 
            // pbIcon5
            // 
            this.pbIcon5.Location = new System.Drawing.Point(655, 228);
            this.pbIcon5.Name = "pbIcon5";
            this.pbIcon5.Size = new System.Drawing.Size(31, 27);
            this.pbIcon5.TabIndex = 16;
            this.pbIcon5.TabStop = false;
            // 
            // pbIcon6
            // 
            this.pbIcon6.Location = new System.Drawing.Point(655, 278);
            this.pbIcon6.Name = "pbIcon6";
            this.pbIcon6.Size = new System.Drawing.Size(31, 27);
            this.pbIcon6.TabIndex = 16;
            this.pbIcon6.TabStop = false;
            // 
            // pbIcon7
            // 
            this.pbIcon7.Location = new System.Drawing.Point(655, 328);
            this.pbIcon7.Name = "pbIcon7";
            this.pbIcon7.Size = new System.Drawing.Size(31, 27);
            this.pbIcon7.TabIndex = 16;
            this.pbIcon7.TabStop = false;
            // 
            // pbIcon2
            // 
            this.pbIcon2.Location = new System.Drawing.Point(655, 78);
            this.pbIcon2.Name = "pbIcon2";
            this.pbIcon2.Size = new System.Drawing.Size(31, 27);
            this.pbIcon2.TabIndex = 16;
            this.pbIcon2.TabStop = false;
            // 
            // tommorowMax
            // 
            this.tommorowMax.AutoSize = true;
            this.tommorowMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tommorowMax.Location = new System.Drawing.Point(692, 84);
            this.tommorowMax.Name = "tommorowMax";
            this.tommorowMax.Size = new System.Drawing.Size(24, 16);
            this.tommorowMax.TabIndex = 17;
            this.tommorowMax.Text = "温";
            // 
            // tommorow2Max
            // 
            this.tommorow2Max.AutoSize = true;
            this.tommorow2Max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tommorow2Max.Location = new System.Drawing.Point(692, 134);
            this.tommorow2Max.Name = "tommorow2Max";
            this.tommorow2Max.Size = new System.Drawing.Size(24, 16);
            this.tommorow2Max.TabIndex = 17;
            this.tommorow2Max.Text = "温";
            // 
            // areas0Max
            // 
            this.areas0Max.AutoSize = true;
            this.areas0Max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.areas0Max.Location = new System.Drawing.Point(200, 78);
            this.areas0Max.Name = "areas0Max";
            this.areas0Max.Size = new System.Drawing.Size(24, 16);
            this.areas0Max.TabIndex = 18;
            this.areas0Max.Text = "温";
            // 
            // tommorowMin
            // 
            this.tommorowMin.AutoSize = true;
            this.tommorowMin.ForeColor = System.Drawing.Color.Aqua;
            this.tommorowMin.Location = new System.Drawing.Point(737, 84);
            this.tommorowMin.Name = "tommorowMin";
            this.tommorowMin.Size = new System.Drawing.Size(24, 16);
            this.tommorowMin.TabIndex = 17;
            this.tommorowMin.Text = "温";
            // 
            // tommorow2Min
            // 
            this.tommorow2Min.AutoSize = true;
            this.tommorow2Min.ForeColor = System.Drawing.Color.Aqua;
            this.tommorow2Min.Location = new System.Drawing.Point(737, 134);
            this.tommorow2Min.Name = "tommorow2Min";
            this.tommorow2Min.Size = new System.Drawing.Size(24, 16);
            this.tommorow2Min.TabIndex = 17;
            this.tommorow2Min.Text = "温";
            // 
            // areas0Min
            // 
            this.areas0Min.AutoSize = true;
            this.areas0Min.ForeColor = System.Drawing.Color.White;
            this.areas0Min.Location = new System.Drawing.Point(251, 78);
            this.areas0Min.Name = "areas0Min";
            this.areas0Min.Size = new System.Drawing.Size(24, 16);
            this.areas0Min.TabIndex = 18;
            this.areas0Min.Text = "温";
            // 
            // tommorow2
            // 
            this.tommorow2.AutoSize = true;
            this.tommorow2.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tommorow2.ForeColor = System.Drawing.Color.White;
            this.tommorow2.Location = new System.Drawing.Point(580, 130);
            this.tommorow2.Name = "tommorow2";
            this.tommorow2.Size = new System.Drawing.Size(23, 21);
            this.tommorow2.TabIndex = 15;
            this.tommorow2.Text = "/";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(15, 10);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(116, 48);
            this.labelDate.TabIndex = 19;
            this.labelDate.Text = "日付";
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.Location = new System.Drawing.Point(18, 487);
            this.tbWeatherInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.ReadOnly = true;
            this.tbWeatherInfo.Size = new System.Drawing.Size(412, 229);
            this.tbWeatherInfo.TabIndex = 14;
            // 
            // tommorow
            // 
            this.tommorow.AutoSize = true;
            this.tommorow.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tommorow.ForeColor = System.Drawing.Color.White;
            this.tommorow.Location = new System.Drawing.Point(580, 80);
            this.tommorow.Name = "tommorow";
            this.tommorow.Size = new System.Drawing.Size(23, 21);
            this.tommorow.TabIndex = 15;
            this.tommorow.Text = "/";
            // 
            // areas1
            // 
            this.areas1.AutoSize = true;
            this.areas1.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.areas1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.areas1.Location = new System.Drawing.Point(15, 160);
            this.areas1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.areas1.Name = "areas1";
            this.areas1.Size = new System.Drawing.Size(88, 16);
            this.areas1.TabIndex = 7;
            this.areas1.Text = "今日の天気";
            // 
            // areas2
            // 
            this.areas2.AutoSize = true;
            this.areas2.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.areas2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.areas2.Location = new System.Drawing.Point(15, 240);
            this.areas2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.areas2.Name = "areas2";
            this.areas2.Size = new System.Drawing.Size(88, 16);
            this.areas2.TabIndex = 7;
            this.areas2.Text = "今日の天気";
            // 
            // areas3
            // 
            this.areas3.AutoSize = true;
            this.areas3.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.areas3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.areas3.Location = new System.Drawing.Point(15, 320);
            this.areas3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.areas3.Name = "areas3";
            this.areas3.Size = new System.Drawing.Size(88, 16);
            this.areas3.TabIndex = 7;
            this.areas3.Text = "今日の天気";
            // 
            // areas0Weather
            // 
            this.areas0Weather.ForeColor = System.Drawing.Color.White;
            this.areas0Weather.Location = new System.Drawing.Point(15, 110);
            this.areas0Weather.Name = "areas0Weather";
            this.areas0Weather.Size = new System.Drawing.Size(540, 35);
            this.areas0Weather.TabIndex = 20;
            this.areas0Weather.Text = "text";
            // 
            // areas1Weather
            // 
            this.areas1Weather.ForeColor = System.Drawing.Color.White;
            this.areas1Weather.Location = new System.Drawing.Point(15, 190);
            this.areas1Weather.Name = "areas1Weather";
            this.areas1Weather.Size = new System.Drawing.Size(540, 35);
            this.areas1Weather.TabIndex = 20;
            this.areas1Weather.Text = "txet";
            // 
            // areas2Max
            // 
            this.areas2Max.AutoSize = true;
            this.areas2Max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.areas2Max.Location = new System.Drawing.Point(200, 238);
            this.areas2Max.Name = "areas2Max";
            this.areas2Max.Size = new System.Drawing.Size(24, 16);
            this.areas2Max.TabIndex = 20;
            this.areas2Max.Text = "温";
            // 
            // areas3Weather
            // 
            this.areas3Weather.ForeColor = System.Drawing.Color.White;
            this.areas3Weather.Location = new System.Drawing.Point(15, 350);
            this.areas3Weather.Name = "areas3Weather";
            this.areas3Weather.Size = new System.Drawing.Size(540, 35);
            this.areas3Weather.TabIndex = 20;
            this.areas3Weather.Text = "text";
            // 
            // areas1Max
            // 
            this.areas1Max.AutoSize = true;
            this.areas1Max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.areas1Max.Location = new System.Drawing.Point(200, 153);
            this.areas1Max.Name = "areas1Max";
            this.areas1Max.Size = new System.Drawing.Size(24, 16);
            this.areas1Max.TabIndex = 20;
            this.areas1Max.Text = "温";
            // 
            // areas1Min
            // 
            this.areas1Min.AutoSize = true;
            this.areas1Min.ForeColor = System.Drawing.Color.White;
            this.areas1Min.Location = new System.Drawing.Point(251, 153);
            this.areas1Min.Name = "areas1Min";
            this.areas1Min.Size = new System.Drawing.Size(24, 16);
            this.areas1Min.TabIndex = 20;
            this.areas1Min.Text = "温";
            // 
            // areas2Min
            // 
            this.areas2Min.AutoSize = true;
            this.areas2Min.ForeColor = System.Drawing.Color.White;
            this.areas2Min.Location = new System.Drawing.Point(251, 238);
            this.areas2Min.Name = "areas2Min";
            this.areas2Min.Size = new System.Drawing.Size(24, 16);
            this.areas2Min.TabIndex = 20;
            this.areas2Min.Text = "温";
            // 
            // areas2Weather
            // 
            this.areas2Weather.ForeColor = System.Drawing.Color.White;
            this.areas2Weather.Location = new System.Drawing.Point(15, 270);
            this.areas2Weather.Name = "areas2Weather";
            this.areas2Weather.Size = new System.Drawing.Size(540, 35);
            this.areas2Weather.TabIndex = 20;
            this.areas2Weather.Text = "text";
            // 
            // areas3Max
            // 
            this.areas3Max.AutoSize = true;
            this.areas3Max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.areas3Max.Location = new System.Drawing.Point(200, 318);
            this.areas3Max.Name = "areas3Max";
            this.areas3Max.Size = new System.Drawing.Size(24, 16);
            this.areas3Max.TabIndex = 20;
            this.areas3Max.Text = "温";
            // 
            // areas3Min
            // 
            this.areas3Min.AutoSize = true;
            this.areas3Min.ForeColor = System.Drawing.Color.White;
            this.areas3Min.Location = new System.Drawing.Point(251, 318);
            this.areas3Min.Name = "areas3Min";
            this.areas3Min.Size = new System.Drawing.Size(24, 16);
            this.areas3Min.TabIndex = 20;
            this.areas3Min.Text = "温";
            // 
            // labelarea
            // 
            this.labelarea.AutoSize = true;
            this.labelarea.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelarea.ForeColor = System.Drawing.Color.White;
            this.labelarea.Location = new System.Drawing.Point(235, 10);
            this.labelarea.Name = "labelarea";
            this.labelarea.Size = new System.Drawing.Size(164, 48);
            this.labelarea.TabIndex = 21;
            this.labelarea.Text = "地方名";
            // 
            // areas1pbIcon
            // 
            this.areas1pbIcon.Location = new System.Drawing.Point(156, 143);
            this.areas1pbIcon.Name = "areas1pbIcon";
            this.areas1pbIcon.Size = new System.Drawing.Size(40, 33);
            this.areas1pbIcon.TabIndex = 16;
            this.areas1pbIcon.TabStop = false;
            // 
            // areas2pbIcon
            // 
            this.areas2pbIcon.Location = new System.Drawing.Point(156, 228);
            this.areas2pbIcon.Name = "areas2pbIcon";
            this.areas2pbIcon.Size = new System.Drawing.Size(40, 33);
            this.areas2pbIcon.TabIndex = 16;
            this.areas2pbIcon.TabStop = false;
            // 
            // areas3pbIcon
            // 
            this.areas3pbIcon.Location = new System.Drawing.Point(156, 308);
            this.areas3pbIcon.Name = "areas3pbIcon";
            this.areas3pbIcon.Size = new System.Drawing.Size(40, 33);
            this.areas3pbIcon.TabIndex = 16;
            this.areas3pbIcon.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 26);
            this.button1.TabIndex = 22;
            this.button1.Text = "天気図";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(777, 721);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelarea);
            this.Controls.Add(this.areas3Max);
            this.Controls.Add(this.areas3Min);
            this.Controls.Add(this.areas3Weather);
            this.Controls.Add(this.areas2Weather);
            this.Controls.Add(this.areas2Max);
            this.Controls.Add(this.areas2Min);
            this.Controls.Add(this.areas1Min);
            this.Controls.Add(this.areas1Max);
            this.Controls.Add(this.areas1Weather);
            this.Controls.Add(this.areas0Weather);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.areas0Min);
            this.Controls.Add(this.areas0Max);
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
            this.Controls.Add(this.areas1pbIcon);
            this.Controls.Add(this.areas3pbIcon);
            this.Controls.Add(this.areas2pbIcon);
            this.Controls.Add(this.areas0pbIcon);
            this.Controls.Add(this.tommorow3Min);
            this.Controls.Add(this.tommorow4Min);
            this.Controls.Add(this.tommorow5Min);
            this.Controls.Add(this.tommorow6Min);
            this.Controls.Add(this.tommorow6Max);
            this.Controls.Add(this.tommorow6);
            this.Controls.Add(this.tommorow5Max);
            this.Controls.Add(this.tommorow5);
            this.Controls.Add(this.tommorow4Max);
            this.Controls.Add(this.tommorow4);
            this.Controls.Add(this.tommorow3Max);
            this.Controls.Add(this.tommorow);
            this.Controls.Add(this.tommorow2);
            this.Controls.Add(this.tommorow3);
            this.Controls.Add(this.tbWeatherInfo);
            this.Controls.Add(this.pbweather);
            this.Controls.Add(this.areas3);
            this.Controls.Add(this.areas2);
            this.Controls.Add(this.areas1);
            this.Controls.Add(this.areas0);
            this.Controls.Add(this.cbtihou2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbtihou1);
            this.Controls.Add(this.btWeatherGet);
            this.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "天気予報";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbweather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areas0pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areas1pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areas2pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areas3pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.ComboBox cbtihou1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbtihou2;
        private System.Windows.Forms.Label areas0;
        private System.Windows.Forms.PictureBox pbweather;
        private System.Windows.Forms.Label tommorow3;
        private System.Windows.Forms.Label tommorow4;
        private System.Windows.Forms.Label tommorow5;
        private System.Windows.Forms.Label tommorow6;
        private System.Windows.Forms.Label tommorow3Max;
        private System.Windows.Forms.Label tommorow4Max;
        private System.Windows.Forms.Label tommorow5Max;
        private System.Windows.Forms.Label tommorow6Max;
        private System.Windows.Forms.Label tommorow6Min;
        private System.Windows.Forms.Label tommorow5Min;
        private System.Windows.Forms.Label tommorow4Min;
        private System.Windows.Forms.Label tommorow3Min;
        private System.Windows.Forms.PictureBox areas0pbIcon;
        private System.Windows.Forms.PictureBox pbIcon3;
        private System.Windows.Forms.PictureBox pbIcon4;
        private System.Windows.Forms.PictureBox pbIcon5;
        private System.Windows.Forms.PictureBox pbIcon6;
        private System.Windows.Forms.PictureBox pbIcon7;
        private System.Windows.Forms.PictureBox pbIcon2;
        private System.Windows.Forms.Label tommorowMax;
        private System.Windows.Forms.Label tommorow2Max;
        private System.Windows.Forms.Label areas0Max;
        private System.Windows.Forms.Label tommorowMin;
        private System.Windows.Forms.Label tommorow2Min;
        private System.Windows.Forms.Label areas0Min;
        private System.Windows.Forms.Label tommorow2;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox tbWeatherInfo;
        private System.Windows.Forms.Label tommorow;
        private System.Windows.Forms.Label areas1;
        private System.Windows.Forms.Label areas2;
        private System.Windows.Forms.Label areas3;
        private System.Windows.Forms.Label areas0Weather;
        private System.Windows.Forms.Label areas1Weather;
        private System.Windows.Forms.Label areas2Max;
        private System.Windows.Forms.Label areas3Weather;
        private System.Windows.Forms.Label areas1Max;
        private System.Windows.Forms.Label areas1Min;
        private System.Windows.Forms.Label areas2Min;
        private System.Windows.Forms.Label areas2Weather;
        private System.Windows.Forms.Label areas3Max;
        private System.Windows.Forms.Label areas3Min;
        private System.Windows.Forms.Label labelarea;
        private System.Windows.Forms.PictureBox areas1pbIcon;
        private System.Windows.Forms.PictureBox areas2pbIcon;
        private System.Windows.Forms.PictureBox areas3pbIcon;
        private System.Windows.Forms.Button button1;
    }
}

