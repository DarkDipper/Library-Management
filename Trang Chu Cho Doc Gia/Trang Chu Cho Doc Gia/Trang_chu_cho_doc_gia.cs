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
            panel_TraCuuSach.Visible = false;
            Turn_off_Sach();
        }

        private void buttonTra_cuu_sach_Click(object sender, EventArgs e)
        {
            //panel_TraCuuSach.Parent=
            Thay_doi_trang_thai_nut(buttonTra_cuu_sach);
            Panel_UserInformation.Visible = false;
            panel_TraCuuSach.Visible = true;
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
        QuanLyThuVien qltv = new QuanLyThuVien();
        private void button_TraCuu_Click(object sender, EventArgs e)
        {
            listSach.Items.Clear();
            if (textTraCuuSach.Text.Length != 0)
            {
                var DS = from A in qltv.DanhSachSaches where A.TenSach.Contains(textTraCuuSach.Text) select A;
                foreach (var B in DS)
                {
                    listSach.Items.Add(B.TenSach);
                }
            }else if (textTraCuuSach.Text.Length == 0)
            {
                Turn_off_Sach();
            }
        }
        public void Turn_off_Sach()
        {
            textTraCuuSach.Text = "";
            labelTenSach.Visible = false;
            labelTacGia.Visible = false;
            labelLoai.Visible = false;
            labelNamXB.Visible = false;
            labelNhaXB.Visible = false;
            labelTinhTrang.Visible = false;
            listSach.Items.Clear();

        }
        private void listSach_DoubleClick(object sender, EventArgs e)
        {
            var DS = from A in qltv.DanhSachSaches where A.TenSach == listSach.SelectedItem.ToString() select A;
            try
            {
                foreach (var B in DS)
                {
                    labelTenSach.Text = "Tên Sách: " + B.TenSach.ToString();
                    labelTacGia.Text = "Tác Giả: " + B.TacGia.ToString();
                    labelLoai.Text = "Loại: " + B.TheLoai.ToString();
                    labelNamXB.Text = "Năm xuất bản: " + B.NamXuatBan.ToString();
                    labelNhaXB.Text = "Nhà xuất bản: " + B.NhaXuatBan.ToString();
                    labelTinhTrang.Text = "Tình trạng: " + B.TinhTrang.ToString();

                }
                labelTenSach.Visible = true;
                labelTacGia.Visible = true;
                labelLoai.Visible = true;
                labelNamXB.Visible = true;
                labelNhaXB.Visible = true;
                labelTinhTrang.Visible = true;
            }
            catch
            {

            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (panel_TraCuuSach.ContainsFocus)
                {
                    button_TraCuu.PerformClick();
                    return true;
                }
            }
            return base.ProcessDialogKey(keyData);
        }

    }
}
