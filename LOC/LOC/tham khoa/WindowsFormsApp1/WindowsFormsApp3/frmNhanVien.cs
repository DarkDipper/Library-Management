using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("data.txt");
            sw.WriteLine("Họ tên: " + textBox1.Text);
            if (radioButton2.Checked)
                sw.WriteLine("Giới tính: Nữ");
            else
                sw.WriteLine("Giới tính: Nam");
            sw.WriteLine("Ngày sinh: " + dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            sw.WriteLine("Quốc tịch: " + comboBox1.SelectedItem.ToString());
            sw.WriteLine("Bậc lương: " + numericUpDown1.Value.ToString());
            //Sở thích
            List<string> sothich = new List<string>();
            foreach (string item in checkedListBox1.CheckedItems)
            {
                sothich.Add(item);
            }
            sw.WriteLine("Sở thích: " + string.Join(", ", sothich));
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                //xóa các giá trị đang chọn
                textBox1.Text = "";
                dateTimePicker1.Value = DateTime.Now.AddYears(-5);
                comboBox1.SelectedIndex = 0;//việt nam
                numericUpDown1.Value = 1;
                //xóa check cho từng item (quên)
                foreach (int i in checkedListBox1.CheckedIndices)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }
               checkedListBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kiểm tra xem có file data.txt
            if (File.Exists("data.txt"))
            {
                //mở file để đọc
                StreamReader sr = new StreamReader("data.txt");
                //đọc từng dọc
                string chuoi_doc_duoc = sr.ReadLine();
                textBox1.Text = tach_noidung(chuoi_doc_duoc);
                //đọc giới tính
                chuoi_doc_duoc = tach_noidung(sr.ReadLine());
                if (chuoi_doc_duoc == "Nam")
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;
                //doc ngày sinh: dd/MM/yyyy
                chuoi_doc_duoc = tach_noidung(sr.ReadLine());
                dateTimePicker1.Value = DateTime.ParseExact(chuoi_doc_duoc, "dd/MM/yyyy", null);
                //quốc tịch
                chuoi_doc_duoc = tach_noidung(sr.ReadLine());
                comboBox1.SelectedItem = chuoi_doc_duoc;
                //bậc lương
                chuoi_doc_duoc = tach_noidung(sr.ReadLine());
                numericUpDown1.Value = int.Parse(chuoi_doc_duoc);
                chuoi_doc_duoc = tach_noidung(sr.ReadLine());
                string[] sothich = tach_thuoctinh(chuoi_doc_duoc);
                for(int i = 0; i < sothich.Length; i++)
                {
                    int k = checkedListBox1.Items.IndexOf(sothich[i].Trim());
                    checkedListBox1.SetItemCheckState(k, CheckState.Checked);

                }
                sr.Close();
                
            }
        }
        string[] tach_thuoctinh(string ch)
        {
            string[] mang = ch.Split(',');
            return mang;
        }
        string tach_noidung(string ch)
        {
            string[] mang = ch.Split(':');
            return mang[1].Trim();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

