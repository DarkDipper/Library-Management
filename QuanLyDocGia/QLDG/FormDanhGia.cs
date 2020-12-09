using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDG
{
    public partial class FormDanhGia : Form
    {
        public FormDanhGia()
        {
            InitializeComponent();
        }
        public ListBox tra;
        QuanLyTV qltv = new QuanLyTV();
        int[] a = new int[6];
        private void FormDanhGia_Load(object sender, EventArgs e)
        {
           
            groupBox1.Visible = false;
            
            for (int i = 0; i < 6; i++) a[i] = 0;
            //groupBox1.Visible = false;
            foreach (string i in tra.Items)
            {
                var sach = qltv.DanhSachSaches.SingleOrDefault(p => p.MaSach == i);
                comboBox1.Items.Add(sach.TenSach);
            }
        }
        int CheckRadio()
        {
            if (radioButton1.Checked) return 1;
            else if (radioButton2.Checked) return 2;
            else if (radioButton3.Checked) return 3;
            else if (radioButton4.Checked) return 4;
            else if (radioButton5.Checked) return 5;
            else return 0;
        }
        void Checkfalse()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }
        void hienthi(int i)
        {
            if (i == 1) radioButton1.Checked = true;
            else if (i == 2) radioButton2.Checked = true;
            else if (i == 3) radioButton3.Checked = true;
            else if (i == 4) radioButton4.Checked = true;
            else if (i == 5) radioButton5.Checked = true;
        }
        float DanhGia(string x)
        {
            float dem = 0;
            float tong = 0;
            for (int i = 0; i < x.Length; i++)
            {
               if (x[i] != '0') dem++;
               tong += float.Parse(x[i].ToString());
            }
            if (tong != 0 && dem != 0) return (float)tong / (dem);
            else return 0;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Checkfalse();
            groupBox1.Visible = true;
            radioButton6.Checked = true;
            hienthi(a[comboBox1.SelectedIndex]);
           // groupBox1.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            a[comboBox1.SelectedIndex] = CheckRadio();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            a[comboBox1.SelectedIndex] = CheckRadio();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            a[comboBox1.SelectedIndex] = CheckRadio();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            a[comboBox1.SelectedIndex] = CheckRadio();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            a[comboBox1.SelectedIndex] = CheckRadio();
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            a[comboBox1.SelectedIndex] = CheckRadio();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int j = 0;
            foreach (string i in tra.Items)
            {
                var sach = qltv.DanhSachSaches.SingleOrDefault(p => p.MaSach == i);
                if(a[j] !=0) sach.LuotDanhGia += a[j].ToString();
               // else sach.LuotDanhGia += "";
                sach.DanhGia = DanhGia(sach.LuotDanhGia);
                qltv.DanhSachSaches.AddOrUpdate(sach);
                qltv.SaveChanges();
                j++;
            }
            this.Close();
        }

    }
}
