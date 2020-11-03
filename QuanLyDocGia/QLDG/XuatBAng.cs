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
using app = Microsoft.Office.Interop.Excel.Application;
namespace QLDG
{
    public partial class XuatBAng : Form
    {
        public XuatBAng()
        {
            InitializeComponent();
        }

        private void XuatBAng_Load(object sender, EventArgs e)
        {
            if (File.Exists("DuongdanBang.txt"))
            {
                //mở file để đọc
                StreamReader sr = new StreamReader("DuongdanBang.txt");
                //đọc từng dọc
                xuatBang_duongdan.Text = $@"{sr.ReadLine()}";
                sr.Close();
            }
            else xuatBang_duongdan.Text = $@"C:\Users\";
            xuatBang_ten.Text = $"QLDG";
        }
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
            //=================================================== Xử lý ===================================================
        }

        private void xuatBang_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonxuatBang_duongDan_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    xuatBang_duongdan.Text = fbd.SelectedPath + "\\";
                }
            }
            FileStream fs1 = new FileStream(@"DuongdanBang.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs1);
            sw.WriteLine(xuatBang_duongdan.Text);
            sw.Close();
        }
        public DataGridView BangThongTin;

        private void xuatBang_xuat_Click(object sender, EventArgs e)
        {
            if (xuatBang_ten != null)
            {
                try
                {
                    Export_Excel(BangThongTin, xuatBang_duongdan.Text, xuatBang_ten.Text);
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
