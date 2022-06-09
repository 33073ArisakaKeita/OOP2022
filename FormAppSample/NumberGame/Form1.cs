using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame {
    public partial class Form1 : Form {
        Random rnd = new Random();//乱数オブジェクト
        int ans;

        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {
        }

        private void button1_Click(object sender, EventArgs e) {
            if (Number.Value == ans){
                textbox.Text = "正解！";
            }
            else if(Math.Abs(ans-Number.Value)<3){
                textbox.Text = "惜しい!";
            }
            else if (ans < Number.Value){
                textbox.Text = "答えはもっと小さい!!!!!!!!!!!";
            }
            else if (ans > Number.Value){
                textbox.Text = "答えはもっと大きい!!!!!!!!!!!";
            }
        }
 
        private void Form1_Load(object sender, EventArgs e) {
            getRandom();
        }

        private void maxNum_ValueChanged(object sender, EventArgs e) {
            getRandom();
        }

        private void getRandom() {
            ans = rnd.Next(1, (int)maxNum.Value);
            this.Text = ans.ToString();
        }
    }
}
