using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trang_Chu
{
    public partial class Trang_chu_cho_doc_gia : Form
    {
        TheDocGia DocGia = new TheDocGia();
        private Button btn;
        public Trang_chu_cho_doc_gia(TheDocGia BanDoc)
        {
            InitializeComponent();
            DocGia = BanDoc;
            
        }
        /// 
        /// Xử lý Giao diện
        /// 
        /// 
        private void Thay_doi_trang_thai_nut(object btnSender)
        {
            if (btnSender != null)
            {
                if (btn != (Button)btnSender)
                {
                    Quay_ve_trang_thai_nut_ban_dau();
                    btn = (Button)btnSender;
                    btn.TextImageRelation = TextImageRelation.TextBeforeImage;
                    btn.BackColor = Color.White;
                }
                
            }
        }
        private void Quay_ve_trang_thai_nut_ban_dau()
        {
            if (btn != null)
            {
                btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                btn.BackColor = Color.Transparent;
            }
        }
        /// 
        /// 
        /// Tạo và chỉnh sửa event
        /// 
        /// 
        private void button_xem_thong_tin_Click(object sender, EventArgs e)
        {
            Thay_doi_trang_thai_nut(button_xem_thong_tin);
            Panel_UserInformation.Visible = true;
        }

        private void buttonTra_cuu_sach_Click(object sender, EventArgs e)
        {
            Thay_doi_trang_thai_nut(buttonTra_cuu_sach);
        }

        private void button_dang_xuat_Click(object sender, EventArgs e)
        {
            Thay_doi_trang_thai_nut(button_dang_xuat);
        }

        private void Panel_UserInformation_VisibleChanged(object sender, EventArgs e)
        {
            MaSo.Text = "Mã Số: " + DocGia.MS;
            Ten_Dang_Nhap.Text = "Tên Đăng Nhập: " + DocGia.TenDN;
            HoVaTen.Text = "Họ và Tên: " + DocGia.HoTen;
            NgaySinh.Text = "Ngày Sinh: " + ((DateTime)DocGia.NgaySinh).ToString("dd/MM/yyyy");
            DiaChi.Text = "Địa Chỉ: " + DocGia.DiaChi;
            Email.Text = "Email: " + DocGia.Email;
            Loai.Text = "Loại: " + DocGia.Loai;
            
        }

    }
}
