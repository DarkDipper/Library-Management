﻿using iTextSharp.text;
using iTextSharp.text.pdf;
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

namespace WindowsFormsApp4
{
    public partial class PhieuTraNo : Form
    {
        public PhieuTraNo()
        {
            InitializeComponent();
        }
        public string MS;
        public string Ten;
        public string tienthu;
        public string tienno;
        public string conlai;
        public string ngghinhan;
        string ChuanHoa(string s)
        {
            string kq = "000";
            string xultchuoi = s;
            //MessageBox.Show(xultchuoi);
            int l = xultchuoi.Length;
            if (l > 3) l -= 3;
            // MessageBox.Show(l.ToString());
            while (l > 3)
            {
                kq = xultchuoi.Substring(l - 3, 3) + "." + kq;
                /// MessageBox.Show(kq);
                l -= 3;
            }
            kq = xultchuoi.Substring(0, l) + "." + kq;
            return kq;
        }
        private void PhieuTraNo_Load(object sender, EventArgs e)
        {
            //MessageBox.Show($"{Dsss.Items[0].SubItems[0].Text}");
            if (File.Exists("DuongdanNo.txt"))
            {
                //mở file để đọc
                StreamReader sr = new StreamReader("DuongdanNo.txt");
                //đọc từng dọc
                xuatNo_duongdan.Text = $@"{sr.ReadLine()}";
                sr.Close();
            }
            else xuatNo_duongdan.Text = $@"C:\Users\";
            xuatNo_ten.Text = $"M_{Ten}_{DateTime.Today.ToString("dd-MM-yyyy")}";
        }

        private void buttonxuatNo_duongDan_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    xuatNo_duongdan.Text = fbd.SelectedPath;
                    xuatNo_duongdan.Text += "\\";
                }
                FileStream fs1 = new FileStream(@"DuongdanNo.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                StreamWriter sw = new StreamWriter(fs1);
                sw.WriteLine(xuatNo_duongdan.Text);
                sw.Close();
            }
        }

        private void xuatNo_xuat_Click(object sender, EventArgs e)
        {
            if (xuatNo_ten != null)
            {
                //    try
                //   {

                Document The = new Document(iTextSharp.text.PageSize.HALFLETTER);
                PdfWriter TheWriter = PdfWriter.GetInstance(The, new FileStream($@"{xuatNo_duongdan.Text + xuatNo_ten.Text}.pdf", FileMode.Create));
                System.Drawing.Image img1 = global::WindowsFormsApp4.Properties.Resources.rsz_npl;
                System.Drawing.Image img2 = global::WindowsFormsApp4.Properties.Resources.Untitled;
                //System.Drawing.Image img2 = global::BM2.Properties.Resources._2x3;
                iTextSharp.text.Image text_img1 = iTextSharp.text.Image.GetInstance(img1, System.Drawing.Imaging.ImageFormat.Png);
                iTextSharp.text.Image text_img2 = iTextSharp.text.Image.GetInstance(img2, System.Drawing.Imaging.ImageFormat.Png);
                //iTextSharp.text.Image Info_img2 = iTextSharp.text.Image.GetInstance(img2, System.Drawing.Imaging.ImageFormat.Png);
                //Info_img2.SetAbsolutePosition(The.PageSize.Width - 280f - 60f,The.PageSize.Height - 40f - 190f );
                text_img1.SetAbsolutePosition(The.PageSize.Width - 280f - 60f, The.PageSize.Height - 30f - 75f);
                text_img2.SetAbsolutePosition(The.PageSize.Width - 120f - 60f, The.PageSize.Height - 260f - 75f);
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
                iTextSharp.text.Font f5 = new iTextSharp.text.Font(bf1, 10, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.ORANGE);
                Paragraph p1 = new Paragraph("        LM_PROJECT.EC", f1);
                p1.Alignment = Element.ALIGN_CENTER;
                Paragraph Enter = new Paragraph("             ");
                Paragraph p7 = new Paragraph($"   PHIẾU THU TIỀN PHẠT", f2);
                Paragraph p8 = new Paragraph($"   {MS}",f2);
                Paragraph p5 = new Paragraph($"Ghi chú: ", f5);
                Paragraph p6 = new Paragraph($"...................................................\n" +
                                             $"...................................................", f3);
                p7.Alignment = Element.ALIGN_CENTER;
                p8.Alignment = Element.ALIGN_CENTER;
                PdfPTable table = new PdfPTable(1);
                table.DefaultCell.Padding = 3;
                table.DefaultCell.MinimumHeight = 20;
                table.WidthPercentage = 100;
                table.HorizontalAlignment = Element.ALIGN_CENTER;
                table.DefaultCell.BorderWidth = 1;
                PdfPCell cellstt = new PdfPCell(new Phrase($"   ", f3));
                cellstt.BackgroundColor = new BaseColor(178, 255, 178);
                table.AddCell(cellstt);
                //  var dss = from z in qltv.MuonSaches where z.MaDocGia == MaDocGia && z.NgayMuon == NgayMuon select z;
                table.AddCell(new Phrase($"\n               Họ tên : {Ten}\n\n               Tiền nợ : {ChuanHoa(tienno)} đồng\n\n               Số tiền thu : {ChuanHoa(tienthu)} đồng\n\n               Còn lại : {ChuanHoa(conlai)} đồng\n\n               Người thu tiền : {ngghinhan}\n\n", f3));
                //   MessageBox.Show($"{i.ToString()}");
                The.Open();
                The.Add(p1);
                The.Add(text_img1);
                The.Add(p7);
                The.Add(p8);
                The.Add(Enter);
                The.Add(table);
                The.Add(Enter);
                The.Add(p5);
                The.Add(p6);
                The.Add(text_img2);
                The.Close();
                TheWriter.Close();
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  }
                //   catch
                //  {
                //      MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // }
            }
            else MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}