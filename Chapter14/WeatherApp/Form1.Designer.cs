
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
            this.tbWeatherInfo = new System.Windows.Forms.TextBox();
            this.btWeatherGet = new System.Windows.Forms.Button();
            this.cbtihou1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbtihou2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.Location = new System.Drawing.Point(12, 186);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.Size = new System.Drawing.Size(541, 252);
            this.tbWeatherInfo.TabIndex = 0;
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Location = new System.Drawing.Point(171, 73);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(75, 23);
            this.btWeatherGet.TabIndex = 1;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // cbtihou1
            // 
            this.cbtihou1.FormattingEnabled = true;
            this.cbtihou1.Location = new System.Drawing.Point(12, 24);
            this.cbtihou1.Name = "cbtihou1";
            this.cbtihou1.Size = new System.Drawing.Size(121, 20);
            this.cbtihou1.TabIndex = 2;
            this.cbtihou1.SelectedIndexChanged += new System.EventHandler(this.cbtihou1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "地方";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "県";
            // 
            // cbtihou2
            // 
            this.cbtihou2.FormattingEnabled = true;
            this.cbtihou2.Location = new System.Drawing.Point(14, 86);
            this.cbtihou2.Name = "cbtihou2";
            this.cbtihou2.Size = new System.Drawing.Size(121, 20);
            this.cbtihou2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbtihou2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbtihou1);
            this.Controls.Add(this.btWeatherGet);
            this.Controls.Add(this.tbWeatherInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWeatherInfo;
        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.ComboBox cbtihou1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbtihou2;
    }
}

