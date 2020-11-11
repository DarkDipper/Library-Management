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

namespace WindowsFormsApp4
{
    public partial class ThongtinThuquy : Form
    {
        public ThongtinThuquy()
        {
            InitializeComponent();
        }
        QuanLyTV qltv = new QuanLyTV();
        public string nv = "E.004";
        private void ThongtinThuquy_Load(object sender, EventArgs e)
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
            tt_dienthoai.Enabled = true;
            LuuThayDoi.Enabled = true;
        }
        bool mk = false;
        bool dt = false;

        private void tt_Matkhau_Leave(object sender, EventArgs e)
        {
            if (tt_Matkhau.Text.Length == 0)
            {
                Tick.Clear();
                errorProvider1.SetError(this.tt_Matkhau, "Bạn chưa nhập mật khẩu! ");
                mk = false;
            }
            else if (tt_Matkhau.Text.Length < 9)
            {
                Tick.Clear();
                errorProvider1.SetError(tt_Matkhau, "Mật khẩu quá ngắn");
                mk = false;
            }
            else if (Regex.IsMatch(tt_Matkhau.Text, "^[!-~]*$"))
            {
                errorProvider1.Clear();
                Tick.SetError(tt_Matkhau, "xong");
                mk = true;
            }
            else
            {
                Tick.Clear();
                errorProvider1.SetError(tt_Matkhau, "Không đúng dữ liệu nhập");
                mk = false;
            }
        }

        private void tt_dienthoai_Leave(object sender, EventArgs e)
        {
            if (tt_dienthoai.Text.Length == 10)
            {
                if (tt_dienthoai.Text[0] == '0')
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (!(48 <= (int)tt_dienthoai.Text[i] && (int)tt_dienthoai.Text[i] <= 57))
                        {
                            Tick.Clear();
                            errorProvider1.SetError(tt_dienthoai, "Có ký tự không phải số trong số điện thoại");
                            dt = false;
                            return;
                        }
                    }
                }
                else
                {
                    Tick.Clear();
                    errorProvider1.SetError(tt_dienthoai, "Số điện thoại phải bắt đầu số 0 ");
                    dt = false;
                }
                errorProvider1.Clear();
                Tick.SetError(tt_dienthoai, "Xong");
                dt = true;
            }
            else
            {
                Tick.Clear();
                errorProvider1.SetError(tt_dienthoai, "Số điện thoại không đủ 10 chữ số");
                dt = false;
            }
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LuuThayDoi_Click(object sender, EventArgs e)
        {
            if ( mk == true && dt == true)
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

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void groupBox15_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
