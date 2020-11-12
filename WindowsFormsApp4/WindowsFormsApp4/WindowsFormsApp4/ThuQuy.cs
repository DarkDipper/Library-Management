using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class ThuQuy : Form
    {
        public ThuQuy()
        {
            InitializeComponent();
        }
        public string NV = "E.004";
        public bool check = false;
        QuanLyTV quanLy = new QuanLyTV();
        void LoadNo()
        {
            var x = from i in quanLy.TheDocGias where i.TongNo > 0 select i;
            foreach (var i in x) comboBox1.Items.Add(i.MS);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (check) button2.Enabled = false;
            LoadNo();
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text!="")
            {
                txtIn.Enabled = true;
                var x = quanLy.TheDocGias.SingleOrDefault(p => p.MS == comboBox1.Text);
                txtTenDG.Text = x.HoTen;
                txtTien.Text = (x.TongNo * 0.001).ToString();
                if (txtTien.Text == "0")
                {
                    txtIn.Enabled = false;
                    button1.Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var x = quanLy.TheDocGias.SingleOrDefault(p => p.MS == comboBox1.Text);
                var y = quanLy.HoSoes.SingleOrDefault(p => p.MaNV == NV);
                x.TongNo = int.Parse(txtConno.Text) * 1000;
                quanLy.TheDocGias.AddOrUpdate(x);
                quanLy.SaveChanges();
                MessageBox.Show("Đã trả nợ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Items.Clear();
                LoadNo();
                PhieuTraNo pn = new PhieuTraNo();
                pn.MS = x.MS;
                pn.Ten = txtTenDG.Text;
                pn.tienno = txtTien.Text;
                pn.tienthu = txtIn.Value.ToString();
                pn.conlai = txtConno.Text;
                pn.ngghinhan = y.HoTen;
                this.Hide();
                pn.ShowDialog();
                this.Show();
                //comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtConno.Text = "";
            txtIn.Value = 0;
            txtOut.Text = "";
            txtTenDG.Text = "";
            txtTien.Text = "";
            comboBox1.SelectedIndex = -1;
        }

        private void txtIn_Leave(object sender, EventArgs e)
        {
            if (int.Parse(txtTien.Text) > 0)
            {
                int a = int.Parse((txtIn.Value).ToString()) - int.Parse(txtTien.Text);
                int b = int.Parse(txtTien.Text) - int.Parse((txtIn.Value).ToString());
                if (a > 0) txtOut.Text = (a).ToString();
                else txtOut.Text = "0";
                if (b > 0) txtConno.Text = (b).ToString();
                else txtConno.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThongtinThuquy x = new ThongtinThuquy();
            x.nv = NV;
            this.Hide();
            x.ShowDialog();
            this.Show();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                //CausesValidation = false;
                AutoValidate = AutoValidate.Disable;
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void Button_X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Minisize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
