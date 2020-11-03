using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDG
{
    public partial class PhieuMuon : Form
    {
        public PhieuMuon()
        {
            InitializeComponent();
        }
        public DateTime NgayMuon = DateTime.Today;
        public string MaDocGia;
        public string TenDocGia;
        public DateTime NgayTra; 
        public string MaSach;
        public string TenSach;
        public string TheLoai;
        QuanLyTV qltv = new QuanLyTV();
        private void PhieuMuon_Load(object sender, EventArgs e)
        {
            NgayTra = NgayMuon.AddDays(+7);
            var docgia = qltv.TheDocGias.SingleOrDefault(p => p.MS == MaDocGia);
            TenDocGia = docgia.HoTen;
            if (File.Exists("DuongdanMuon.txt"))
            {
                //mở file để đọc
                StreamReader sr = new StreamReader("DuongdanMuon.txt");
                //đọc từng dọc
                xuatMuon_duongdan.Text = $@"{sr.ReadLine()}";
                sr.Close();
            }
            else xuatMuon_duongdan.Text = $@"C:\Users\";
            xuatMuon_ten.Text = $"B_{TenDocGia}_{NgayMuon.ToString("dd-MM-yyyy")}";
        }
        private void buttonxuatMuon_duongDan_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    xuatMuon_duongdan.Text = fbd.SelectedPath;
                    xuatMuon_duongdan.Text += "\\";
                }
            }
            FileStream fs1 = new FileStream(@"DuongdanMuon.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs1);
            sw.WriteLine(xuatMuon_duongdan.Text);
            sw.Close();
        }

        private void xuatMuon_xuat_Click(object sender, EventArgs e)
        {
//MessageBox.("Đang xử lý ...");
            if (xuatMuon_ten != null)
            {
            //    try
             //   {
                   
                Document The = new Document(iTextSharp.text.PageSize.HALFLETTER);
                PdfWriter TheWriter = PdfWriter.GetInstance(The, new FileStream($@"{xuatMuon_duongdan.Text + xuatMuon_ten.Text}.pdf", FileMode.Create));
                System.Drawing.Image img1 = global::QLDG.Properties.Resources.rsz_npl;
                System.Drawing.Image img2 = global::QLDG.Properties.Resources.Untitled;
                //System.Drawing.Image img2 = global::BM2.Properties.Resources._2x3;
                iTextSharp.text.Image text_img1 = iTextSharp.text.Image.GetInstance(img1, System.Drawing.Imaging.ImageFormat.Png);
                iTextSharp.text.Image text_img2 = iTextSharp.text.Image.GetInstance(img2, System.Drawing.Imaging.ImageFormat.Png);
                //iTextSharp.text.Image Info_img2 = iTextSharp.text.Image.GetInstance(img2, System.Drawing.Imaging.ImageFormat.Png);
                //Info_img2.SetAbsolutePosition(The.PageSize.Width - 280f - 60f,The.PageSize.Height - 40f - 190f );
                text_img1.SetAbsolutePosition(The.PageSize.Width - 280f - 60f, The.PageSize.Height - 30f - 75f);
                text_img2.SetAbsolutePosition(The.PageSize.Width - 120f - 60f, The.PageSize.Height - 290f - 75f);
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
                Paragraph p2 = new Paragraph($"     Họ tên độc giả: {TenDocGia}", f3);
                Paragraph p3 = new Paragraph($"     Ngày mượn : {NgayMuon.ToString("dd/MM/yyyy")}", f3);
                Paragraph p4 = new Paragraph($"     Ngày trả: {NgayTra.ToString("dd/MM/yyyy")}", f3);
                Paragraph p5 = new Paragraph($"Ghi chú: ", f5);
                Paragraph p6 = new Paragraph($"...................................................\n" +
                                             $"...................................................", f3);
                p2.Alignment = Element.ALIGN_LEFT;
                p3.Alignment = Element.ALIGN_LEFT;
                p4.Alignment = Element.ALIGN_LEFT;
                Paragraph Enter = new Paragraph("             ");
                Paragraph p7 = new Paragraph($"   PHIẾU MƯỢN SÁCH - {MaDocGia}", f2);
                p7.Alignment = Element.ALIGN_CENTER;
                PdfPTable table = new PdfPTable(3);
                table.DefaultCell.Padding = 3;
                table.DefaultCell.MinimumHeight = 20;
                table.WidthPercentage = 100;
                table.HorizontalAlignment = Element.ALIGN_CENTER;
                table.DefaultCell.BorderWidth = 1;
                PdfPCell cellstt = new PdfPCell(new Phrase($"STT", f3));
                PdfPCell cellms = new PdfPCell(new Phrase($"Mã sách", f3));
                PdfPCell cellts = new PdfPCell(new Phrase($"Tên sách", f3));
                cellstt.BackgroundColor = new BaseColor(178, 255, 178);
                cellms.BackgroundColor = new BaseColor(178, 255, 178);
                cellts.BackgroundColor = new BaseColor(178, 255, 178);
                table.AddCell(cellstt);
                table.AddCell(cellms);
                table.AddCell(cellts);
                int i = 1;
                var dss = from z in qltv.MuonSaches where z.MaDocGia == MaDocGia && z.NgayMuon == NgayMuon select z;
                foreach (var item in dss)
                {
                    var sach = qltv.DanhSachSaches.SingleOrDefault(p => p.MaSach == item.MaSach);
                    table.AddCell(new Phrase((i).ToString(), f3));
                    table.AddCell(new Phrase(sach.MaSach, f3));
                    table.AddCell(new Phrase(sach.TenSach, f3));
                    i++;
                }
                while (i < 6)
                {
                    table.AddCell(new Phrase((i).ToString(), f3));
                    table.AddCell(new Phrase("    ", f3));
                    table.AddCell(new Phrase("    ", f3));
                    i++;
                }
                The.Open();
                The.Add(p1);
                The.Add(text_img1);
                The.Add(p7);
                The.Add(Enter);
                The.Add(p2);
                The.Add(p3);
                The.Add(p4);
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

        private void xuatMuon_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
