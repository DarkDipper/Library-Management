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

namespace From_dang_ky
{
    public partial class Form_DangKy : Form
    {
        string HoTen, BangCap, BoPhan, SDT,DiaChi;
        DateTime NgaySinh;
        QuanLyTV quanLy = new QuanLyTV();
        int k = 0;
        int t = 0; 
        private void DatePick_NgaySinh_Validating(object sender, CancelEventArgs e)
        {
            if (DateTime.Now.Year - DatePick_NgaySinh.Value.Year < 18)
            {
                Check.SetError(DatePick_NgaySinh, "Dưới 18 tuổi");
                e.Cancel = true;
            }
            else
            {
                Check.Clear();
                e.Cancel = false;
            }
        }

        private void combo_BangCap_Validating(object sender, CancelEventArgs e)
        {
            if(combo_BangCap.Text=="Tú tài"||combo_BangCap.Text=="Trung cấp"|| combo_BangCap.Text == "Cao đẳng"|| combo_BangCap.Text == "Đại học"|| combo_BangCap.Text == "Thạc sĩ"|| combo_BangCap.Text == "Tiến sĩ")
            {
                Check.Clear();
                e.Cancel = false;
            }
            else
            {
                Check.SetError(combo_BangCap, "Bằng cấp này không tồn tại!");
                e.Cancel = true;
            }
        }

        private void combo_Bophan_Validating(object sender, CancelEventArgs e)
        {
            if(combo_Bophan.Text=="Thủ thư"|| combo_Bophan.Text == "Thủ kho"|| combo_Bophan.Text == "Thủ quỹ")
            {
                Check.Clear();
                e.Cancel = false;
            }
            else
            {
                Check.SetError(combo_Bophan, "Bộ phận này không tồn tại!");
                e.Cancel = true;
            }
        }

