using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReport;
        }

        private void btExit_Click(object sender, EventArgs e) {
            //アプリケーションの終了
            Application.Exit();
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;

        }

        private void EnabledCheck() {
            //三項条件演算子
            btDelete.Enabled = btUpdate.Enabled = listCarReport.Count() > 0 ? true : false;
        }

        private void btAdd_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(cbAuther.Text)) {
                MessageBox.Show("氏名が入力されていません");
                return;
            }
            else {
                CarReport carReport = new CarReport {
                    Date = dtpDate.Value,
                    Auther = cbAuther.Text,
                    Maker = GetMakerGroup(),
                    CarName = cbCarName.Text,
                    Report = tbReport.Text,
                    Picture = pbPicture.Image,
                };
                listCarReport.Add(carReport);
                this.dgvCarReport.CurrentCell = this.dgvCarReport[0, listCarReport.Count - 1];
                EnabledCheck();
            }
        }

        private CarReport.MakerGroup GetMakerGroup() {
            CarReport.MakerGroup selectedMakerGroup = CarReport.MakerGroup.トヨタ;
            if (rbToyota.Checked)
                selectedMakerGroup = CarReport.MakerGroup.トヨタ;
            if (rbNissan.Checked)
                selectedMakerGroup = CarReport.MakerGroup.日産;
            if (rbHonda.Checked)
                selectedMakerGroup = CarReport.MakerGroup.ホンダ;
            if (rbSubaru.Checked)
                selectedMakerGroup = CarReport.MakerGroup.スバル;
            if (rbForeignCar.Checked)
                selectedMakerGroup = CarReport.MakerGroup.外国車;
            if (rbOther.Checked)
                selectedMakerGroup = CarReport.MakerGroup.その他;
            return selectedMakerGroup;
        }

        private void btUpdate_Click(object sender, EventArgs e) {
            if (dgvCarReport.CurrentRow == null) return;
            int index = dgvCarReport.CurrentCell.RowIndex;

            if (String.IsNullOrWhiteSpace(cbAuther.Text)) {
                MessageBox.Show("氏名が入力されていません");
                return;
            }
            else {
                listCarReport[index].Date = dtpDate.Value;
                listCarReport[index].Auther = cbAuther.Text;
                listCarReport[index].Maker = GetMakerGroup();
                listCarReport[index].CarName = cbCarName.Text;
                listCarReport[index].Report = tbReport.Text;
                listCarReport[index].Picture = pbPicture.Image;
            }
            dgvCarReport.Refresh();
        }
    }
}
