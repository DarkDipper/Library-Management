using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Diagnostics.SymbolStore;

namespace BM3
{
    public partial class BM3 : Form
    {
        int x=1;
        public BM3()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }
        //string[] type = { "Hành động và phiêu lưu","Cổ điển","Sách hình","Trinh thám","Viễn tưởng","Lịch sử","Kinh dị","Văn học","Lãng mạn","Khoa học" };
        string tensach,theloai,nguoinhan,tacgia;
        int namxb;
        decimal trigia;
        private void nam_xb_Validating(object sender, CancelEventArgs e)
        {
            if (Int32.TryParse(nam_xb.Text, out int x))
            {
                if ( DateTime.Now.Year - x <= 8&&DateTime.Now.Year>=x)
                {
                    e.Cancel = false;
                    errorProvider1.SetError(nam_xb, null);
                }
                else
                {
                    e.Cancel= true;
                    errorProvider1.SetError(nam_xb, "Yêu cầu sách xuất bản trong 8 năm đổi lại");
                }
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(nam_xb, "Vui lòng nhập năm");
            }
        }
        private void Tac_gia_Validating(object sender, CancelEventArgs e)
        {
            if (!Only_letter(Tac_gia.Text)||Tac_gia.Text.Length==0)
            {
                e.Cancel = true;
                errorProvider1.SetError(Tac_gia, "Vui lòng nhập đúng yêu cầu");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Tac_gia, null);
            }
        }
        private void nha_xb_Validating(object sender, CancelEventArgs e)
        {
            if (!Only_letter(nha_xb.Text)||nha_xb.Text.Length==0)
            {
                e.Cancel = true;
                errorProvider1.SetError(nha_xb, "Vui lòng nhập đúng yêu cầu");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(nha_xb, null);
            }
        }
        private void the_loai_Validating(object sender, CancelEventArgs e)
        {
            if (Only_letter(the_loai.Text)&&the_loai.Text.Length!=0)
            { 
                e.Cancel = false;
                errorProvider1.SetError(the_loai, null);
                
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(the_loai, "Vui lòng chọn thể loại");
            }
        }
        private void ten_sach_Validating(object sender, CancelEventArgs e)
        {
            if (ten_sach.Text.Length == 0)
            {
                
                e.Cancel = true;
                errorProvider1.SetError(ten_sach, "Vui lòng nhập tên sách");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(ten_sach, null);
            }
        }

        private void tri_gia_Validating(object sender, CancelEventArgs e)
        {
            string[] part = tri_gia.Text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            if (part.Length != 2)
            {
                e.Cancel = true;
                errorProvider1.SetError(dong, "Vui lòng nhập đúng yêu cầu");
            }
            else
            {
                if (part[1] != "đồng")
                {
                    e.Cancel = true;
                    errorProvider1.SetError(dong,"Đơn vị tiền tệ là đồng");
                }
                else if(!decimal.TryParse(part[0],out decimal x))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(dong, "Không định dạng được giá trị");
                }
                else
                {
                    trigia = x;
                    e.Cancel = false;
                    errorProvider1.SetError(tri_gia, null);
                }
            }
        }
        public bool Only_letter(string x)
        {
            char[] DS = { '\'','\\',',','.','/','<','>',';',':','\"','{','[','}',']',
                          '~','`','!','@','#','$','%','^','&','*','(',')','-','_','+','=',};
            for(int i = 0; i < x.Length; i++)
            {
                if (DS.Contains(x[i]))
                {
                    return false;
                }
                else if(Int32.TryParse(x[i].ToString(),out int y))
                {
                    return false;
                }
            }
            return true;
        }

        private void ngay_nhan_Validating(object sender, CancelEventArgs e)
        {

            if (DateTime.TryParseExact(ngay_nhan.Text, "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaynhan) && ngay_nhan.Text.Length!=0)
            {
                e.Cancel = false;
                errorProvider1.SetError(ngay_nhan,null);
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(ngay_nhan, "Vui lòng nhập ngày nhập");
            }
        }

        private void nguoi_nhan_Validating(object sender, CancelEventArgs e)
        {
            if (!Only_letter(nguoi_nhan.Text)||nguoi_nhan.Text.Length==0)
            {
                //e.Cancel = true;
                errorProvider1.SetError(nguoi_nhan, "Không định dạng được người nhận");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(nguoi_nhan, null);
            }
        }

        private void BM3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
                AutoValidate = AutoValidate.Disable;
                this.Close();
            }
        }


        DateTime ngaynhan;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                
                tensach = ten_sach.Text;
                theloai = the_loai.Text;
                nguoinhan = nguoi_nhan.Text;
                tacgia = Tac_gia.Text;
                namxb = Convert.ToInt32(nam_xb.Text);
                //ngaynhan = DateTime.ParseExact(ngay_nhan.Text, "d/M/yyyy", CultureInfo.InvariantCulture);
                MessageBox.Show(ngaynhan.ToString("dd/MM/yyyy"));
                //DateTime.TryParseExact(ngay_nhan.Text, "d/M/yyyy",CultureInfo.InvariantCulture,DateTimeStyles.None,out ngaynhan);
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
        
    }
}
