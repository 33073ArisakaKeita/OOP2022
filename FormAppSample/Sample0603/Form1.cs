using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0603 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        //ボタンクリックイベントハンドラ
        private void button1_Click(object sender, EventArgs e) {
            nudans.Value = nudsuu1.Value + nudsuu2.Value;
            //tbanser.Text = (int.Parse(tbsuu1.Text)+ int.Parse(tbsuu2.Text)).ToString();
        }
    }
}
