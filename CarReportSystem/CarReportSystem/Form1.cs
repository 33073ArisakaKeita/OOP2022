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
        private Settings settings = Settings.getInstance();

        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReport;
        }

        private void btExit_Click(object sender, EventArgs e) {
            //アプリケーションの終了
            Application.Exit();
        }

        private void btAdd_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(cbAuthor.Text)) {
                MessageBox.Show("記載者が入力されていません");
                return;
            }
            else {
                DataRow newRow = infosys202206DataSet.CarReportDB.NewRow();
                newRow[1] = dtpDate.Value;
                newRow[2] = cbAuthor.Text;
                newRow[3] = GetMakerGroup();
                newRow[4] = cbCarName.Text;
                newRow[5] = tbReport.Text;
                newRow[6] = ImageToByteArray(pbPicture.Image);
                //データベースへ新しいレコードを追加
                infosys202206DataSet.CarReportDB.Rows.Add(newRow);
                //データベース更新
                this.carReportDBTableAdapter.Update(this.infosys202206DataSet.CarReportDB);
                setCbAuther(cbAuthor.Text);
                setCbCarName(cbCarName.Text);
                EnabledCheck();
                tbNull();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e) {
            var cur = carReportDBDataGridView.CurrentRow;
            if (String.IsNullOrWhiteSpace(cbAuthor.Text)) {
                MessageBox.Show("氏名が入力されていません");
                return;
            }
            else {
                cur.Cells[1].Value = dtpDate.Value;
                cur.Cells[2].Value = cbAuthor.Text;
                cur.Cells[3].Value = GetMakerGroup();
                cur.Cells[4].Value = cbCarName.Text;
                cur.Cells[5].Value = tbReport.Text;
                cur.Cells[6].Value = ImageToByteArray(pbPicture.Image);
            }
            setCbAuther(cbAuthor.Text);
            setCbCarName(cbCarName.Text);
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202206DataSet);
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
                ////消した後にindexをとってくる
                //index = dgvCarReport.CurrentCell.RowIndex;
                //dtpDate.Value = listCarReport[index].Date;
                //cbAuthor.Text = listCarReport[index].Author;
                //cbCarName.Text = listCarReport[index].CarName;
                //tbReport.Text = listCarReport[index].Report;
                //pbPicture.Image = listCarReport[index].Picture;
            }
            dgvCarReport.Refresh();
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            ofdFileOpenDialog.Filter = "画像ファイル|*.jpeg;*.png;*.bmp;*.gif";
            if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
        }

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void dgvCarReport_CellClick(object sender, DataGridViewCellEventArgs e) {
            ////選択されているインデックスを取得する
            //if (dgvCarReport.CurrentRow == null) return;
            //int index = dgvCarReport.CurrentCell.RowIndex;
            ////各リストの項目をテキストボックスへ表示する
            //dtpDate.Value = listCarReport[index].Date;
            //cbAuthor.Text = listCarReport[index].Author;
            //cbCarName.Text = listCarReport[index].CarName;
            //tbReport.Text = listCarReport[index].Report;
            //pbPicture.Image = listCarReport[index].Picture;

            //setMakerGroup(index);
        }

        private void btSave_Click(object sender, EventArgs e) {
            //if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
            //    try {
            //        //バイナリ形式でシリアル化
            //        var bf = new BinaryFormatter();
            //        using (FileStream fs = File.Open(sfdSaveDialog.FileName, FileMode.Create)) {
            //            bf.Serialize(fs, listCarReport);
            //        }
            //    }
            //    catch (Exception ex) {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
        }

        private void btOpen_Click(object sender, EventArgs e) {
        //    if (ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
        //        try {
        //            //バイナリ形式で逆シリアル化
        //            var bf = new BinaryFormatter();

        //            using (FileStream fs = File.Open(ofdFileOpenDialog.FileName, FileMode.Open, FileAccess.Read)) {
        //                //逆シリアル化して読み込む
        //                listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
        //                dgvCarReport.DataSource = null;
        //                dgvCarReport.DataSource = listCarReport;
        //            }
        //        }
        //        catch (Exception ex) {
        //            MessageBox.Show(ex.Message);
        //        }
        //        cbAuthor.Items.Clear();//コンボボックスのアイテム削除
        //        foreach (var Auther in listCarReport.Select(p => p.Author)) {
        //            setCbAuther(Auther);//存在する会社を登録
        //        }
        //        cbCarName.Items.Clear();//コンボボックスのアイテム削除
        //        foreach (var CarName in listCarReport.Select(p => p.CarName)) {
        //            setCbCarName(CarName);//存在する会社を登録
        //        }
        //    }
        //    EnabledCheck();
        }

        private void setMakerGroup() {
            switch (carReportDBDataGridView.CurrentRow.Cells[3].Value) {
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
            cbAuthor.Text = null;
            cbCarName.Text = null;
            tbReport.Text = null;
            pbPicture.Image = null;
        }

        private void EnabledCheck() {
            //三項条件演算子
            btDelete.Enabled = btUpdate.Enabled = infosys202206DataSet.CarReportDB.Columns.Count > 0 ? true : false;
        }

        private void setCbAuther(string author) {
            if (!cbAuthor.Items.Contains(author)) {
                //まだ登録されていなければ登録
                cbAuthor.Items.Add(author);
            }
        }

        private void setCbCarName(string carname) {
            if (!cbCarName.Items.Contains(carname)) {
                //まだ登録されていなければ登録
                cbCarName.Items.Add(carname);
            }
        }

        private void ColorToolStripMenuItem(object sender, EventArgs e) {
            if(ColorSelect.ShowDialog() == DialogResult.OK) {
                //背景色の設定、settingsに設定
                BackColor = ColorSelect.Color;
                settings.MainFormColor = ColorSelect.Color.ToArgb();
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202206DataSet.CarReportDB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill(this.infosys202206DataSet.CarReportDB);
            EnabledCheck();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //using (var writer = XmlWriter.Create("settings.xml")) {
            //    var serializer = new XmlSerializer(settings.GetType());
            //    serializer.Serialize(writer, settings);
            //}
        }

        private void carReportDBBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202206DataSet);
        }

        private void btSizeImageChange_Click(object sender, EventArgs e) {
            if (pbPicture.SizeMode == PictureBoxSizeMode.Zoom)
                pbPicture.SizeMode = PictureBoxSizeMode.Normal;
            else
                pbPicture.SizeMode++;

            //pbPicture.SizeMode = pbPicture.SizeMode == PictureBoxSizeMode.Zoom　? pbPicture.SizeMode++ : PictureBoxSizeMode.Normal;
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

        private void carReportDBDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {
        }
        private void carReportDBDataGridView_Click(object sender, EventArgs e) {
            var cur = carReportDBDataGridView.CurrentRow;
            if (cur == null)
                return;
            dtpDate.Text = cur.Cells[1].Value.ToString();
            cbAuthor.Text = cur.Cells[2].Value.ToString();
            setMakerGroup();
            cbCarName.Text = cur.Cells[4].Value.ToString();
            tbReport.Text = cur.Cells[5].Value.ToString();
            if (!cur.Cells[6].Value.Equals(DBNull.Value))
                pbPicture.Image = ByteArrayToImage((byte[])cur.Cells[6].Value);
            else
                pbPicture.Image = null;
        }
    }
}
