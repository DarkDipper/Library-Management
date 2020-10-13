using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class GoiMon : Form
    {
        public GoiMon()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string tenmon = textBox1.Text.Trim();
            if (listBox1.Items.Contains(tenmon)) MessageBox.Show("Đã có món này rồi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                listBox1.Items.Add(tenmon);
                textBox1.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (string item in listBox1.SelectedItems)
            {
                if (!listBox2.Items.Contains(item)) listBox2.Items.Add(item);
                else MessageBox.Show("Món đã có trong thực đơn", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool ok = false;
            foreach (string item in listBox1.Items)
            {
                if (!listBox2.Items.Contains(item)) listBox2.Items.Add(item);
                else ok = true;
            }
            if (ok) MessageBox.Show("Không còn món để chọn", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int item = listBox2.SelectedIndex;
            if(item>=0) listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            else MessageBox.Show("Làm ơn chọn món", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("DS_MonChon.txt", true);
            sw.WriteLine("Ngày đặt: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            sw.WriteLine("Danh sách món chọn: ");
            int i = 1;
            foreach(string item in listBox2.Items)
            {
                string ch = string.Format("{0} - {1}.", i++, item);
                sw.WriteLine(ch);
            }
            sw.WriteLine("-------------------------------------------");
            sw.Close();
        }

    }
}
