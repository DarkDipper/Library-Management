using iTextSharp.text;
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

namespace QLDG
{
    public partial class PhieuTra : Form
    {
        public PhieuTra()
        {
            InitializeComponent();
        }
        public string MaDocGia;
        public string TenDocGia;
        public DateTime NgayTra;
        public ListView Dsss;
        public int TienPhat;
        public int TongNo;
        Model1 qltv = new Model1();
        private void PhieuTra_Load(object sender, EventArgs e)
        {
            //MessageBox.Show($"{Dsss.Items[0].SubItems[0].Text}");
            var dg = qltv.TheDocGias.SingleOrDefault(p => p.MS == MaDocGia);
            TenDocGia = dg.HoTen;
            TongNo = (int)dg.TongNo;
            if (File.Exists("DuongdanTra.txt"))
            {
                //mở file để đọc
                StreamReader sr = new StreamReader("DuongdanTra.txt");
                //đọc từng dọc
                xuatTra_duongdan.Text = $@"{sr.ReadLine()}";
                sr.Close();
            }
            else xuatTra_duongdan.Text = $@"C:\Users\";
            xuatTra_ten.Text = $"P_{dg.HoTen}_{NgayTra.ToString("dd-MM-yyyy")}";
        }

        private void buttonxuatTra_duongDan_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    xuatTra_duongdan.Text = fbd.SelectedPath;
                    xuatTra_duongdan.Text += "\\";
                }
                FileStream fs1 = new FileStream(@"DuongdanTra.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                StreamWriter sw = new StreamWriter(fs1);
                sw.WriteLine(xuatTra_duongdan.Text);
                sw.Close();
            }
        }

        private void xuatTra_xuat_Click(object sender, EventArgs e)
        {
            if (xuatTra_ten != null)
            {
                //    try
                //   {

                Document The = new Document(iTextSharp.text.PageSize.HALFLETTER);
                PdfWriter TheWriter = PdfWriter.GetInstance(The, new FileStream($@"{xuatTra_duongdan.Text + xuatTra_ten.Text}.pdf", FileMode.Create));
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
                Paragraph p3 = new Paragraph($"     Ngày trả : {NgayTra.ToString("dd/MM/yyyy")}", f3);
                Paragraph p4 = new Paragraph($"     Tiền phạt kì này : {TienPhat.ToString()}", f3);
                Paragraph p8 = new Paragraph($"     Tổng nợ : {TongNo.ToString()}", f3);
                Paragraph p5 = new Paragraph($"Ghi chú: ", f5);
                Paragraph p6 = new Paragraph($"...................................................\n" +
                                             $"...................................................", f3);
                p2.Alignment = Element.ALIGN_LEFT;
                p3.Alignment = Element.ALIGN_LEFT;
                p4.Alignment = Element.ALIGN_LEFT;
                p8.Alignment = Element.ALIGN_LEFT;
                Paragraph Enter = new Paragraph("             ");
                Paragraph p7 = new Paragraph($"   PHIẾU TRẢ SÁCH - {MaDocGia}", f2);
                p7.Alignment = Element.ALIGN_CENTER;
                PdfPTable table = new PdfPTable(5);
                table.DefaultCell.Padding = 3;
                table.DefaultCell.MinimumHeight = 20;
                table.WidthPercentage = 100;
                table.HorizontalAlignment = Element.ALIGN_CENTER;
                table.DefaultCell.BorderWidth = 1;
                PdfPCell cellstt = new PdfPCell(new Phrase($"STT", f3));
                PdfPCell cellms = new PdfPCell(new Phrase($"Mã sách", f3));
                PdfPCell cellnm = new PdfPCell(new Phrase($"Ngày mượn", f3));
                PdfPCell cellsnm = new PdfPCell(new Phrase($"Số ngày mượn", f3));
                PdfPCell celltp = new PdfPCell(new Phrase($"Tiền phạt", f3));
                cellstt.BackgroundColor = new BaseColor(178, 255, 178);
                cellms.BackgroundColor = new BaseColor(178, 255, 178);
                cellnm.BackgroundColor = new BaseColor(178, 255, 178);
                cellsnm.BackgroundColor = new BaseColor(178, 255, 178);
                celltp.BackgroundColor = new BaseColor(178, 255, 178);
                table.AddCell(cellstt);
                table.AddCell(cellms);
                table.AddCell(cellnm);
                table.AddCell(cellsnm);
                table.AddCell(celltp);
                int i = 1;
              //  var dss = from z in qltv.MuonSaches where z.MaDocGia == MaDocGia && z.NgayMuon == NgayMuon select z;
                for(i=1;i<=Dsss.Items.Count;i++)
                {
                    table.AddCell(new Phrase((i).ToString(), f3));
                    table.AddCell(new Phrase(Dsss.Items[i - 1].SubItems[0].Text, f3));
                    table.AddCell(new Phrase(Dsss.Items[i - 1].SubItems[1].Text, f3));
                    table.AddCell(new Phrase(Dsss.Items[i - 1].SubItems[2].Text, f3));
                    table.AddCell(new Phrase(Dsss.Items[i - 1].SubItems[3].Text, f3));
                }
             //   MessageBox.Show($"{i.ToString()}");
                while (i < 6)
                {
                    table.AddCell(new Phrase((i).ToString(), f3));
                    table.AddCell(new Phrase("    ", f3));
                    table.AddCell(new Phrase("    ", f3));
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
        private void xuatTra_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
