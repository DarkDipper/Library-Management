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
using System.Runtime.Serialization.Formatters.Binary;
namespace WindowsFormsApp1
{
    public partial class Giaiphuongtrinh : Form
    {
        public Giaiphuongtrinh()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                double A = double.Parse(textBox1.Text);
                double B = double.Parse(textBox4.Text);
                double C = double.Parse(textBox3.Text);
                Ptb2 pt = new Ptb2()
                {
                    A = double.Parse(textBox1.Text),
                    B = double.Parse(textBox4.Text),
                    C = double.Parse(textBox3.Text)
                };

                // Giải và hiển thị kết quả
                String ketQua = pt.Giai();
                label8.Text = ketQua;


            }
            catch
            {
                MessageBox.Show("Sai dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                double A = double.Parse(textBox1.Text);
                double B = double.Parse(textBox4.Text);
                double C = double.Parse(textBox3.Text);
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Ptb2 pt = new Ptb2()
                    {
                        A = double.Parse(textBox1.Text),
                        B = double.Parse(textBox4.Text),
                        C = double.Parse(textBox3.Text)
                    };
                    FileStream stream = File.OpenWrite(saveFileDialog1.FileName);
                    BinaryFormatter formater = new BinaryFormatter();
                    formater.Serialize(stream, pt); // lưu vào file
                    stream.Close();
                }

            }
            catch
            {
                MessageBox.Show("Sai dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = File.OpenRead(openFileDialog1.FileName);
                BinaryFormatter formater = new BinaryFormatter();
                Ptb2 pt = (Ptb2)formater.Deserialize(stream); // đọc từ file
                stream.Close();
                textBox1.Text = pt.A.ToString();
                textBox4.Text = pt.B.ToString();
                textBox3.Text = pt.C.ToString();
                button1_Click(null, null);
            }
        }
    }
}
