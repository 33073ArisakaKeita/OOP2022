
namespace NumberGame {
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
            this.label1 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.maxNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(106, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "1～";
            // 
            // Number
            // 
            this.Number.BackColor = System.Drawing.Color.Red;
            this.Number.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Number.ForeColor = System.Drawing.SystemColors.Window;
            this.Number.Location = new System.Drawing.Point(364, 25);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(168, 55);
            this.Number.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(322, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 76);
            this.button1.TabIndex = 2;
            this.button1.Text = "判定";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maxNum
            // 
            this.maxNum.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.maxNum.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.maxNum.Location = new System.Drawing.Point(226, 128);
            this.maxNum.Name = "maxNum";
            this.maxNum.Size = new System.Drawing.Size(168, 55);
            this.maxNum.TabIndex = 1;
            this.maxNum.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.maxNum.ValueChanged += new System.EventHandler(this.maxNum_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(400, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "の中から以下略";
            // 
            // textbox
            // 
            this.textbox.Font = new System.Drawing.Font("HGP創英角ｺﾞｼｯｸUB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textbox.Location = new System.Drawing.Point(114, 372);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(625, 55);
            this.textbox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(869, 486);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maxNum);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "数当てゲーム";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Number;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown maxNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox;
    }
}

