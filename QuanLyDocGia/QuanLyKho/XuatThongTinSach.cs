using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace QuanLyKho
{
    public partial class XuatThongTinSach : Form
    {
        public XuatThongTinSach()
        {
            InitializeComponent();
        }
        public string MaSach;
        public string TenSach;
        public string TheLoai;
        public string TacGia;
        public string NamXuatBan;
        public string NhaXuatBan;
        public string NgayNhap;
        public string NguoiTiepNhan;
        public string TriGia;
        private void buttonxuatThongTinSach_duongDan_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    xuatThongTinSach_duongdan.Text = fbd.SelectedPath;
                    xuatThongTinSach_duongdan.Text += "\\";
                }
            }
            FileStream fs1 = new FileStream(@"DuongdanThongTinSach.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs1);
            sw.WriteLine(xuatThongTinSach_duongdan.Text);
            sw.Close();
        }

        private void xuatThongTinSach_xuat_Click(object sender, EventArgs e)
        {
            if (xuatThongTinSach_ten != null)
            {
                try
                {
                    Document The = new Document(iTextSharp.text.PageSize.HALFLETTER);
                    PdfWriter TheWriter = PdfWriter.GetInstance(The, new FileStream($@"{xuatThongTinSach_duongdan.Text + xuatThongTinSach_ten.Text}.pdf", FileMode.Create));
                    System.Drawing.Image img1 = global::QuanLyKho.Properties.Resources.rsz_npl;
                    //System.Drawing.Image img2 = global::BM2.Properties.Resources._2x3;
                    iTextSharp.text.Image text_img1 = iTextSharp.text.Image.GetInstance(img1, System.Drawing.Imaging.ImageFormat.Png);
                    //iTextSharp.text.Image Info_img2 = iTextSharp.text.Image.GetInstance(img2, System.Drawing.Imaging.ImageFormat.Png);
                    //Info_img2.SetAbsolutePosition(The.PageSize.Width - 280f - 60f,The.PageSize.Height - 40f - 190f );
                    text_img1.SetAbsolutePosition(The.PageSize.Width - 280f - 60f, The.PageSize.Height - 30f - 75f);
                    // The.Add(text_img);
                    iTextSharp.text.Font f1 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 25, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE);
                    string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
                    string exeDir = Path.GetDirectoryName(exeFile);
                    string fullPath0 = Path.Combine(exeDir, @"VietFontsWeb1_ttf\vuTimesBold.ttf");
                    string fullPath1 = Path.Combine(exeDir, @"VietFontsWeb1_ttf\vuTimes.ttf");
                    BaseFont bf0 = BaseFont.CreateFont(fullPath0, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    BaseFont bf1 = BaseFont.CreateFont(fullPath1, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    iTextSharp.text.Font f2 = new iTextSharp.text.Font(bf0, 15, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.RED);
                    iTextSharp.text.Font f3 = new iTextSharp.text.Font(bf1, 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                    iTextSharp.text.Font f4 = new iTextSharp.text.Font(bf1, 8, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLUE);
                    PdfPTable table = new PdfPTable(3);
                    table.DefaultCell.Padding = 3;
                    table.DefaultCell.MinimumHeight = 20;
                    table.WidthPercentage = 100;
                    table.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.DefaultCell.BorderWidth = 1;
                    PdfPCell cellHoTen = new PdfPCell(new Phrase($"          ", f3));
                    PdfPCell cellLoai = new PdfPCell(new Phrase($"          ", f3));
                    PdfPCell cellNgayinh = new PdfPCell(new Phrase($"         ", f3));
                    cellHoTen.BackgroundColor = new BaseColor(195, 195, 195);
                    cellLoai.BackgroundColor = new BaseColor(195, 195, 195);
                    cellNgayinh.BackgroundColor = new BaseColor(195, 195, 195);
                    Paragraph p1 = new Paragraph("        LM_PROJECT.EC", f1);
                    p1.Alignment = Element.ALIGN_CENTER;
                    table.AddCell(cellHoTen);
                    table.AddCell(cellLoai);
                    table.AddCell(cellNgayinh);
                    table.AddCell(new Phrase($"Tên sách: {TenSach}", f3));
                    table.AddCell(new Phrase($"Thể loại: {TheLoai}", f3));
                    table.AddCell(new Phrase($"Tác giả: {TacGia}", f3));
                    table.AddCell(new Phrase($"Năm xuất bản: {NamXuatBan}", f3));
                    table.AddCell(new Phrase($"Nhà xuất bản: {NhaXuatBan}", f3));
                    table.AddCell(new Phrase($"Ngày nhập: {NgayNhap}", f3));
                    table.AddCell(new Phrase($"Trị giá: {TriGia}", f3));
                    table.AddCell(new Phrase($"Người Tiếp Nhận: {NguoiTiepNhan}", f3));
                    table.AddCell(new Phrase($"   ", f3));
                    Paragraph Enter = new Paragraph("             ");
                    Paragraph p7 = new Paragraph($"     THÔNG TIN SÁCH - {MaSach}", f2);
                    p7.Alignment = Element.ALIGN_CENTER;
                    The.Open();
                    The.Add(p1);
                    The.Add(text_img1);
                    The.Add(p7);
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

        private void xuatThongTinSach_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XuatThongTinSach_Load(object sender, EventArgs e)
        {
            if (File.Exists("DuongdanThongTinSach.txt"))
            {
                //mở file để đọc
                StreamReader sr = new StreamReader("DuongdanThongTinSach.txt");
                //đọc từng dọc
                xuatThongTinSach_duongdan.Text = $@"{sr.ReadLine()}";
                sr.Close();
            }
            else xuatThongTinSach_duongdan.Text = $@"C:\Users\";
            //MessageBox.Show($"{MaSach}-{TenSach}");
            xuatThongTinSach_ten.Text = $"{MaSach}-{TacGia}";
        }
    }
}

