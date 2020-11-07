using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using data = System.Data.DataTable;

namespace QLDG
{
    public partial class QLDG : Form
    {
        public QLDG()
        {
            InitializeComponent();
        }
       // SqlConnection con;
        QuanLyTV qltv = new QuanLyTV();
        public string NV="E.001";
        public bool check =false;
        // tạo biến để kiểm tra đúng sau khi nhấn button 
        bool pname = false;
        bool paddress = false;
        bool pmail = false;
        bool pdate = false;
        bool dn = false;
        bool mk = false;
        bool dt = false;

        int SizeBang;
        //===================================bổ trợ======================
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                var returnImage = Image.FromStream(ms);

                return returnImage;
            }
        }
        public bool KiemTraSach(string txt_muonSach)
        {
            var sach = qltv.DanhSachSaches.SingleOrDefault(p => p.MaSach == txt_muonSach);
            if (sach != null)
            {
                if (sach.TinhTrang == "Còn") return true;
            }
            return false;
        }
        public bool KiemtraSachQuaHanCuaNguoiMuon(string txt_muonDG)
        {
            var dss = from z in qltv.MuonSaches where z.MaDocGia == txt_muonDG select z;
            foreach (var item in dss)
            {
                DateTime data1 = DateTime.Today;
                DateTime date2 = item.NgayMuon.Value;
                if (((TimeSpan)(data1 - date2)).Days > 7) return false;
            }
            return true;
        }
        public bool KiemTraSoSachMuonTrong4ngay(string txt_muonDG)
        {
            int dem = 0;
            DateTime Now = DateTime.Today;
            DateTime Last = Now.AddDays(-4);
            var dss = from z in qltv.MuonSaches where z.MaDocGia == txt_muonDG select z;
            foreach (var item in dss)
            {
                if (item.NgayMuon >= Last && item.NgayMuon <= Now)
                {
                    dem++;
                }
            }
            return dem<5;
        }
        int i = 1;
        public string TaoMa()
        {
            if (i < 10) return $"L.00{i.ToString()}";
            else if (i < 100) return $"L.0{i.ToString()}";
            else return $"L.{i.ToString()}";
        }
        public void HienThiKho()
        {
            var dsk = from item in qltv.DanhSachSaches from a in qltv.HoSoes where a.MaNV==item.MaNgNhan select new { ms = item.MaSach, tens = item.TenSach,tt = item.TinhTrang};
            dataSachMuon.DataSource = dsk.ToList();
            dataSachMuon.Columns[0].HeaderText = "Mã sách";
            dataSachMuon.Columns[1].HeaderText = "Tên sách";
            dataSachMuon.Columns[2].HeaderText = "Tình trạng";
        }
        public void Hienthi()
        {
            var dsdg = from item in qltv.TheDocGias from a in qltv.HoSoes where a.MaNV==item.MaNgLap select new {ma=item.MS, hoten=item.HoTen,ns =item.NgaySinh,dc = item.DiaChi,e=item.Email,nlt=item.NgayLapThe,n=item.TongNo,tnl=a.HoTen };
            dataTheDocGia.DataSource = dsdg.ToList();
            dataTheDocGia.Columns[0].HeaderText = "Mã độc giả";
            dataTheDocGia.Columns[1].HeaderText = "Họ và tên";
            dataTheDocGia.Columns[2].HeaderText = "Ngày sinh";
            dataTheDocGia.Columns[3].HeaderText = "Địa chỉ";
            dataTheDocGia.Columns[4].HeaderText = "Email";
            dataTheDocGia.Columns[5].HeaderText = "Ngày lập thẻ";
            dataTheDocGia.Columns[6].HeaderText = "Tổng nợ";
            dataTheDocGia.Columns[7].HeaderText = "Người lập thẻ";
            dataTheDocGia.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataTheDocGia.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";

        }
        void GoiY()
        {
            string sachvip = "";
            var sach = from i in qltv.DanhSachSaches where i.DanhGia >= 4.3 && i.TinhTrang == "Còn" select i;
            foreach (var i in sach)
            {
                sachvip += i.MaSach + "\n" + i.TenSach + "\n --------------------------------------------\n";
            }
            //MessageBox.Show(sachvip);
            richTextBox1.Text = sachvip;
        }
        public void Set_true()
        {
            pname = true;
            paddress = true;
            pmail = true;
            pdate = true;
            er.SetError(f2Name, null);
        }
        public void Set_false()
        {
            Tick.Clear();
            pname = false;
            paddress = false;
            pmail = false;
            pdate = false;
            er.SetError(f2Name, null);
            buttonSua.Enabled = false;
        }
        void Reset_ThuocTinh()
        {
            f2Name.Text = "";
            f2Address.Text = "";
            f2Email.Text = "";
            textMS.Text = "";
            
        }
        public void ThongKe()
        {
            double thongke = (double)((SizeBang - 1) * 0.2);
            progressBar_thongke.Value = (int)Math.Round(thongke, 0);
            label_thongke.Text = $"{(SizeBang - 1).ToString()}/500";
        }
        //=========================================== Xử lý =================
        private void f2Name_Leave(object sender, EventArgs e)
        {
            /* if (f2Name.Text.Length != 0)
             {
                 string fullname = f2Name.Text;
                 string space = " ";
                 // Xử lý cắt dấu cách đầu tên
                 bool dau = false; //dung de check dau cach dung dau
                 for (int i = 0; i < fullname.Length && dau == false; i++)
                 {
                     if (fullname[i] == ' ' && dau == false)
                     {
                         fullname = fullname.Remove(i, 1);
                         i = -1;
                     }
                     else dau = true;
                 }
                 if (f2Name.Text.Length == 0)
                 {
                     er.SetError(this.f2Name, "Vui lòng nhập lại!");
                     pname = false;
                 }
                 //Xử lý cắt dấu cách cuối tên 
                 bool cuoi = false;
                 for (int i = fullname.Length - 1; i >= 0 && cuoi == false; i--)
                 {
                     if (fullname[i] == ' ' && cuoi == false)
                     {
                         fullname = fullname.Remove(fullname.Length - 1, 1);
                         i = fullname.Length;
                     }
                     else cuoi = true;
                 }
                 if (f2Name.Text.Length == 0)
                 {
                     er.SetError(this.f2Name, "Vui lòng nhập lại!");
                     pname = false;
                 }
                 f2Name.Text = fullname; // gán lại chuỗi sau khi sửa
                 //Tiếp tục check phần ký tự
                 for (int i = 0; i < f2Name.Text.Length; i++)
                 {
                     if (f2Name.Text[i] >= 33 && f2Name.Text[i] <= 57 || f2Name.Text[i] >= 58 && f2Name.Text[i] <= 64 || f2Name.Text[i] >= 91 && f2Name.Text[i] <= 96 || f2Name.Text[i] >= 123 && f2Name.Text[i] <= 126)
                     {
                         f2Name.Text = f2Name.Text.Remove(i, 1);
                         i = -1;
                     }
                 }
                 if (f2Name.Text.Length == 0)
                 {
                     Tick.Clear();
                     er.SetError(this.f2Name, "Vui lòng nhập lại!");
                     pname = false;
                 }
                 if (f2Name.Text.Length != 0)
                 {
                     er.Clear();
                     int slc = 1;
                     for (int i = 0; i < f2Name.Text.Length; i++)
                         if (f2Name.Text[i] == ' ') slc++;
                     string[] parts = f2Name.Text.Split(new string[] { space }, StringSplitOptions.RemoveEmptyEntries);
                     f2Name.Text = "";
                     bool hetchu = false;
                     for (int i = 0; i < slc; i++)
                     {
                         parts[i] = parts[i].Substring(0, 1).ToUpper() + parts[i].Substring(1, parts[i].Length - 1).ToLower();
                         f2Name.Text = f2Name.Text + parts[i];
                         if (i >= 0 && i < slc) hetchu = true;
                         if (hetchu == true) f2Name.Text += " ";
                     }
                 }
             }
             if (f2Name.Text.Length == 0)
             {
                 Tick.Clear();
                 er.SetError(this.f2Name, "Bạn chưa nhập tên! ");
                 pname = false;
             }
             else
             {
                 er.Clear();
                 Tick.SetError(f2Name, "xong");
                 pname = true;

             }*/
            if (f2Name.Text.Length != 0)
            {
                char[] trimChars = { '\\', '|', '\'', ' ', '@', ' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '_', '+', '[', '{', ']', '}', ';', ':', '"', ',', '<', '.', '>', '/', '?' };
                f2Name.Text = f2Name.Text.Trim(trimChars);
                int slc = 0;
                bool c = false;
                for (int i = 0; i < f2Name.Text.Length; i++)
                {
                    if (f2Name.Text[i] >= 33 && f2Name.Text[i] <= 57 || f2Name.Text[i] >= 58 && f2Name.Text[i] <= 64 || f2Name.Text[i] >= 91 && f2Name.Text[i] <= 96 || f2Name.Text[i] >= 123 && f2Name.Text[i] <= 126)
                    {
                        f2Name.Text = f2Name.Text.Remove(i, 1);
                        i = -1;
                    }
                }
                for (int i = 0; i < f2Name.Text.Length; i++)
                {
                    if (c != true && f2Name.Text[i] >= 'a' && f2Name.Text[i] <= 'z' || c != true && f2Name.Text[i] >= 'A' && f2Name.Text[i] <= 'Z')
                    {
                        slc++;
                        c = true;
                    }
                    if (f2Name.Text[i] == ' ' && c == true)
                    {
                        c = false;
                    }
                }
                for (int i = 0; i < f2Name.Text.Length; i++)
                {
                    if (f2Name.Text[i] == ' ' && f2Name.Text[i + 1] == ' ')
                    {
                        f2Name.Text = f2Name.Text.Remove(i, 1);
                    }
                }
                c = false;
                string x = "";
                string xx = "";
                for (int i = 0; i < f2Name.Text.Length; i++)
                {
                    if (c == false && f2Name.Text[i] >= 127 || c == false && f2Name.Text[i] >= 'a' && f2Name.Text[i] <= 'z' || c == false && f2Name.Text[i] >= 'A' && f2Name.Text[i] <= 'Z')
                    {
                        x += f2Name.Text[i];
                    }
                    if (f2Name.Text[i] == ' ')
                    {
                        c = true;
                    }
                    if (c == true || i + 1 == f2Name.Text.Length)
                    {
                        x = x.Substring(0, 1).ToUpper() + x.Substring(1, x.Length - 1).ToLower();
                        slc--;
                        xx += x + " ";
                        x = "";
                        c = false;
                    }
                }
                f2Name.Text = xx.Trim();
            }
            if (f2Name.Text.Length == 0)
            {
                Tick.Clear();
                er.SetError(this.f2Name, "Vui lòng nhập lại!!");
                pname = false;
            }
            else
            {
                er.Clear();
                Tick.SetError(f2Name, "You passed!");
                pname = true;
            }
        }

        private void f2NgaySinh_Leave(object sender, EventArgs e)
        {
            if (DateTime.Now.Year - f2NgaySinh.Value.Year >= 18 && DateTime.Now.Year - f2NgaySinh.Value.Year <= 55)
            {
                pdate = true;
                er.Clear();
                Tick.SetError(f2NgaySinh, "xong");

            }
            else
            {
                Tick.Clear();
                er.SetError(f2NgaySinh, "Độ tuổi yêu cầu từ 18 đến 55!!");
                pdate = false;
            }
        }

        private void f2Address_Leave(object sender, EventArgs e)
        {

            if (f2Address.Text.Length == 0)
            {
                Tick.Clear();
                er.SetError(this.f2Address, "Bạn chưa nhập địa chỉ! ");
                paddress = false;
            }
            else
            {
                er.Clear();
                Tick.SetError(f2Address, "xong");
                paddress = true;

            }
        }

        private void f2Email_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(f2Email.Text, @"^([a-zA-Z0-9]+)@([a-zA-Z0-9]+)\.(([a-zA-Z0-9])+)$"))
            {
                er.Clear();
                Tick.SetError(f2Email, "xong");
                pmail = true;
            }
            else
            {
                pmail = false;
                Tick.Clear();
                er.SetError(this.f2Email, "Bạn nhập sai định dạng  email! ");             }
        }
        private void QLDG_Load(object sender, EventArgs e)
        {
            // MessageBox.Show($"{NV}");
            if (!check)
            {
                HoSo x = qltv.HoSoes.SingleOrDefault(p => p.MaNV == NV);
                tt_Ten.Text = x.HoTen;
                tt_ngaysinh.Text = x.NgaySinh.Value.ToString("dd/MM/yyyy");
                tt_diachi.Text = x.DiaChi;
                tt_dienthoai.Text = x.DienThoai;
                tt_bangcap.Text = x.BangCap;
                tt_nlv.Text = x.NgayLamViec.Value.ToString("dd/MM/yyyy");
                TaiKhoanNV y = qltv.TaiKhoanNVs.SingleOrDefault(p => p.MaNV == NV);
                tt_tenDN.Text = y.TenDN;
                tt_Matkhau.Text = y.MatKhau;
                tt_mnv.Text = y.MaNV;
                tt_tenDN.Enabled = true;
                tt_Matkhau.Enabled = true;
                tt_dienthoai.Enabled = true;
                LuuThayDoi.Enabled = true;
            }
            Hienthi();
            HienThiKho();
            GoiY();
            SizeBang = dataTheDocGia.Rows.Count+1;
            f2NgaySinh.Text = DateTime.Today.ToString();
            foreach(var item in qltv.TheDocGias)
            {
                txt_muonDG.Items.Add(item.MS.ToString());
                comboBox_MDG.Items.Add(item.MS.ToString());
                comboBox_MDGmat.Items.Add(item.MS.ToString());
            } 
            for (int k = 0; k < dataTheDocGia.Rows.Count - 1; k++)
            {
                string chuoi = dataTheDocGia.Rows[k].Cells[0].Value.ToString();
                string chuoi_so = chuoi.Substring(2);
                int so = int.Parse($"{chuoi_so}");
                if (so != i) break;
                else i++;
            }
            er.SetError(f2Name, null);
            buttonSua.Enabled = false;
            buttonXoa.Enabled = false;
            label_NoMuon.Text = "";
            label_TongNo_mat.Text = "";
            ThongKe();
        }
        private void buttonSign_up_Click(object sender, EventArgs e)
        {
            if (paddress == true && pdate == true && pmail == true && pname == true )
            {

                i++;
                TheDocGia x = new TheDocGia();
                x.MS = TaoMa(); x.HoTen = f2Name.Text; x.NgaySinh = f2NgaySinh.Value; x.DiaChi = f2Address.Text; x.Email = f2Email.Text; x.NgayLapThe = DateTime.Today; x.TongNo = 0; x.MaNgLap = NV;
                qltv.TheDocGias.Add(x);
                qltv.SaveChanges();
                try
                 {
                    
                    MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    Reset_ThuocTinh();
                    Set_false();
                    SizeBang++;
                    ThongKe();
                    Hienthi();
                  }
                  catch
                  {
                    MessageBox.Show("Đăng kí thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
            }
            else MessageBox.Show("Đăng kí thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataTheDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           try
            {
                buttonSua.Enabled = true;
                buttonXoa.Enabled = true;
                f2Name.Text = dataTheDocGia.SelectedCells[1].Value.ToString();
                f2Address.Text = dataTheDocGia.SelectedCells[3].Value.ToString();
                f2Email.Text = dataTheDocGia.SelectedCells[4].Value.ToString();
                f2NgaySinh.Value = DateTime.Parse(dataTheDocGia.SelectedCells[2].Value.ToString());
                textMS.Text = dataTheDocGia.SelectedCells[0].Value.ToString();
                buttonSign_up.Enabled = false;
                Set_true();
            }
            catch
            {
                buttonSua.Enabled = false;
                buttonXoa.Enabled = false;
                buttonSign_up.Enabled = true;
                Reset_ThuocTinh();
                Set_false();
                Hienthi();
                f2NgaySinh.Value = DateTime.Now;
           }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (paddress == true && pdate == true && pmail == true && pname == true )
            {
                er.SetError(f2Name, null);
                TheDocGia x = qltv.TheDocGias.SingleOrDefault(p => p.MS == textMS.Text);
                 x.HoTen = f2Name.Text; x.NgaySinh = f2NgaySinh.Value; x.DiaChi = f2Address.Text; x.Email = f2Email.Text;
                try
                {
                    qltv.TheDocGias.AddOrUpdate(x);
                    qltv.SaveChanges();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hienthi();

                }
                catch
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonTìm_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) MessageBox.Show("Vui lòng chọn phương thức tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (comboBox1.SelectedIndex == 3)
            {
                buttonSua.Enabled = false;
                buttonXoa.Enabled = false;
                buttonSign_up.Enabled = true;
                Reset_ThuocTinh();
                Set_false();
                Hienthi();
                f2NgaySinh.Value = DateTime.Now;
            }
            else
            {
                var ds = from item in qltv.TheDocGias select item;
                List<TheDocGia> tim = new List<TheDocGia>();
                if (comboBox1.SelectedIndex == 0)
                {
                    foreach(TheDocGia item in ds)
                    {
                        if (item.MS == text_tìm.Text) tim.Add(item);
                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    foreach (TheDocGia item in ds)
                    {
                        if (item.HoTen.Contains(text_tìm.Text)) tim.Add(item);
                    }
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    foreach (TheDocGia item in ds)
                    {
                        if ((DateTime.Today - item.NgayLapThe).Value.Days >= 180) tim.Add(item);
                    }
                }
                var dsdg = from item in tim from a in qltv.HoSoes where a.MaNV == item.MaNgLap select new { ma = item.MS, hoten = item.HoTen, ns = item.NgaySinh, dc = item.DiaChi, e = item.Email, nlt = item.NgayLapThe, n = item.TongNo, tnl = a.HoTen };
                dataTheDocGia.DataSource = dsdg.ToList();
                dataTheDocGia.Columns[0].HeaderText = "Mã độc giả";
                dataTheDocGia.Columns[1].HeaderText = "Họ và tên";
                dataTheDocGia.Columns[2].HeaderText = "Ngày sinh";
                dataTheDocGia.Columns[3].HeaderText = "Địa chỉ";
                dataTheDocGia.Columns[4].HeaderText = "Email";
                dataTheDocGia.Columns[5].HeaderText = "Ngày lập thẻ";
                dataTheDocGia.Columns[6].HeaderText = "Tổng nợ";
                dataTheDocGia.Columns[7].HeaderText = "Người lập thẻ";
                dataTheDocGia.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataTheDocGia.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (paddress == true && pdate == true && pmail == true && pname == true  )
            {
                var x = new XuatThe();
                x.MS = textMS.Text;
                x.Ten = f2Name.Text;
                x.DiaChi = f2Address.Text;
                x.NgayLapThe = dataTheDocGia.SelectedCells[5].Value.ToString();
                x.NgaySinh = f2NgaySinh.Value.ToString("dd/MM/yyyy");
                x.Email = f2Email.Text;
                x.NgLap= dataTheDocGia.SelectedCells[7].Value.ToString();
               this.Hide();
                x.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Có thật sự muốn xóa \"{textMS.Text}-{f2Name.Text}\"", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {

                var x = qltv.TheDocGias.SingleOrDefault(p => p.MS == textMS.Text);
                qltv.TheDocGias.Remove(x);
                qltv.SaveChanges();
                Hienthi();
                Reset_ThuocTinh();
                SizeBang--;
                ThongKe();
            }
        }
        private void button_muonlammoi_Click(object sender, EventArgs e)
        {
            
        }
        
        private void button_themmuon_Click(object sender, EventArgs e)
        {
            bool kt = true;
            GoiY();
            if (txt_muonDG.Text.Length != 0 && txt_muonSach.Items.Count != 0)
            {
                foreach (string muonSach in txt_muonSach.Items)
                {
                    TheDocGia x = new TheDocGia();
                    TheDocGia dg = qltv.TheDocGias.SingleOrDefault(p => p.MS == txt_muonDG.Text);
                    if (dg != null)
                    {
                        DateTime data1 = DateTime.Today;
                        DateTime data2 = dg.NgayLapThe.Value;
                        if (((TimeSpan)(data1 - data2)).Days > 180)
                        {
                            MessageBox.Show("Thẻ đã hết hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            kt = false;
                            break;
                        }
                        else if(dg.TongNo > 1000000)
                        {
                            MessageBox.Show("Nợ quá cho phép (hơn 1 triệu)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            kt = false;
                            break;
                        } 
                        else
                        {
                            if (KiemTraSach(muonSach))
                            {
                                if (KiemtraSachQuaHanCuaNguoiMuon(txt_muonDG.Text))
                                {
                                    if (KiemTraSoSachMuonTrong4ngay(txt_muonDG.Text))
                                    {
                                        DanhSachSach sach = qltv.DanhSachSaches.SingleOrDefault(p => p.MaSach == muonSach);
                                        sach.TinhTrang = "Không có";
                                        string ngay = DateTime.Today.ToString("MM/yyyy");
                                        var ls = qltv.LichSuMuons.SingleOrDefault(p => p.TheLoai == sach.TheLoai && p.Thang == ngay);
                                        if (ls == null)
                                        {
                                            LichSuMuon lsm = new LichSuMuon();
                                            lsm.TheLoai = sach.TheLoai;
                                            lsm.Thang = DateTime.Today.ToString("MM/yyyy");
                                            lsm.SoLuot = 1;
                                            qltv.LichSuMuons.Add(lsm);
                                        }
                                        else
                                        {
                                            ls.SoLuot += 1;
                                            qltv.LichSuMuons.AddOrUpdate(ls);
                                        }
                                        qltv.DanhSachSaches.AddOrUpdate(sach);
                                        MuonSach xy = new MuonSach();
                                        xy.MaDocGia = txt_muonDG.Text;
                                        xy.MaSach = muonSach;
                                        xy.NgayMuon = DateTime.Today;
                                        try
                                        {
                                            qltv.MuonSaches.AddOrUpdate(xy);
                                            qltv.SaveChanges();
                                            txt_muonSach.Text = "";
                                            HienThiKho();

                                        }
                                        catch
                                        {
                                            MessageBox.Show("Đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        //kt = false;
                                        MessageBox.Show("Không thể mượn thêm được nữa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        break;

                                    }
                                }
                                else
                                {

                                    //  kt = false;
                                    MessageBox.Show("Đã có sách quá hạn chưa trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                }
                            }
                            else MessageBox.Show($"Mã sách {muonSach} không tồn tại hoặc đã mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thông tin không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        kt = false;
                        break;
                    }
                }
                if (kt)
                {
                    if (MessageBox.Show("Có xuất phiếu mượn không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    {
                        var x = new PhieuMuon();
                        x.MaDocGia = txt_muonDG.Text;
                        this.Hide();
                        x.ShowDialog();
                        this.Show();
                    }
                }
                
            }
            else MessageBox.Show("Thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txt_muonDG.SelectedIndex = -1;
            txt_muonSach.Items.Clear();
            txt_muonSach.Enabled = true;
            txt_muonDG.Enabled = true;
        }

        private void button_muonTimSach_Click(object sender, EventArgs e)
        {
            if (comboBox_muonTimSach.SelectedIndex == -1) MessageBox.Show("Vui lòng chọn cách tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (comboBox_muonTimSach.SelectedIndex == 5)
            {
                HienThiKho();
            }
            else
            {
                var dsss = from s in qltv.DanhSachSaches select s;
                List<DanhSachSach> tim = new List<DanhSachSach>();
                if (comboBox_muonTimSach.SelectedIndex == 0) {
                    foreach (DanhSachSach item in dsss)
                    {
                        if (item.MaSach == txt_muontimSach.Text) tim.Add(item);
                    }
                }
                else if (comboBox_muonTimSach.SelectedIndex == 1)
                {
                    foreach (DanhSachSach item in dsss)
                    {
                        if (item.TenSach.Contains(txt_muontimSach.Text)) tim.Add(item);
                    }
                }
                else if (comboBox_muonTimSach.SelectedIndex == 2)
                {
                    foreach (DanhSachSach item in dsss)
                    {
                        if (item.TheLoai== txt_muontimSach.Text) tim.Add(item);
                    }
                }
                else if (comboBox_muonTimSach.SelectedIndex == 3)
                {
                    foreach (DanhSachSach item in dsss)
                    {
                        if (item.TacGia.Contains(txt_muontimSach.Text)) tim.Add(item);
                    }
                }
                else
                {
                    foreach (DanhSachSach item in dsss)
                    {
                        if (DateTime.Today.Year - item.NamXuatBan > 8) tim.Add(item);
                    }
                }
                var dsk = from item in tim select new { ms = item.MaSach, tens = item.TenSach, tt = item.TinhTrang };
                dataSachMuon.DataSource = dsk.ToList();
                dataSachMuon.Columns[0].HeaderText = "Mã sách";
                dataSachMuon.Columns[1].HeaderText = "Tên sách";
                dataSachMuon.Columns[2].HeaderText = "Tình trạng";
            }
        }
         private void dataSachMuon_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txt_muonSach.Items.Add(dataSachMuon.SelectedCells[0].Value.ToString());
                
            }
            catch
            {
                MessageBox.Show("Không thể lấy mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_muonSach_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txt_muonSach.Items.RemoveAt(txt_muonSach.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Không thể truy cập dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tt_tenDN_Leave(object sender, EventArgs e)
        {
            if (tt_tenDN.Text.Length == 0)
            {
                Tick.Clear();
                er.SetError(this.tt_tenDN, "Bạn chưa nhập tên đăng nhập! ");
                dn = false;
            }
            else if (Regex.IsMatch(tt_tenDN.Text, "^[a-zA-Z0-9]*$"))
            {
                er.Clear();
                Tick.SetError(tt_tenDN, "xong");
                dn = true;
            }
            else
            {
                Tick.Clear();
                er.SetError(tt_tenDN, "Không đúng dữ liệu nhập");
                dn = false;
            }
        }

        private void tt_Matkhau_Leave(object sender, EventArgs e)
        {
            if (tt_Matkhau.Text.Length == 0)
            {
                Tick.Clear();
                er.SetError(this.tt_Matkhau, "Bạn chưa nhập mật khẩu! ");
                mk = false;
            }
            else if (tt_Matkhau.Text.Length < 9)
            {
                Tick.Clear();
                er.SetError(tt_Matkhau, "Mật khẩu quá ngắn");
                mk = false;
            }
            else if (Regex.IsMatch(tt_Matkhau.Text, "^[!-~]*$"))
            {
                er.Clear();
                Tick.SetError(tt_Matkhau, "xong");
                mk = true;
            }
            else
            {
                Tick.Clear();
                er.SetError(tt_Matkhau, "Không đúng dữ liệu nhập");
                mk = false;
            }
        }
        private void tt_dienthoai_Leave(object sender, EventArgs e)
        {
            if (tt_dienthoai.Text.Length == 10)
            {
                if (tt_dienthoai.Text[0] == '0')
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (!(48 <= (int)tt_dienthoai.Text[i] && (int)tt_dienthoai.Text[i] <= 57))
                        {
                            Tick.Clear();
                            er.SetError(tt_dienthoai, "Có ký tự không phải số trong số điện thoại");
                            dt = false;
                            return;
                        }
                    }
                }
                else
                {
                    Tick.Clear();
                    er.SetError(tt_dienthoai, "Số điện thoại phải bắt đầu số 0 ");
                    dt = false;
                }
                er.Clear();
                Tick.SetError(tt_dienthoai, "Xong");
                dt = true;
            }
            else
            {
                Tick.Clear();
                er.SetError(tt_dienthoai, "Số điện thoại không đủ 10 chữ số");
                dt = false;
            }
        }
        private void LuuThayDoi_Click(object sender, EventArgs e)
        {
            if (dn == true && mk == true && dt == true )
            {
                TaiKhoanNV x = qltv.TaiKhoanNVs.SingleOrDefault(p => p.MaNV == NV);
                x.TenDN = tt_tenDN.Text;
                x.MatKhau = tt_Matkhau.Text;
                qltv.TaiKhoanNVs.AddOrUpdate(x);
                qltv.SaveChanges();
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void dataSachMat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int tongno = 0;
        private void button_trathanhtoan_Click(object sender, EventArgs e)
        {
            GoiY();
            tongno = 0;
            if (listBox_Tra.Items.Count != 0)
            {
                FormDanhGia danhGia = new FormDanhGia();
                danhGia.tra = listBox_Tra;
                danhGia.ShowDialog();
                ListViewItem dstra;
                foreach (string i in listBox_Tra.Items)
                {
                    string[] a = new string[5];
                    a[0] = i;
                    MuonSach sach = qltv.MuonSaches.SingleOrDefault(p => p.MaSach == i&&p.MaDocGia==comboBox_MDG.Text);
                    DanhSachSach dss = qltv.DanhSachSaches.SingleOrDefault(p => p.MaSach == i);
                    TraSach tra = new TraSach();
                    tra.MaDocGia = comboBox_MDG.Text;
                    tra.MaSach = i;
                    tra.NgayTra = DateTime.Today;
                    tra.SoNgayMuon = (DateTime.Today - sach.NgayMuon).Value.Days;
                    dss.TinhTrang = "Còn";
                    qltv.DanhSachSaches.AddOrUpdate(dss);
                    qltv.SaveChanges();
                    int songay = (DateTime.Today - sach.NgayMuon).Value.Days;
                    a[1] = sach.NgayMuon.Value.ToString("dd/MM/yyyy");
                    a[2] = songay.ToString();
                    if (songay <= 7)
                    {
                        a[3] = "0";
                        tra.TienPhat = 0;
                    }
                    else
                    {
                        a[3] = ((songay - 7) * 1000).ToString();
                        tongno += ((songay - 7) * 1000);
                        tra.TienPhat= ((songay - 7) * 1000);
                    }
                    qltv.TraSaches.AddOrUpdate(tra);
                    qltv.SaveChanges();
                    dstra = new ListViewItem(a);
                    listViewTra.Items.Add(dstra);
                }
                label_NoMuon.Text = $"{tongno.ToString()} đồng";
                TheDocGia dg = qltv.TheDocGias.SingleOrDefault(p => p.MS == comboBox_MDG.Text);
                dg.TongNo += tongno;
                qltv.TheDocGias.AddOrUpdate(dg);
                qltv.SaveChanges();
                if (MessageBox.Show("Thanh toán thành công. Có xuất phiểu trả không ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    PhieuTra phieuTra = new PhieuTra();
                    phieuTra.MaDocGia = comboBox_MDG.Text;
                    phieuTra.NgayTra = DateTime.Today;
                    phieuTra.Dsss = listViewTra;
                    phieuTra.TienPhat = tongno;
                    this.Hide();
                    phieuTra.ShowDialog();
                    this.Show();
                }
                listBox_Tra.Items.Clear();
                HienThiKho();
                Hienthi();
            }
            else MessageBox.Show("Thanh toán thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comboBox_MDG_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_MDG.Text != "")
            {
                listBox_MSach.Items.Clear();
                foreach(MuonSach item in qltv.MuonSaches)
                {
                    if (item.MaDocGia == comboBox_MDG.Text)
                    {
                        var sach = qltv.DanhSachSaches.SingleOrDefault(p => p.MaSach == item.MaSach);
                        if(sach.TinhTrang=="Không có") listBox_MSach.Items.Add(sach.MaSach);
                    }
                }
                comboBox_MDG.Enabled = false;
            }
        }

        private void listBox_MSach_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                listBox_Tra.Items.Add(listBox_MSach.SelectedItem);
                listBox_MSach.Items.RemoveAt(listBox_MSach.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Không thể truy cập dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBox_Tra_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                listBox_MSach.Items.Add(listBox_Tra.SelectedItem);
                listBox_Tra.Items.RemoveAt(listBox_Tra.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Không thể truy cập dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_L_Click(object sender, EventArgs e)
        {
            if (listBox_Tra.Items.Count != 0)
            {
                foreach(string i in listBox_Tra.Items)
                {
                    listBox_MSach.Items.Add(i);
                   // listBox_Tra.Items.RemoveAt(listBox_Tra.SelectedIndex);
                }
                listBox_Tra.Items.Clear();
            }
        }

        private void button_R_Click(object sender, EventArgs e)
        {
            if (listBox_MSach.Items.Count != 0)
            {
                foreach (string i in listBox_MSach.Items)
                {
                    listBox_Tra.Items.Add(i);
                   // listBox_MSach.Items.RemoveAt(listBox_MSach.SelectedIndex);
                }
                listBox_MSach.Items.Clear();
            }
        }

        private void button_Lammoi_Click(object sender, EventArgs e)
        {
            GoiY();
            comboBox_MDG.SelectedIndex = -1;
            comboBox_MDG.Enabled = true;
            listBox_MSach.Items.Clear();
            listBox_Tra.Items.Clear();
            listViewTra.Items.Clear();
            label_NoMuon.Text = "";
        }

        private void comboBox_MDGmat_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_MDGmat.Text != "")
            {
                listBox_MsachMat.Items.Clear();
                foreach (MuonSach item in qltv.MuonSaches)
                {
                    if (item.MaDocGia == comboBox_MDGmat.Text)
                    {
                        var sach = qltv.DanhSachSaches.SingleOrDefault(p => p.MaSach == item.MaSach);
                        if (sach.TinhTrang == "Không có") listBox_MsachMat.Items.Add(sach.MaSach);
                    }
                }
                comboBox_MDGmat.Enabled = false;
            }
        }

        private void button_L_mat_Click(object sender, EventArgs e)
        {
            if (listBox_Mat.Items.Count != 0)
            {
                foreach (string i in listBox_Mat.Items)
                {
                    listBox_MsachMat.Items.Add(i);
                    // listBox_Tra.Items.RemoveAt(listBox_Tra.SelectedIndex);
                }
                listBox_Mat.Items.Clear();
            }
        }

        private void button_R_mat_Click(object sender, EventArgs e)
        {
            if (listBox_MsachMat.Items.Count != 0)
            {
                foreach (string i in listBox_MsachMat.Items)
                {
                    listBox_Mat.Items.Add(i);
                    // listBox_MSach.Items.RemoveAt(listBox_MSach.SelectedIndex);
                }
                listBox_MsachMat.Items.Clear();
            }
        }

        private void listBox_MsachMat_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                listBox_Mat.Items.Add(listBox_MsachMat.SelectedItem);
                listBox_MsachMat.Items.RemoveAt(listBox_MsachMat.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Không thể truy cập dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBox_Mat_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                listBox_MsachMat.Items.Add(listBox_Mat.SelectedItem);
                listBox_Mat.Items.RemoveAt(listBox_Mat.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Không thể truy cập dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_Lammoi_mat_Click(object sender, EventArgs e)
        {
            comboBox_MDGmat.SelectedIndex = -1;
            comboBox_MDGmat.Enabled = true;
            listBox_MsachMat.Items.Clear();
            listBox_Mat.Items.Clear();
            listViewMat.Items.Clear();
            label_TongNo_mat.Text = "";
        }

        private void button_thanhtoan_mat_Click(object sender, EventArgs e)
        {
            tongno = 0;
            if (listBox_Mat.Items.Count != 0)
            {
                ListViewItem dsmat;
                foreach (string i in listBox_Mat.Items)
                {
                    string[] a = new string[4];
                    a[0] = i;
                    MuonSach sach = qltv.MuonSaches.SingleOrDefault(p => p.MaSach == i && p.MaDocGia == comboBox_MDGmat.Text);
                    DanhSachSach dss = qltv.DanhSachSaches.SingleOrDefault(p => p.MaSach == i);
                    MatSach mat = new MatSach();
                    dss.TinhTrang = "Mất";
                    double gia = (double)dss.TriGia;
                    mat.MaDocGia = comboBox_MDGmat.Text;
                    mat.MaNgGhiNhan = NV;
                    mat.MaSach = i;
                    mat.SoTienThu= int.Parse((gia * 1.2).ToString());
                    mat.NgayGhiNhan = DateTime.Today;
                    qltv.DanhSachSaches.AddOrUpdate(dss);
                    qltv.MatSaches.AddOrUpdate(mat);
                    qltv.SaveChanges();
                    a[1] = gia.ToString();
                    a[2] = (gia * 1.2).ToString();
                    tongno += int.Parse((gia * 1.2).ToString());
                    dsmat = new ListViewItem(a);
                    listViewMat.Items.Add(dsmat);
                }
                label_TongNo_mat.Text = $"{tongno.ToString()} đồng";
                TheDocGia dg = qltv.TheDocGias.SingleOrDefault(p => p.MS == comboBox_MDGmat.Text);
                dg.TongNo += tongno;
                qltv.TheDocGias.AddOrUpdate(dg);
                qltv.SaveChanges();
                if (MessageBox.Show("Thanh toán thành công. Có xuất phiểu trả không ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    PhieuMat phieuMat = new PhieuMat();
                    phieuMat.NgayGhiNhan = DateTime.Today;
                    phieuMat.Dsss = listViewMat;
                    phieuMat.MaDocGia = comboBox_MDGmat.Text;
                    phieuMat.TienPhat = tongno;
                    this.Hide();
                    phieuMat.ShowDialog();
                    this.Show();
                }
                listBox_Tra.Items.Clear();
                HienThiKho();
                Hienthi();
            }
            else MessageBox.Show("Thanh toán thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_Excel_Click(object sender, EventArgs e)
        {
            XuatBAng x = new XuatBAng();
            x.BangThongTin = dataTheDocGia;
            this.Hide();
            x.ShowDialog();
            this.Show();
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_MDG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataSachMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sach = dataSachMuon.SelectedCells[0].Value.ToString();
            var x = qltv.DanhSachSaches.SingleOrDefault(p => p.MaSach == sach);
            //MessageBox.Show($"{x.TenSach}");
            if (x.Anh != null) pictureBox1.Image = ByteArrayToImage(x.Anh);
            else pictureBox1.Image = null;
        }
    }
}
