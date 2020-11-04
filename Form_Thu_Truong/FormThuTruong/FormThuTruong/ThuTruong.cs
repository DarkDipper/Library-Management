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
        QuanLyTV cmd = new QuanLyTV();
        public ThuTruong()
        {
            InitializeComponent();
        }
        public string NV;
        private void Form1_Load(object sender, EventArgs e)
        {
            label_Sach.Text = cmd.DanhSachSaches.Count().ToString()+"/50";
            circularProgressBar_SACH.Value = cmd.DanhSachSaches.Count();
        }

        private void button_NhanVien_Click(object sender, EventArgs e)
        {
            Form_Danh_Sach_Nhan_Vien.DanhSachNhanVien x = new Form_Danh_Sach_Nhan_Vien.DanhSachNhanVien();
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
    }
}
