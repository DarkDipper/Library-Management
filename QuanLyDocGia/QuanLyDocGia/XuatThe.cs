﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using Org.BouncyCastle.Crypto.Parameters;
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


namespace BM2
{
    public partial class XuatThe : Form
    {
        public XuatThe()
        {
            InitializeComponent();
        }

        public string MS;
        public string Ten;
        public string NgaySinh;
        public string NgayLapThe;
        public string Loai;
        public string DiaChi;
        public string Email;
        public string NgLap;
        private void XuatThe_Load(object sender, EventArgs e)
        {
            if (File.Exists("DuongdanThe.txt"))
            {
                //mở file để đọc
                StreamReader sr = new StreamReader("DuongdanThe.txt");
                //đọc từng dọc
                xuatThe_duongdan.Text = $@"{sr.ReadLine()}";
                sr.Close();
            }
            else xuatThe_duongdan.Text = $@"C:\Users\";
            xuatThe_ten.Text = $"{MS}-{Ten}";
        }

        private void xuatThe_duongDan_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                   xuatThe_duongdan.Text = fbd.SelectedPath;
                   xuatThe_duongdan.Text +="\\";
                }
            }
            FileStream fs1 = new FileStream(@"DuongdanThe.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs1);
            sw.WriteLine(xuatThe_duongdan.Text);
            sw.Close();
        }
        private void xuatThe_xuat_Click(object sender, EventArgs e)
        {
            if (xuatThe_ten!=null)
            {
                try
                {
                    Document The = new Document(iTextSharp.text.PageSize.HALFLETTER);
                    PdfWriter TheWriter = PdfWriter.GetInstance(The, new FileStream($@"{xuatThe_duongdan.Text + xuatThe_ten.Text}.pdf", FileMode.Create));
                    System.Drawing.Image img1 = global::BM2.Properties.Resources.rsz_npl;
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
                    string fullPath1= Path.Combine(exeDir, @"VietFontsWeb1_ttf\vuTimes.ttf");
                    BaseFont bf0 = BaseFont.CreateFont(fullPath0, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    BaseFont bf1 = BaseFont.CreateFont(fullPath1, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    iTextSharp.text.Font f2 = new iTextSharp.text.Font(bf0, 15, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.RED);
                    iTextSharp.text.Font f3 = new iTextSharp.text.Font(bf1,10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                    iTextSharp.text.Font f4 = new iTextSharp.text.Font(bf1,8, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLUE);
                    /*Paragraph p1 = new Paragraph("        LM_PROJECT.EC", f1);
                    Paragraph p2 = new Paragraph($"                                        Mã số: {MS}", f3);
                    Paragraph p3 = new Paragraph($"                                        Họ và tên: {Ten}", f3);
                    Paragraph p4 = new Paragraph($"                                        Ngày sinh: {NgaySinh}", f3);
                    Paragraph p5 = new Paragraph($"                                        Ngày lập thẻ: {NgayLapThe}", f3);
                    Paragraph p6 = new Paragraph($"                                        Loai: {Loai}", f3);
                    Paragraph Enter=new Paragraph("             ");
                   
                    p1.Alignment = Element.ALIGN_CENTER;
                    p2.Alignment = Element.LISTITEM;
                    p3.Alignment = Element.LISTITEM;
                    p4.Alignment = Element.LISTITEM;
                    p5.Alignment = Element.LISTITEM;
                    p6.Alignment = Element.LISTITEM;
                    
                   
                    The.Add(p1);
                    The.Add(text_img1);
                    
                    The.Add(Info_img2);
                    The.Add(Enter);
                    The.Add(p2);
                    The.Add(p3);
                    The.Add(p4);
                    The.Add(p5);
                    The.Add(p6);
                    */

                    // iTextSharp.text.Font f = new iTextSharp.text.Font();
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
                    table.AddCell(new Phrase($"Họ và tên: {Ten}", f3));
                    table.AddCell(new Phrase($"Loại độc giả: {Loai}", f3));
                    table.AddCell(new Phrase($"Ngày sinh: {NgaySinh}", f3));
                    table.AddCell(new Phrase($"Địa chỉ: {DiaChi}",f3));
                    table.AddCell(new Phrase($"Email: {Email}", f3));
                    table.AddCell(new Phrase($"Ngày lập thẻ : {NgayLapThe}", f3));
                    table.AddCell(new Phrase($"Người lập thẻ : {NgLap}", f3));
                    table.AddCell(new Phrase($"   ", f3));
                    table.AddCell(new Phrase($"   ", f3));

                    Paragraph Enter = new Paragraph("             ");
                    Paragraph p7 = new Paragraph($"THẺ ĐỘC GIẢ - {MS}", f2);
                    Paragraph p8 = new Paragraph($"(Thẻ có giá trị sử dụng 180 ngày kể từ ngày lập thẻ)", f4);
                    p7.Alignment = Element.ALIGN_CENTER;
                    p8.Alignment = Element.ALIGN_CENTER;
                    The.Open();
                    The.Add(p1);
                    The.Add(text_img1);
                    The.Add(p7);
                    The.Add(p8);
                    The.Add(Enter);
                    The.Add(table);
                    The.Close();
                    TheWriter.Close();

                    var x = new TheDocGia();
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

        private void xuatThe_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}