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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QuanLyKho
{
    public partial class XuatKhoSach : Form
    {
        public XuatKhoSach()
        {
            InitializeComponent();
        }
        //================================================ Hàm bổ trợ================================================
        private void Export_Excel(DataGridView g, string dgdan, string ten)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(dgdan + ten + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
            MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //=================================================== Xử lý ===================================================
        private void xuatKho_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XuatKhoSach_Load(object sender, EventArgs e)
        {
            if (File.Exists("DuongdanKho.txt"))
            {
                //mở file để đọc
                StreamReader sr = new StreamReader("DuongdanKho.txt");
                //đọc từng dọc
                xuatKho_duongdan.Text = $@"{sr.ReadLine()}";
                sr.Close();
            }
            else xuatKho_duongdan.Text = $@"C:\Users\";
            xuatKho_ten.Text = $"QLK";
        }

        private void buttonxuatKho_duongDan_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    xuatKho_duongdan.Text = fbd.SelectedPath + "\\";
                }
            }
            FileStream fs1 = new FileStream(@"DuongdanKho.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs1);
            sw.WriteLine(xuatKho_duongdan.Text);
            sw.Close();
        }
        public DataGridView khoSach;

        private void xuatKho_xuat_Click(object sender, EventArgs e)
        {
            if (xuatKho_ten != null)
            {
                try
                {
                    Export_Excel(khoSach, xuatKho_duongdan.Text, xuatKho_ten.Text);
                }
                catch
                {
                    MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
