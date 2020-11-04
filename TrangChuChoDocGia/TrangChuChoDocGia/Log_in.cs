using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDG;
using QuanLyKho;
namespace  Trang_Chu
{
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
            
            
        }
        /// 
        /// 
        /// Xử lý thông tin và mật khẩu
        /// 
        /// 
        private void Dang_nhap_button_Click(object sender, EventArgs e)
        {
            bool check = false;
            QuanLyTV cmd = new QuanLyTV();
            TaiKhoanNV x = new TaiKhoanNV();
            var ds = from tmp in cmd.TaiKhoanNVs select tmp;
            foreach (var item in ds)
            {
               // MessageBox.Show("đâsd");
                if (item.TenDN == User_name.Text && item.MatKhau == Pass_word.Text)
                {
                    check = true;
                    HoSo nv = cmd.HoSoes.SingleOrDefault(p => p.MaNV == item.MaNV);
                    if (nv.BoPhan == "Thủ thư")
                    {
                        QLDG.QLDG qldg = new QLDG.QLDG();
                        qldg.NV = nv.MaNV;
                        this.Hide();
                        qldg.ShowDialog();
                        this.Show();
                    }
                    else if (nv.BoPhan == "Thủ kho")
                    {
                        QuanLyKho.QuanLyKho qlk = new QuanLyKho.QuanLyKho();
                        qlk.Mathukho = nv.MaNV;
                        this.Hide();
                        qlk.ShowDialog();
                        this.Show();
                    }
                    else if(nv.BoPhan=="Thủ trưởng")
                    {
                        FormThuTruong.ThuTruong boss = new FormThuTruong.ThuTruong();
                        boss.NV = nv.MaNV;
                        this.Hide();
                        boss.ShowDialog();
                        this.Show();
                    }
                }
            }

            if (!check)
            {
                MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User_name.Text = "";
                Pass_word.Text = "";
                User_name.Focus();
            }
        }
    }
}
