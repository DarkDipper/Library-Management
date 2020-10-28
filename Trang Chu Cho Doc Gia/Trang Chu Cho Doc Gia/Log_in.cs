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
            QuanLyThuVien cmd=new QuanLyThuVien();
            if (List.SelectedItem== "Độc giả")
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
                    else
                    {
                        MessageBox.Show(tmp.MatKhau);
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
        }

        
    }
}
