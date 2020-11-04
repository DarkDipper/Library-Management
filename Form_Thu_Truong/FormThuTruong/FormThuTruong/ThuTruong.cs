using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FormThuTruong
{
    public partial class ThuTruong : Form
    {
        public ThuTruong()
        {
            InitializeComponent();
        }
        public string NV;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_NhanVien_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            QLDG.QLDG x = new QLDG.QLDG();
            x.check = true;
            x.NV = NV;
            this.Hide();
            x.ShowDialog();
            this.Show();
        }
    }
}
