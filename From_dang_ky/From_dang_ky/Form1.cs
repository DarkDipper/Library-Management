using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                
            }
        }

        public Form_DangKy()
        {
            InitializeComponent();
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
            if (!Only_letter(txt_Hoten.Text) || txt_Hoten.Text.Length == 0)
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
    }
}
