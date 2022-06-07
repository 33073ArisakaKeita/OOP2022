
namespace Sample0607 {
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
            this.btRandom = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.NumericUpDown();
            this.minNum = new System.Windows.Forms.NumericUpDown();
            this.maxNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum)).BeginInit();
            this.SuspendLayout();
            // 
            // btRandom
            // 
            this.btRandom.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btRandom.Location = new System.Drawing.Point(466, 287);
            this.btRandom.Name = "btRandom";
            this.btRandom.Size = new System.Drawing.Size(251, 66);
            this.btRandom.TabIndex = 0;
            this.btRandom.Text = "乱数取得";
            this.btRandom.UseVisualStyleBackColor = true;
            this.btRandom.Click += new System.EventHandler(this.btRandom_Click);
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Number.Location = new System.Drawing.Point(69, 287);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(250, 55);
            this.Number.TabIndex = 1;
            this.Number.ValueChanged += new System.EventHandler(this.Number_ValueChanged);
            // 
            // minNum
            // 
            this.minNum.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.minNum.Location = new System.Drawing.Point(214, 19);
            this.minNum.Name = "minNum";
            this.minNum.Size = new System.Drawing.Size(250, 55);
            this.minNum.TabIndex = 1;
            this.minNum.ValueChanged += new System.EventHandler(this.Number_ValueChanged);
            // 
            // maxNum
            // 
            this.maxNum.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.maxNum.Location = new System.Drawing.Point(214, 108);
            this.maxNum.Name = "maxNum";
            this.maxNum.Size = new System.Drawing.Size(250, 55);
            this.maxNum.TabIndex = 1;
            this.maxNum.ValueChanged += new System.EventHandler(this.Number_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "最小値";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(29, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "最大値";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxNum);
            this.Controls.Add(this.minNum);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.btRandom);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "乱数アプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRandom;
        private System.Windows.Forms.NumericUpDown Number;
        private System.Windows.Forms.NumericUpDown minNum;
        private System.Windows.Forms.NumericUpDown maxNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

