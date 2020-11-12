using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormThuTruong
{
    public partial class CaNhan : Form
    {
        public CaNhan()
        {
            InitializeComponent();
        }
        public string nv="E.001";
        QuanLyTV qltv = new QuanLyTV();
        private void CaNhan_Load(object sender, EventArgs e)
        {
            HoSo x = qltv.HoSoes.SingleOrDefault(p => p.MaNV == nv);
            tt_Ten.Text = x.HoTen;
            tt_ngaysinh.Text = x.NgaySinh.Value.ToString("dd/MM/yyyy");
            tt_diachi.Text = x.DiaChi;
            tt_dienthoai.Text = x.DienThoai;
            tt_bangcap.Text = x.BangCap;
            tt_nlv.Text = x.NgayLamViec.Value.ToString("dd/MM/yyyy");
            TaiKhoanNV y = qltv.TaiKhoanNVs.SingleOrDefault(p => p.MaNV == nv);
            tt_tenDN.Text = y.TenDN;
            tt_Matkhau.Text = y.MatKhau;
            tt_mnv.Text = y.MaNV;
            tt_tenDN.Enabled = true;
            tt_Matkhau.Enabled = true;
            LuuThayDoi.Enabled = true;
        }
        bool mk = false;
        private void DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tt_Matkhau_Leave(object sender, EventArgs e)
        {
            if (tt_Matkhau.Text.Length == 0)
            {
                Tick.Clear();
                er.SetError(this.tt_Matkhau, "Bạn chưa nhập mật khẩu! ");
                mk = false;
            }
            else if (tt_Matkhau.Text.Length < 9)
            {
                Tick.Clear();
                er.SetError(tt_Matkhau, "Mật khẩu quá ngắn");
                mk = false;
            }
            else if (Regex.IsMatch(tt_Matkhau.Text, "^[!-~]*$"))
            {
                er.Clear();
                Tick.SetError(tt_Matkhau, "xong");
                mk = true;
            }
            else
            {
                Tick.Clear();
                er.SetError(tt_Matkhau, "Không đúng dữ liệu nhập");
                mk = false;
            }
        }

        private void LuuThayDoi_Click(object sender, EventArgs e)
        {
            if (mk == true)
            {
                TaiKhoanNV x = qltv.TaiKhoanNVs.SingleOrDefault(p => p.MaNV == nv);
                x.TenDN = tt_tenDN.Text;
                x.MatKhau = tt_Matkhau.Text;
                qltv.TaiKhoanNVs.AddOrUpdate(x);
                qltv.SaveChanges();
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
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
