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

namespace AddressBook {
    public partial class Form1 : Form {
        //住所データ管理用リスト
        BindingList<Person> listPerson = new BindingList<Person>();

        public Form1() {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
        }

        private void btAddPerson_Click(object sender, EventArgs e) {
            if (String.IsNullOrWhiteSpace(tbName.Text)) {
                MessageBox.Show("氏名が入力されていません");
                return;
            }else {
                Person newPerson = new Person {
                    Name = tbName.Text,
                    MailAddress = tbMailAddress.Text,
                    Address = tbAddress.Text,
                    Company = cbCompany.Text,
                    Picture = pbPicture.Image,
                    listGroup = GetCheckBoxGroup(),
                    Registration = dtpRegistDate.Value,
                    KindNumber = GetRBKindNumber(),
                    TellNumber = tbTelNumber.Text,
                };
                listPerson.Add(newPerson);
                this.dgvPersons.CurrentCell = this.dgvPersons[0, listPerson.Count - 1];
                EnabledCheck();
                //コンボボックスに会社名を登録
                setCbCompany(cbCompany.Text);
                tbNull();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e) {
            if (dgvPersons.CurrentRow == null) return;
            int index = dgvPersons.CurrentCell.RowIndex;

            if (String.IsNullOrWhiteSpace(tbName.Text)) {
                MessageBox.Show("氏名が入力されていません");
                return;
            }
            else {
                listPerson[index].Name = tbName.Text;
                listPerson[index].MailAddress = tbMailAddress.Text;
                listPerson[index].Address = tbAddress.Text;
                listPerson[index].Company = cbCompany.Text;
                listPerson[index].Picture = pbPicture.Image;
                listPerson[index].listGroup = GetCheckBoxGroup();
                listPerson[index].Registration = dtpRegistDate.Value;
                listPerson[index].KindNumber = GetRBKindNumber();
                listPerson[index].TellNumber = tbTelNumber.Text;
            }
            dgvPersons.Refresh();
        }

        private void btdelete_Click(object sender, EventArgs e) {
            if (dgvPersons.CurrentRow == null) return;
            int index = dgvPersons.CurrentCell.RowIndex;

            listPerson.RemoveAt(index);
            EnabledCheck();
            if (dgvPersons.CurrentRow == null) {
                tbNull();
                CheckBoxClear();
            }
            else {
                //消した後にindexをとってくる
                index = dgvPersons.CurrentCell.RowIndex;
                tbName.Text = listPerson[index].Name;
                tbMailAddress.Text = listPerson[index].MailAddress;
                tbAddress.Text = listPerson[index].Address;
                cbCompany.Text = listPerson[index].Company;
                pbPicture.Image = listPerson[index].Picture;
                tbTelNumber.Text = listPerson[index].TellNumber;
                KindNumberCheck(index);
                setGroupType(index);
            }
            dgvPersons.Refresh();
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
                        bf.Serialize(fs, listPerson);
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
                        listPerson = (BindingList<Person>)bf.Deserialize(fs);
                        dgvPersons.DataSource = null;
                        dgvPersons.DataSource = listPerson;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                cbCompany.Items.Clear();//コンボボックスのアイテム削除
                foreach (var company in listPerson.Select(p => p.Company)) {
                    setCbCompany(company);//存在する会社を登録
                }
            }
            EnabledCheck();
        }

        //データグリッドビューをクリックしたときのイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e) {
            //選択されているインデックスを取得する
            if (dgvPersons.CurrentRow == null) return;

            int index = dgvPersons.CurrentCell.RowIndex;
            //各リストの項目をテキストボックスへ表示する
            tbName.Text = listPerson[index].Name;
            tbMailAddress.Text = listPerson[index].MailAddress;
            tbAddress.Text = listPerson[index].Address;
            cbCompany.Text = listPerson[index].Company;
            pbPicture.Image = listPerson[index].Picture;
            dtpRegistDate.Value = listPerson[index].Registration.Year > 1900 ?
            listPerson[index].Registration : DateTime.Today;
            tbTelNumber.Text = listPerson[index].TellNumber;

            KindNumberCheck(index);
            setGroupType(index);
        }

        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.GroupType> GetCheckBoxGroup() {
            var listGroup = new List<Person.GroupType>();
            if (cbFamily.Checked)
                listGroup.Add(Person.GroupType.家族);
            if (cbFriend.Checked)
                listGroup.Add(Person.GroupType.友人);
            if (cbWork.Checked)
                listGroup.Add(Person.GroupType.仕事);
            if (cbOther.Checked)
                listGroup.Add(Person.GroupType.その他);
            return listGroup;
        }

        private void CheckBoxClear() {
            cbFamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;
        }

        private void setGroupType(int index) {
            CheckBoxClear();
            foreach (var group in listPerson[index].listGroup) {
                switch (group) {
                    case Person.GroupType.家族:
                        cbFamily.Checked = true;
                        break;
                    case Person.GroupType.友人:
                        cbFriend.Checked = true;
                        break;
                    case Person.GroupType.仕事:
                        cbWork.Checked = true;
                        break;
                    case Person.GroupType.その他:
                        cbOther.Checked = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private Person.KindNumberType GetRBKindNumber() {
            Person.KindNumberType selectedKindNumber = Person.KindNumberType.その他;
            if (rbHome.Checked)
                selectedKindNumber = Person.KindNumberType.自宅;
            if (rbMobile.Checked)
                selectedKindNumber = Person.KindNumberType.携帯;
            return selectedKindNumber;

        }

        private void KindNumberCheck(int index) {
            switch (listPerson[index].KindNumber) {
                case Person.KindNumberType.自宅:
                    rbHome.Checked = true;
                    break;
                case Person.KindNumberType.携帯:
                    rbMobile.Checked = true;
                    break;
                case Person.KindNumberType.その他:
                    break;
                default:
                    break;
            } 
        }

        private void tbNull() {
            tbName.Text = null;
            tbMailAddress.Text = null;
            tbAddress.Text = null;
            cbCompany.Text = null;
            pbPicture.Image = null;
            tbTelNumber.Text = null;
            CheckBoxClear();
        }

        private void setCbCompany(string company) {
            if (!cbCompany.Items.Contains(company)) {
                //まだ登録されていなければ登録
                cbCompany.Items.Add(company);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {   
            EnabledCheck();  
        }

        private void EnabledCheck() {
            //三項条件演算子
            btDelete.Enabled = btUpdate.Enabled = listPerson.Count() > 0 ? true : false;
        }
    }
}