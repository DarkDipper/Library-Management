using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp4
{

    public partial class NhapLieu : Form
    {
        public NhapLieu()
        {
            InitializeComponent();
        }

        private void button_khoitao_Click(object sender, EventArgs e)
        {
            int dong, cot;
            if (!int.TryParse(text_dong.Text, out dong)) dong = 1;
            if (!int.TryParse(text_cot.Text, out cot)) cot = 1;
            Form1 frmX = new Form1(dong, cot);
            frmX.StartPosition = FormStartPosition.CenterParent;
            this.Hide();
            frmX.ShowDialog();
            this.Show();
        }
    }
}