        private void txtSDT_Validating(object sender, CancelEventArgs e)
        {
            if (txtSDT.Text.Length == 10)
            {
                if (txtSDT.Text[0] == '0')
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (!(48 <= (int)txtSDT.Text[i] && (int)txtSDT.Text[i] <= 57))
                        {
                            Check.SetError(txtSDT, "Có ký tự không phải số trong số điện thoại");
                            e.Cancel = true;
                            return;
                        }
                    }
                }
                else
                {
                    Check.SetError(txtSDT, "Số điện thoại phải bắt đầu số 0 ");
                    e.Cancel = true;
                }
                Check.Clear();
                e.Cancel = false;
            }
            else
            {
                Check.SetError(txtSDT, "Số điện thoại không đủ 10 chữ số");
                e.Cancel = true;
            }
        }

        private void combo_Bophan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_DangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            AutoValidate = AutoValidate.Disable;
            CausesValidation = false;
        }

        private void Button_X_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            CausesValidation = false;
            this.Close();
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

        private void Button_Minisize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                HoTen = txt_Hoten.Text;
                NgaySinh = DatePick_NgaySinh.Value;
                DiaChi = txt_DiaChi.Text;
                BangCap = combo_BangCap.Text;
                BoPhan = combo_Bophan.Text;
                SDT = txtSDT.Text;
                var hs = from i in quanLy.HoSoes select i;
                foreach(var i in hs)
                {
                    string chuoi_so = i.MaNV.Substring(2);
                    int so = int.Parse($"{chuoi_so}");
                    if (so != k) break;
                    else k++;
                }
                var tk = from i in quanLy.TaiKhoanNVs select i;
                foreach (var i in tk)
                {
                    string chuoi_so = i.TenDN.Substring(8);
                    int so = int.Parse($"{chuoi_so}");
                    if (so != t) break;
                    else t++;
                }
                TaiKhoanNV taiKhoan = new TaiKhoanNV();
                taiKhoan.MaNV = TaoMA();
                taiKhoan.TenDN = TaoMANV();
                taiKhoan.MatKhau = "123";
                quanLy.TaiKhoanNVs.AddOrUpdate(taiKhoan);
                HoSo hoSo = new HoSo();
                hoSo.MaNV = TaoMA();
                hoSo.HoTen = HoTen;
                hoSo.NgaySinh = NgaySinh;
                hoSo.DiaChi = DiaChi;
                hoSo.BangCap = BangCap;
                hoSo.BoPhan = BoPhan;
                hoSo.DienThoai = SDT;
                hoSo.NgayLamViec = DateTime.Today;
                quanLy.HoSoes.AddOrUpdate(hoSo);
                MessageBox.Show($"Đăng kí thành công với Tên đăng nhập là :\"{TaoMANV()}\" và Mật khẩu là :\"123\"", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                quanLy.SaveChanges();
                txt_Hoten.Text="";
                DatePick_NgaySinh.Value = DateTime.Today;
                txt_DiaChi.Text="";
                combo_BangCap.SelectedIndex=-1;
                combo_Bophan.SelectedIndex=-1;
                txtSDT.Text = "";
            }
            else
            {
                MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Form_DangKy()
        {
            InitializeComponent();
            
        }

        private void txt_DiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (txt_DiaChi.Text == "")
            {
                e.Cancel = true;
                Check.SetError(txt_Hoten, "Sai dữ liệu đầu vào!");
            }
            else
            {
                e.Cancel = false;
                Check.SetError(txt_Hoten, null);
            }
        }

        public string TaoMA()
        {
            if (k < 10) return $"E.00{k.ToString()}";
            else if (k < 100) return $"E.0{k.ToString()}";
            else return $"E.{k.ToString()}";
        }
        public string TaoMANV()
        {
            if (k < 10) return $"nhanvien0{k.ToString()}";
            else return $"nhanvien{k.ToString()}";
        }
        public bool Only_letter(string x)
        {
            char[] DS = { '\'','\\',',','.','/','<','>',';',':','\"','{','[','}',']',
                          '~','`','!','@','#','$','%','^','&','*','(',')','-','_','+','=',};
            for (int i = 0; i < x.Length; i++)
            {
                if (DS.Contains(x[i]))
                {
                    return false;
                }
                else if (Int32.TryParse(x[i].ToString(), out int y))
                {
                    return false;
                }
            }
            return true;
        }
        private void txt_Hoten_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txt_Hoten.Text.Length != 0)
                {
                    char[] trimChars = { '\\', '|', '\'', ' ', '@', ' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '_', '+', '[', '{', ']', '}', ';', ':', '"', ',', '<', '.', '>', '/', '?' };
                    txt_Hoten.Text = txt_Hoten.Text.Trim(trimChars);
                    int slc = 0;
                    bool c = false;
                    for (int i = 0; i < txt_Hoten.Text.Length; i++)
                    {
                        if (txt_Hoten.Text[i] >= 33 && txt_Hoten.Text[i] <= 57 || txt_Hoten.Text[i] >= 58 && txt_Hoten.Text[i] <= 64 || txt_Hoten.Text[i] >= 91 && txt_Hoten.Text[i] <= 96 || txt_Hoten.Text[i] >= 123 && txt_Hoten.Text[i] <= 126)
                        {
                            txt_Hoten.Text = txt_Hoten.Text.Remove(i, 1);
                            i = -1;
                        }
                    }
                    for (int i = 0; i < txt_Hoten.Text.Length; i++)
                    {
                        if (c != true && txt_Hoten.Text[i] >= 'a' && txt_Hoten.Text[i] <= 'z' || c != true && txt_Hoten.Text[i] >= 'A' && txt_Hoten.Text[i] <= 'Z')
                        {
                            slc++;
                            c = true;
                        }
                        if (txt_Hoten.Text[i] == ' ' && c == true)
                        {
                            c = false;
                        }
                    }
                    for (int i = 0; i < txt_Hoten.Text.Length; i++)
                    {
                        if (txt_Hoten.Text[i] == ' ' && txt_Hoten.Text[i + 1] == ' ')
                        {
                            txt_Hoten.Text = txt_Hoten.Text.Remove(i, 1);
                        }
                    }
                    c = false;
                    string x = "";
                    string xx = "";
                    for (int i = 0; i < txt_Hoten.Text.Length; i++)
                    {
                        if (c == false && txt_Hoten.Text[i] >= 127 || c == false && txt_Hoten.Text[i] >= 'a' && txt_Hoten.Text[i] <= 'z' || c == false && txt_Hoten.Text[i] >= 'A' && txt_Hoten.Text[i] <= 'Z')
                        {
                            x += txt_Hoten.Text[i];
                        }
                        if (txt_Hoten.Text[i] == ' ')
                        {
                            c = true;
                        }
                        if (c == true || i + 1 == txt_Hoten.Text.Length)
                        {
                            x = x.Substring(0, 1).ToUpper() + x.Substring(1, x.Length - 1).ToLower();
                            slc--;
                            xx += x + " ";
                            x = "";
                            c = false;
                        }
                    }
                    txt_Hoten.Text = xx.Trim();
                }
                if (txt_Hoten.Text.Length == 0)
                {
                    Check.SetError(this.txt_Hoten, "Vui lòng nhập lại!!");
                    e.Cancel = true;
                }
                else
                {
                    Check.Clear();
                    e.Cancel = false;
                }
            }
            catch
            {
                
                Check.SetError(this.txt_Hoten, "Vui lòng nhập lại!");
                e.Cancel = true;
            }
        }
    }
}
