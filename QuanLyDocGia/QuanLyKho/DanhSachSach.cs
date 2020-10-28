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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Reflection;

namespace QuanLyKho
{
    public partial class DanhSachSach : Form
    {
        public DanhSachSach()
        {
            InitializeComponent();
        }
        public DataGridView Dss;

        private void buttonxuatDanhSachSach_duongDan_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    xuatDanhSachSach_duongdan.Text = fbd.SelectedPath;
                    xuatDanhSachSach_duongdan.Text += "\\";
                }
            }
            FileStream fs1 = new FileStream(@"DuongdanDanhSachSach.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs1);
            sw.WriteLine(xuatDanhSachSach_duongdan.Text);
            sw.Close();
        }

        private void xuatDanhSachSach_xuat_Click(object sender, EventArgs e)
        {
            if (xuatDanhSachSach_ten != null)
            {
                try
                {
                    Document The = new Document(iTextSharp.text.PageSize.A4);
                    PdfWriter TheWriter = PdfWriter.GetInstance(The, new FileStream($@"{xuatDanhSachSach_duongdan.Text + xuatDanhSachSach_ten.Text}.pdf", FileMode.Create));
                    System.Drawing.Image img1 = global::QuanLyKho.Properties.Resources.rsz_npl;
                    //System.Drawing.Image img2 = global::BM2.Properties.Resources._2x3;
                    iTextSharp.text.Image text_img1 = iTextSharp.text.Image.GetInstance(img1, System.Drawing.Imaging.ImageFormat.Png);
                    //iTextSharp.text.Image Info_img2 = iTextSharp.text.Image.GetInstance(img2, System.Drawing.Imaging.ImageFormat.Png);
                    //Info_img2.SetAbsolutePosition(The.PageSize.Width - 280f - 60f,The.PageSize.Height - 40f - 190f );
                    text_img1.Alignment = Element.ALIGN_CENTER;
                    // The.Add(text_img);
                    iTextSharp.text.Font f1 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 25, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE);
                    string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
                    string exeDir = Path.GetDirectoryName(exeFile);
                    string fullPath0 = Path.Combine(exeDir, @"VietFontsWeb1_ttf\vuTimesBold.ttf");
                    string fullPath1 = Path.Combine(exeDir, @"VietFontsWeb1_ttf\vuTimes.ttf");
                    BaseFont bf0 = BaseFont.CreateFont(fullPath0, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    BaseFont bf1 = BaseFont.CreateFont(fullPath1, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    iTextSharp.text.Font f2 = new iTextSharp.text.Font(bf0, 15, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.RED);
                    iTextSharp.text.Font f3 = new iTextSharp.text.Font(bf1, 12, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.DARK_GRAY);
                    iTextSharp.text.Font f4 = new iTextSharp.text.Font(bf1, 9, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK);
                    PdfPTable table = new PdfPTable(6);
                    table.DefaultCell.Padding = 3;
                    table.DefaultCell.MinimumHeight = 20;
                    table.WidthPercentage = 100;
                    table.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.DefaultCell.BorderWidth = 1;
                    PdfPCell cellstt = new PdfPCell(new Phrase($"STT", f3));
                    PdfPCell cellms = new PdfPCell(new Phrase($"Mã sách", f3));
                    PdfPCell cellts = new PdfPCell(new Phrase($"Tên sách", f3));
                    PdfPCell celll = new PdfPCell(new Phrase($"Thể loại", f3));
                    PdfPCell celltg = new PdfPCell(new Phrase($"Tác giả", f3));
                    PdfPCell celltt = new PdfPCell(new Phrase($"Trạng thái", f3));
                    cellstt.BackgroundColor = new BaseColor(178, 255, 178);
                    cellms.BackgroundColor = new BaseColor(178, 255, 178);
                    cellts.BackgroundColor = new BaseColor(178, 255, 178);
                    celll.BackgroundColor = new BaseColor(178, 255, 178);
                    celltg.BackgroundColor = new BaseColor(178, 255, 178);
                    celltt.BackgroundColor = new BaseColor(178, 255, 178);
                    Paragraph p1 = new Paragraph("LM_PROJECT.EC", f1);
                    p1.Alignment = Element.ALIGN_CENTER;
                    table.AddCell(cellstt);
                    table.AddCell(cellms);
                    table.AddCell(cellts);
                    table.AddCell(celll);
                    table.AddCell(celltg);
                    table.AddCell(celltt);
                    for(int i = 0; i < Dss.Rows.Count-1; i++)
                    {
                        table.AddCell(new Phrase((i+1).ToString(), f4));
                        table.AddCell(new Phrase(Dss.Rows[i].Cells[0].Value.ToString(),f4));
                        table.AddCell(new Phrase(Dss.Rows[i].Cells[1].Value.ToString(), f4));
                        table.AddCell(new Phrase(Dss.Rows[i].Cells[2].Value.ToString(), f4));
                        table.AddCell(new Phrase(Dss.Rows[i].Cells[3].Value.ToString(), f4));
                        table.AddCell(new Phrase(Dss.Rows[i].Cells[8].Value.ToString(), f4));

                    }
                    /* table.AddCell(new Phrase($"Tên sách: {TenSach}", f3));
                     table.AddCell(new Phrase($"Thể loại: {TheLoai}", f3));
                     table.AddCell(new Phrase($"Tác giả: {TacGia}", f3));
                     table.AddCell(new Phrase($"Năm xuất bản: {NamXuatBan}", f3));
                     table.AddCell(new Phrase($"Nhà xuất bản: {NhaXuatBan}", f3));
                     table.AddCell(new Phrase($"Ngày nhập: {NgayNhap}", f3));
                     table.AddCell(new Phrase($"Trị giá: {TriGia}", f3));
                     table.AddCell(new Phrase($"Người Tiếp Nhận: {NguoiTiepNhan}", f3));
                     table.AddCell(new Phrase($"   ", f3));*/
                    Paragraph Enter = new Paragraph("             ");
                    Paragraph p7 = new Paragraph($"DANH SÁCH SÁCH", f2);
                    p7.Alignment = Element.ALIGN_CENTER;
                    The.Open();
                    The.Add(p1);
                    The.Add(p7);
                    The.Add(text_img1);
                    The.Add(Enter);
                    The.Add(table);
                    The.Close();
                    TheWriter.Close();

                    var x = new QuanLyKho();
                    x.ThongKe();
                     MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DanhSachSach_Load(object sender, EventArgs e)
        {
            if (File.Exists("DuongdanDanhSachSach.txt"))
            {
                //mở file để đọc
                StreamReader sr = new StreamReader("DuongdanDanhSachSach.txt");
                //đọc từng dọc
                xuatDanhSachSach_duongdan.Text = $@"{sr.ReadLine()}";
                sr.Close();
            }
            else xuatDanhSachSach_duongdan.Text = $@"C:\Users\";
            //MessageBox.Show($"{MaSach}-{TenSach}");
            xuatDanhSachSach_ten.Text = $"DanhSachSach";
        }

        private void xuatDanhSachSach_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
