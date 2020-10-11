using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace  Trang_Chu
{
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }

        private void Dang_nhap_button_Click(object sender, EventArgs e)
        {
            if (true)
            {
                Trang_chu_cho_doc_gia x=new Trang_chu_cho_doc_gia();
                x.Show();
                
            }
        }

        
    }
}
