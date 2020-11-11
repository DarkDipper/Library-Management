using QuanLyKho;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FormThuTruong
{
    public partial class ThuTruong : Form
    {
        public ThuTruong()
        {
            InitializeComponent();
        }
        public string NV="E.003";
        QuanLyTV qltv = new QuanLyTV();
        private void Form1_Load(object sender, EventArgs e)
        {
            int x = qltv.TheDocGias.Count();
            circularProgressBar_DG.Value = x;
            circularProgressBar_DG.SuperscriptText =x.ToString() + " %";
            //MessageBox.Show($"dg {x.ToString()}");
            int y = qltv.DanhSachSaches.Count();
            circularProgressBar_SACH.Value =y;
            circularProgressBar_SACH.SuperscriptText=y.ToString() + " %";
            //MessageBox.Show($"sACH {y.ToString()}");
        }

        private void button_NhanVien_Click(object sender, EventArgs e)
        {
            NhanVien x = new NhanVien();
            this.Hide();
            x.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            QLDG.QLDG x = new QLDG.QLDG();
            x.check = true;
            x.NV = NV;
            this.Hide();
            x.ShowDialog();
            this.Show();
        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            From_dang_ky.Form_DangKy x = new From_dang_ky.Form_DangKy();
            this.Hide();
            x.ShowDialog();
            this.Show();
        }

        private void button_ThongTinCaNhan_Click(object sender, EventArgs e)
        {
            CaNhan x = new CaNhan();
            x.nv = NV;
            this.Hide();
            x.ShowDialog();
            this.Show();
        }

        private void button_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Sach_Click(object sender, EventArgs e)
        {
            QuanLyKho.QuanLyKho x = new QuanLyKho.QuanLyKho();
            x.Mathukho = NV;
            x.check = true;
            this.Hide();
            x.ShowDialog();
            this.Show();
        }

        private void button_TaiChinh_Click(object sender, EventArgs e)
        {
            WindowsFormsApp4.ThuQuy x = new WindowsFormsApp4.ThuQuy();
            x.NV = NV;
            x.check = true;
            this.Hide();
            x.ShowDialog();
            this.Show();
        }

        private void button_BaoCao_Click(object sender, EventArgs e)
        {
            BaoCao x = new BaoCao();
            this.Hide();
            x.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
    }
}
