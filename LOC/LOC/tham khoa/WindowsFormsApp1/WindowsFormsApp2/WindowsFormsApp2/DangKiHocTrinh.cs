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

namespace WindowsFormsApp2
{
    public partial class DangKiHocPhan : Form
    {
        public DangKiHocPhan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hoTen = textBox1.Text;
            DateTime ngayHoc = dateTimePicker1.Value;
            string[] monHoc = new string[listBox1.SelectedItems.Count];
            for(int i = 0; i < monHoc.Length; i++)
            {
                monHoc[i] = listBox1.SelectedItems[i].ToString();
            }
            if (hoTen.Length == 0) label5.Text = "Vui lòng nhập họ tên !";
            else if (ngayHoc < DateTime.Now) label5.Text = "Ngày học không hợp lệ";
            else if (monHoc.Length == 0) label5.Text = "Vui lòng chọn ít nhất một môn học";
            else
            {
                String[] thongtin = { hoTen, ngayHoc.ToString("dd-MM-yyyy"), String.Join("+", monHoc) };
                String tenFlie = "C:\\Users\\kun\\source\\repos\\" + hoTen + ".txt";
                File.WriteAllLines(tenFlie, thongtin);
                MessageBox.Show("Thông tin đăng kí đã được lưu vào file [" + tenFlie + "]");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
