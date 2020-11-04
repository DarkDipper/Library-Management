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
            double x = qltv.TheDocGias.Count();
            circularProgressBar_DG.Value = (int)(x * 0.2);
            circularProgressBar_DG.SuperscriptText = (double.Parse((x * 0.2).ToString())).ToString() + " %";
            //MessageBox.Show($"dg {x.ToString()}");
            double y = qltv.DanhSachSaches.Count();
            circularProgressBar_SACH.Value = (int)(x * 0.2);
            circularProgressBar_SACH.SuperscriptText= (double.Parse((y * 0.2).ToString())).ToString() + " %";
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
    }
}
