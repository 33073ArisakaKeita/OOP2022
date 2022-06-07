using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607 {
    public partial class Form1 : Form {
        Random rnd = new Random();//乱数オブジェクト
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btRandom_Click(object sender, EventArgs e) {
            Number.Value = rnd.Next((int)minNum.Value,(int)maxNum.Value+1);
        }

        private void Number_ValueChanged(object sender, EventArgs e) {

        }
    }
}
