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
        string x = "chào";
        private void Dang_nhap_button_Click(object sender, EventArgs e)
        {
            bool check = false;
            QuanLyTV cmd = new QuanLyTV();
            TaiKhoanNV x = new TaiKhoanNV();
            var ds = from tmp in cmd.TaiKhoanNVs select tmp;
            foreach (var item in ds)
            {
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
                }
            }
            if(!check) MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                /* if (List.SelectedIndex==0)
                 {
                     TheDocGia BanDoc = new TheDocGia();
                     var DS_DocGia = from tmp in cmd.TheDocGias select tmp;
                     foreach(var tmp in DS_DocGia)
                     {
                         if (tmp.TenDN == User_name.Text && tmp.MatKhau == Pass_word.Text)
                         {
                             check = true;
                             BanDoc = tmp;
                         }
                     }
                     if (check)
                     {
                         Trang_chu_cho_doc_gia x = new Trang_chu_cho_doc_gia(BanDoc);
                         x.ShowDialog();
                     }
                     else
                     {
                         MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }

                 }
                 else if(List.SelectedIndex==2)
                 {
                     QLDG.HoSo NV = new QLDG.HoSo();
                     var DS_NV = from tmp in cmd.HoSoes select tmp;
                     foreach (var tmp in DS_NV)
                     {
                         if (tmp.TenDN == User_name.Text && tmp.MatKhau == Pass_word.Text&&tmp.BoPhan==List.Text)
                         {
                             check = true;
                             NV.TenDN = tmp.TenDN;
                             NV.HoTen = tmp.HoTen;
                             NV.MaNV = tmp.MaNV;
                             NV.MatKhau = tmp.MatKhau;
                             NV.NgaySinh = tmp.NgaySinh;
                             NV.BangCap = tmp.BangCap;
                             NV.BoPhan = tmp.BoPhan;
                             NV.DiaChi = tmp.DiaChi;
                             NV.DienThoai = tmp.DienThoai;

                         }
                     }
                     if (check)
                     {
                         QLDG.QLDG x = new QLDG.QLDG();
                         x.NV = NV;
                         this.Hide();
                         x.ShowDialog();
                         this.Show();
                     }
                     else
                     {
                         MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                 }else if(List.SelectedIndex==3)
                 {
                     QLDG.HoSo NV = new QLDG.HoSo();
                     var DS_NV = from tmp in cmd.HoSoes select tmp;
                     foreach (var tmp in DS_NV)
                     {
                         if (tmp.TenDN == User_name.Text && tmp.MatKhau == Pass_word.Text&&tmp.BoPhan==List.Text)
                         {
                             check = true;
                             NV.TenDN = tmp.TenDN;
                             NV.HoTen = tmp.HoTen;
                             NV.MaNV = tmp.MaNV;
                             NV.MatKhau = tmp.MatKhau;
                             NV.NgaySinh = tmp.NgaySinh;
                             NV.BangCap = tmp.BangCap;
                             NV.BoPhan = tmp.BoPhan;
                             NV.DiaChi = tmp.DiaChi;
                             NV.DienThoai = tmp.DienThoai;

                         }
                     }
                     if (check)
                     {
                         QuanLyKho.QuanLyKho x = new QuanLyKho.QuanLyKho();
                         x.Mathukho = NV.MaNV;
                         this.Hide();
                         x.ShowDialog();
                         this.Show();
                     }
                     else
                     {
                         //MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         MessageBox.Show($"{NV.BoPhan} {List.SelectedItem}");
                     }
                 }
             }
     */
            }
    }
}
