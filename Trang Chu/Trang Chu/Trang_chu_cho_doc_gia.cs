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
        private Button btn;
        public Trang_chu_cho_doc_gia()
        {
            InitializeComponent();
        }
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
                btn.BackColor = Color.Peru;
            }
        }
        private void button_xem_thong_tin_Click(object sender, EventArgs e)
        {
            Thay_doi_trang_thai_nut(button_xem_thong_tin);    
        }

        private void buttonTra_cuu_sach_Click(object sender, EventArgs e)
        {
            Thay_doi_trang_thai_nut(buttonTra_cuu_sach);
        }

        private void button_dang_xuat_Click(object sender, EventArgs e)
        {
            Thay_doi_trang_thai_nut(button_dang_xuat);
        }

        
    }
}
