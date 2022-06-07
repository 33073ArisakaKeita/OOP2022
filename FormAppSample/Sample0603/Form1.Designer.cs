
namespace Sample0603 {
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
            this.btPush = new System.Windows.Forms.Button();
            this.tbsuu1 = new System.Windows.Forms.TextBox();
            this.tbsuu2 = new System.Windows.Forms.TextBox();
            this.tbanser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudsuu1 = new System.Windows.Forms.NumericUpDown();
            this.nudsuu2 = new System.Windows.Forms.NumericUpDown();
            this.nudans = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudsuu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudsuu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudans)).BeginInit();
            this.SuspendLayout();
            // 
            // btPush
            // 
            this.btPush.BackColor = System.Drawing.Color.White;
            this.btPush.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btPush.Location = new System.Drawing.Point(369, 341);
            this.btPush.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btPush.Name = "btPush";
            this.btPush.Size = new System.Drawing.Size(510, 101);
            this.btPush.TabIndex = 0;
            this.btPush.Text = "計算";
            this.btPush.UseVisualStyleBackColor = false;
            this.btPush.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbsuu1
            // 
            this.tbsuu1.Location = new System.Drawing.Point(53, 12);
            this.tbsuu1.Name = "tbsuu1";
            this.tbsuu1.Size = new System.Drawing.Size(99, 55);
            this.tbsuu1.TabIndex = 1;
            // 
            // tbsuu2
            // 
            this.tbsuu2.Location = new System.Drawing.Point(232, 12);
            this.tbsuu2.Name = "tbsuu2";
            this.tbsuu2.Size = new System.Drawing.Size(100, 55);
            this.tbsuu2.TabIndex = 2;
            // 
            // tbanser
            // 
            this.tbanser.Location = new System.Drawing.Point(425, 12);
            this.tbanser.Name = "tbanser";
            this.tbanser.Size = new System.Drawing.Size(141, 55);
            this.tbanser.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // nudsuu1
            // 
            this.nudsuu1.Location = new System.Drawing.Point(53, 174);
            this.nudsuu1.Name = "nudsuu1";
            this.nudsuu1.Size = new System.Drawing.Size(99, 55);
            this.nudsuu1.TabIndex = 6;
            // 
            // nudsuu2
            // 
            this.nudsuu2.Location = new System.Drawing.Point(232, 174);
            this.nudsuu2.Name = "nudsuu2";
            this.nudsuu2.Size = new System.Drawing.Size(100, 55);
            this.nudsuu2.TabIndex = 7;
            // 
            // nudans
            // 
            this.nudans.Location = new System.Drawing.Point(425, 174);
            this.nudans.Name = "nudans";
            this.nudans.Size = new System.Drawing.Size(141, 55);
            this.nudans.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 48);
            this.label3.TabIndex = 9;
            this.label3.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 48);
            this.label4.TabIndex = 10;
            this.label4.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(26F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(906, 453);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudans);
            this.Controls.Add(this.nudsuu2);
            this.Controls.Add(this.nudsuu1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbanser);
            this.Controls.Add(this.tbsuu2);
            this.Controls.Add(this.tbsuu1);
            this.Controls.Add(this.btPush);
            this.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudsuu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudsuu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPush;
        private System.Windows.Forms.TextBox tbsuu1;
        private System.Windows.Forms.TextBox tbsuu2;
        private System.Windows.Forms.TextBox tbanser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudsuu1;
        private System.Windows.Forms.NumericUpDown nudsuu2;
        private System.Windows.Forms.NumericUpDown nudans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

