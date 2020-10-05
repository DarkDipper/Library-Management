
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BM2;
using Trang_Chu;

namespace QL_DocGia
{
    public partial class QuanLyDocGia : Form
    {
        public QuanLyDocGia()
        {
            InitializeComponent();
        }


        private void thêmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TheDocGia x = new TheDocGia();
            this.Hide();
            x.ShowDialog();
            this.Show();
        }

        private void trangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log_in dang_nhap = new Log_in();
            this.Hide();
            dang_nhap.ShowDialog();
            this.Show();
        }
    }
}
