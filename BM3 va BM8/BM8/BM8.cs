using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BM8
{
    public partial class BM8 : Form
    {
        public BM8()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }
        DateTime MS_ngayghinhan;
        string MS_tendocgia,MS_nguoighinhan,MS_tensach;
        decimal MS_tienphat;

        private void BM8_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                AutoValidate = AutoValidate.Disable;
                this.Close();
            }
        }

        private void MS_ngay_ghi_nhan_Validating(object sender, CancelEventArgs e)
        {
            if (DateTime.TryParseExact(MS_ngay_ghi_nhan.Text, "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out MS_ngayghinhan) && MS_ngay_ghi_nhan.Text.Length != 0)
            {
                e.Cancel = false;
                errorProvider1.SetError(MS_ngay_ghi_nhan, null);
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(MS_ngay_ghi_nhan, "Vui lòng nhập ngày mất sách");
            }
        }

        private void Xac_nhan_button_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MS_tendocgia = MS_ten_doc_gia.Text;
                MS_tienphat = Convert.ToDecimal(MS_tien_phat.Text);
                MS_tensach = MS_ten_sach.Text;
                MS_nguoighinhan = MS_nguoi_ghi_nhan.Text;
                MessageBox.Show("Xác nhận thành công");
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
