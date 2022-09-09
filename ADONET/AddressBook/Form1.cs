﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void addressTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.addressTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202206DataSet);

        }

        private void Form1_Load(object sender, EventArgs e) {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btUpdate_Click(object sender, EventArgs e) {
            var cur = addressTableDataGridView.CurrentRow;
            cur.Cells[1].Value = tbName.Text;
            cur.Cells[2].Value = tbAddress.Text;
            cur.Cells[3].Value = tbTel.Text;
            cur.Cells[4].Value = tbMail.Text;
            cur.Cells[5].Value = tbMemo.Text;
            cur.Cells[6].Value = ImageToByteArray(pbImage.Image);

            this.Validate();
            this.addressTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202206DataSet);

        }

        private void btConnect_Click(object sender, EventArgs e) {
            this.addressTableTableAdapter.Fill(this.infosys202206DataSet.AddressTable);
        }

        private void addressTableDataGridView_Click(object sender, EventArgs e) {
            var cur = addressTableDataGridView.CurrentRow;
            if (cur == null)
                return;
            tbName.Text = cur.Cells[1].Value.ToString();
            tbAddress.Text = cur.Cells[2].Value.ToString();
            tbTel.Text = cur.Cells[3].Value.ToString();
            tbMail.Text = cur.Cells[4].Value.ToString();
            tbMemo.Text = cur.Cells[5].Value.ToString();
            if(cur.Cells[6].Value != DBNull.Value && cur.Cells[6] != null)
                pbImage.Image = ByteArrayToImage((byte[])cur.Cells[6].Value);
            else
                pbImage.Image = null;

        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdImage.Filter = "画像ファイル|*.jpeg;*.png;*.bmp;*.gif" ;
            if (ofdImage.ShowDialog() == DialogResult.OK) {
                pbImage.Image = System.Drawing.Image.FromFile(ofdImage.FileName);
            }
        }

        private void btImageClear_Click(object sender, EventArgs e) {
            pbImage.Image = null;
        }
        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void addressTableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {
        }

        private void btAdd_Click(object sender, EventArgs e) {
            DataRow newRow = infosys202206DataSet.AddressTable.NewRow();
            newRow[1] = tbName.Text;
            newRow[2] = tbAddress.Text;
            //データベースへ新しいレコードを追加
            infosys202206DataSet.AddressTable.Rows.Add(newRow);
            //データベース更新
            this.addressTableTableAdapter.Update(this.infosys202206DataSet.AddressTable);

        }

        private void btSearchName_Click(object sender, EventArgs e) {
            this.addressTableTableAdapter.FillByName(this.infosys202206DataSet.AddressTable ,tbSearchName.Text);

        }
    }
}