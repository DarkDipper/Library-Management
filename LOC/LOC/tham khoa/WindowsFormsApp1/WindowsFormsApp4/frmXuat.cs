using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public int sDong { get; set; }
        public int sCot { get; set; }
        int h = 35, margin = 5;
        public Form1(int dong = 1, int cot = 1)
        {
            InitializeComponent();
            this.sDong = dong;
            this.sCot = cot;
            Button btn = null;
            for (int i = 0; i < sDong; i++)
            {
                for (int j = 0; j < sCot; j++)
                {
                    btn = new Button();
                    btn.Width = h; btn.Height = h;
                    btn.Text = (i * sCot + j + 1).ToString();
                    btn.Left = margin * (j + 1) + h * j;
                    btn.Top = margin * (i + 1) + h * i;
                    btn.Click += btn_Click;
                    btn.MouseHover += HoChuotLenNut;
                    btn.Tag = string.Format("Dòng {0} Cột {1}", i, j);
                    this.Controls.Add(btn);
                }
            }
            this.ClientSize = new Size(sCot * (h + margin+1), sDong *(h + margin+1));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Dòng ? Cột ?";
        }
        private void HoChuotLenNut(object sender, EventArgs e)
        {
            this.Text = (sender as Button).Tag.ToString();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Button).Text);
        }

    }
}


