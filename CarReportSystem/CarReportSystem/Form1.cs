using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        private Settings settings = new Settings();

        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReport;
        }

        private void btExit_Click(object sender, EventArgs e) {
            //アプリケーションの終了
            Application.Exit();
        }

        private void btAdd_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(cbAuther.Text)) {
                MessageBox.Show("記載者が入力されていません");
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
                setCbAuther(cbAuther.Text);
                setCbCarName(cbCarName.Text);
                EnabledCheck();
                tbNull();

            }
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
            setCbAuther(cbAuther.Text);
            setCbCarName(cbCarName.Text);
            dgvCarReport.Refresh();
        }

        private void btDelete_Click(object sender, EventArgs e) {
            if (dgvCarReport.CurrentRow == null) return;
            int index = dgvCarReport.CurrentCell.RowIndex;

            listCarReport.RemoveAt(index);
            EnabledCheck();
            if (dgvCarReport.CurrentRow == null) {
                tbNull();
            }
            else {
                //消した後にindexをとってくる
                index = dgvCarReport.CurrentCell.RowIndex;
                dtpDate.Value = listCarReport[index].Date;
                cbAuther.Text = listCarReport[index].Auther;
                cbCarName.Text = listCarReport[index].CarName;
                tbReport.Text = listCarReport[index].Report;
                pbPicture.Image = listCarReport[index].Picture;
            }
            dgvCarReport.Refresh();
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;

        }

        private void btSave_Click(object sender, EventArgs e) {
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReport);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReport.DataSource = null;
                        dgvCarReport.DataSource = listCarReport;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                cbAuther.Items.Clear();//コンボボックスのアイテム削除
                foreach (var Auther in listCarReport.Select(p => p.Auther)) {
                    setCbAuther(Auther);//存在する会社を登録
                }
                cbCarName.Items.Clear();//コンボボックスのアイテム削除
                foreach (var CarName in listCarReport.Select(p => p.CarName)) {
                    setCbCarName(CarName);//存在する会社を登録
                }
            }
            EnabledCheck();
        }

        private void setMakerGroup(int index) {
            switch (listCarReport[index].Maker) {
                case CarReport.MakerGroup.トヨタ:
                    break;
                case CarReport.MakerGroup.日産:
                    break;
                case CarReport.MakerGroup.ホンダ:
                    break;
                case CarReport.MakerGroup.スバル:
                    break;
                case CarReport.MakerGroup.外国車:
                    break;
                case CarReport.MakerGroup.その他:
                    break;
                default:
                    break;
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

        private void tbNull() {
            cbAuther.Text = null;
            cbCarName.Text = null;
            tbReport.Text = null;
            pbPicture.Image = null;
        }

        private void EnabledCheck() {
            //三項条件演算子
            btDelete.Enabled = btUpdate.Enabled = listCarReport.Count() > 0 ? true : false;
        }

        private void setCbAuther(string auther) {
            if (!cbAuther.Items.Contains(auther)) {
                //まだ登録されていなければ登録
                cbAuther.Items.Add(auther);
            }
        }

        private void setCbCarName(string carname) {
            if (!cbCarName.Items.Contains(carname)) {
                //まだ登録されていなければ登録
                cbCarName.Items.Add(carname);
            }
        }

        private void btSizeImageChange_Click(object sender, EventArgs e) {
            if (pbPicture.SizeMode == PictureBoxSizeMode.Zoom)
                pbPicture.SizeMode = PictureBoxSizeMode.Normal;
            else
                pbPicture.SizeMode++;

            //pbPicture.SizeMode = pbPicture.SizeMode == PictureBoxSizeMode.Zoom　? pbPicture.SizeMode++ : PictureBoxSizeMode.Normal;
        }

        private void dgvCarReport_CellClick(object sender, DataGridViewCellEventArgs e) {
            //選択されているインデックスを取得する
            if (dgvCarReport.CurrentRow == null) return;
            int index = dgvCarReport.CurrentCell.RowIndex;
            //各リストの項目をテキストボックスへ表示する
            dtpDate.Value = listCarReport[index].Date;
            cbAuther.Text = listCarReport[index].Auther;
            cbCarName.Text = listCarReport[index].CarName;
            tbReport.Text = listCarReport[index].Report;
            pbPicture.Image = listCarReport[index].Picture;

            setMakerGroup(index);
        }

        private void ColorToolStripMenuItem(object sender, EventArgs e) {
            if(ColorSelect.ShowDialog() == DialogResult.OK) {
                //背景色の設定、settingsに設定
                BackColor = ColorSelect.Color;
                settings.MainFormColor = ColorSelect.Color.ToArgb();
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            EnabledCheck();
            using (var reader = XmlReader.Create("settings.xml")) {
                var serializer = new XmlSerializer(typeof(Settings));
                settings = serializer.Deserialize(reader) as Settings;
                BackColor = Color.FromArgb(settings.MainFormColor);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            using (var writer = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
        }
    }
}
