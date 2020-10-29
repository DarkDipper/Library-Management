using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
        SqlConnection con;
        Model1 qltv = new Model1();
        public HoSo NV;
        // tạo biến để kiểm tra đúng sau khi nhấn button 
        bool pname = false;
        bool paddress = false;
        bool pcreater = false;
        bool ptype = false;
        bool pmail = false;
        bool pdate = false;
        bool dn = false;
        bool mk = false;
        int SizeBang;
        //===================================bổ trợ======================
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
            SqlCommand cmd = new SqlCommand("select MaSach as N'Mã sách'," +
                                          "TenSach as N'Tên sách'," +
                                          "TheLoai as N'Thể loại'," +
                                          "TacGia as N'Tác giả'," +
                                          "NamXuatBan as N'Năm xuất bản'," +
                                          "NhaXuatBan as N'Nhà xuất bản'," +
                                          "CONVERT (varchar(10), NgayNhap, 103) AS N'Ngày nhập'," +
                                          "TriGia as N'Trị giá'," +
                                          "TinhTrang as N'Tình trạng'," +
                                          "HoSo.HoTen as N'Họ và tên người nhận' " +
                                          "from DanhSachSach,HoSo " +
                                          "where DanhSachSach.MaNgNhan = HoSo.MaNV", con);
            SqlDataReader rd = cmd.ExecuteReader();
            data d = new data();
            d.Load(rd);
            dataSachMuon.DataSource = d;
        }
        public void HienThiMuon()
        {
            string sql_select = "select MaDocGia as N'Mã độc giả',MaSach as N'Mã sách',NgayMuon as N'Ngày mượn' from MuonSach";
            SqlCommand cmd = new SqlCommand(sql_select, con);
            SqlDataReader rd = cmd.ExecuteReader();
            data d = new data();
            d.Load(rd);
            dataPhieuMuon.DataSource = d;
        }
        public void Hienthi()
        {
            string sql_select = "select MS as N'Mã độc giả'," +
                "G.TenDN as N'Tên đăng nhập'," +
                "G.HoTen as N'Họ và tên'," +
                "CONVERT (varchar(10), G.NgaySinh, 103) AS N'Ngày sinh'," +
                "G.DiaChi as N'Địa chỉ'," +
                "G.Loai as N'Loại'," +
                "G.Email," +
                "CONVERT (varchar(10), G.NgayLapThe, 103) AS N'Ngày lập thẻ'," +
                "G.TongNo as N'Tổng nợ'," +
                "S.HoTen as N'Tên người lập' " +
                "from TheDocGia G,HoSo S where MaNgLap=MaNV ";
            SqlCommand cmd = new SqlCommand(sql_select, con);
            SqlDataReader rd = cmd.ExecuteReader();
            data d = new data();
            d.Load(rd);
            dataTheDocGia.DataSource = d;

        }
        public void HienthiDG()
        {
            string sql_select = "select MS as N'Mã độc giả'," +
                "G.TenDN as N'Tên đăng nhập'," +
                "G.HoTen as N'Họ và tên'," +
                "CONVERT (varchar(10), G.NgaySinh, 103) AS N'Ngày sinh'," +
                "G.DiaChi as N'Địa chỉ'," +
                "G.Loai as N'Loại'," +
                "G.Email," +
                "CONVERT (varchar(10), G.NgayLapThe, 103) AS N'Ngày lập thẻ'," +
                "G.TongNo as N'Tổng nợ'," +
                "S.HoTen as N'Tên người lập' " +
                "from TheDocGia G,HoSo S where MaNgLap=MaNV ";
            SqlCommand cmd = new SqlCommand(sql_select, con);
            SqlDataReader rd = cmd.ExecuteReader();
            data d = new data();
            d.Load(rd);
            dataDGMuon.DataSource = d;

        }
        public void Set_true()
        {
            pname = true;
            paddress = true;
            pcreater = true;
            ptype = true;
            pmail = true;
            pdate = true;
            dn = true;
            mk = true;
            er.SetError(f2Name, null);
        }
        public void Set_false()
        {
            Tick.Clear();
            pname = false;
            paddress = false;
            pcreater = false;
            ptype = false;
            pmail = false;
            pdate = false;
            dn = false;
            mk = false;
            er.SetError(f2Name, null);
            buttonSua.Enabled = false;
        }
        void Reset_ThuocTinh()
        {
            f2Name.Text = "";
            f2Address.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            f2Email.Text = "";
            f2Type.SelectedIndex = -1;
            textMS.Text = "";
        }
        public void ThongKe()
        {
            double thongke = (double)((SizeBang - 1) * 0.2);
            progressBar_thongke.Value = (int)Math.Round(thongke, 0);
            // MessageBox.Show($"{progressBar_thongke.Value.ToString()}");
            label_thongke.Text = $"{(SizeBang - 1).ToString()}/500";
        }
        //=========================================== Xử lý =================
        private void f2Name_Leave(object sender, EventArgs e)
        {
            if (f2Name.Text.Length != 0)
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
                // Xử lý phần dấu cách trước và sau chuỗi xong
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
                    //Đếm số lượng từ có trong tên để viết hoa chữ đầu  
                    int slc = 1;
                    for (int i = 0; i < f2Name.Text.Length; i++)
                        if (f2Name.Text[i] == ' ') slc++;
                    //Viết hoa chữ đầu và nhấn đầu chữ sau
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
                er.SetError(this.f2Email, "Bạn nhập sai định dạng  email! "); //Phản hồi ngay sau khi nhập sai email và leave 
                //pmail = true;
            }
        }

        private void f2Type_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(f2Type.Text))
            {
                er.SetError(this.f2Type, "Vui lòng chọn độc giả! ");
                ptype = false;
            }
            if (f2Type.Text != "X" && f2Type.Text != "Y")
            {
                er.SetError(this.f2Type, "Vui lòng chọn đúng loại đọc giả sẵn có! ");
                ptype = false;
            }
            else
            {
                er.SetError(this.f2Type, null);
                Tick.SetError(f2Type, "xong");
                //checkDocGia.Clear();
                ptype = true;

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                Tick.Clear();
                er.SetError(this.textBox2, "Bạn chưa nhập tên đăng nhập! ");
                dn = false;
            }
            else if (Regex.IsMatch(textBox2.Text, "^[a-zA-Z0-9]*$"))
            {
                er.Clear();
                Tick.SetError(textBox2, "xong");
                dn = true;
            }
            else
            {
                Tick.Clear();
                er.SetError(textBox2, "Không đúng dữ liệu nhập");
                dn = false;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                Tick.Clear();
                er.SetError(this.textBox1, "Bạn chưa nhập mật khẩu! ");
                mk = false;
            }
            else if (textBox1.Text.Length < 9)
            {
                Tick.Clear();
                er.SetError(textBox1, "Mật khẩu quá ngắn");
                mk = false;
            }
            else if (Regex.IsMatch(textBox1.Text, "^[!-~]*$"))
            {
                er.Clear();
                Tick.SetError(textBox1, "xong");
                mk = true;
            }
            else
            {
                Tick.Clear();
                er.SetError(textBox1, "Không đúng dữ liệu nhập");
                mk = false;
            }
        }

        private void QLDG_Load(object sender, EventArgs e)
        {
            
            this.ActiveControl = f2Name;  // Con trỏ đặt ngay tại Name 
            string conString = ConfigurationManager.ConnectionStrings["QuanLyDG"].ConnectionString.ToString();
            
            con = new SqlConnection(conString);
            con.Open();
            Hienthi();
            HienThiMuon();
            HienThiKho();
            HienthiDG();
            button_muonXoa.Enabled = false;
            SizeBang = dataTheDocGia.Rows.Count;
            f2NgaySinh.Text = DateTime.Today.ToString();
            for (int k = 0; k < dataTheDocGia.Rows.Count - 1; k++)
            {
                string chuoi = dataTheDocGia.Rows[k].Cells[0].Value.ToString();
                string chuoi_so = chuoi.Substring(2);
                // MessageBox.Show($"{chuoi_so}");
                int so = int.Parse($"{chuoi_so}");
                //MessageBox.Show($"{(so).ToString()}");
                if (so != i) break;
                else i++;
            }
            //MessageBox.Show($"{i.ToString()}");
            er.SetError(f2Name, null);
            buttonSua.Enabled = false;
            buttonXoa.Enabled = false;
            ThongKe();
        }

        private void QLDG_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Trở về \"Đăng nhập\" ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
                con.Close();
            }
        }

        private void buttonSign_up_Click(object sender, EventArgs e)
        {
            if (paddress == true && pdate == true && pmail == true && pname == true && dn == true && mk == true && ptype == true)
            {


                string sql_in = $@"Insert into TheDocGia values('{TaoMa()}','{textBox2.Text}','{textBox1.Text}',N'{f2Name.Text}','{f2NgaySinh.Value.ToString("yyyyMMdd")}',N'{f2Address.Text}','{f2Type.Text}','{f2Email.Text}','{DateTime.Today.ToString("yyyyMMdd")}',0,'{NV.MaNV}')";
                SqlCommand cmd = new SqlCommand(sql_in, con);
                 try
                 {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    Reset_ThuocTinh();
                    Set_false();
                    SizeBang++;
                    ThongKe();
                    Hienthi();
                    i++;
                  }
                  catch
                  {
                    MessageBox.Show("Đăng kí thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
            }
            else MessageBox.Show("Đăng kí thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        int dem = 0;
        private void button_Eye_Click(object sender, EventArgs e)
        {
            dem++;
            if (dem % 2 == 1) { textBox1.UseSystemPasswordChar = false; button_Eye.Image = global::QLDG.Properties.Resources._1490793853_user_interface15_82360; }
            else { textBox1.UseSystemPasswordChar = true; button_Eye.Image = global::QLDG.Properties.Resources._1490793864_user_interface16_82335; }
        }

        private void dataTheDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*select MS as N'Mã độc giả'," +
                "G.TenDN as N'Tên đăng nhập'," +
                "G.HoTen as N'Họ và tên'," +
                "CONVERT (varchar(10), G.NgaySinh, 103) AS N'Ngày sinh'," +
                "G.DiaChi as N'Địa chỉ'," +
                "G.Loai as N'Loại'," +
                "G.Email," +
                "CONVERT (varchar(10), G.NgayLapThe, 103) AS N'Ngày lập thẻ'," +
                "G.TongNo as N'Tổng nợ'," +
                "S.HoTen as N'Tên người lập' " +
                "from TheDocGia G,HoSo S where MaNgLap=MaNV ";*/
            try
            {
                buttonSua.Enabled = true;
                buttonXoa.Enabled = true;
                f2Name.Text = dataTheDocGia.SelectedCells[2].Value.ToString();
                f2Address.Text = dataTheDocGia.SelectedCells[4].Value.ToString();
                textBox2.Text = dataTheDocGia.SelectedCells[1].Value.ToString();
                f2Email.Text = dataTheDocGia.SelectedCells[6].Value.ToString();
                f2Type.Text = dataTheDocGia.SelectedCells[5].Value.ToString();
                f2NgaySinh.Value = DateTime.ParseExact(dataTheDocGia.SelectedCells[3].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                textMS.Text = dataTheDocGia.SelectedCells[0].Value.ToString();
                buttonSign_up.Enabled = false;
                //f2Type.Enabled = false;
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
            if (paddress == true && pdate == true && pmail == true && pname == true && dn == true && mk == true && ptype == true)
            {
                er.SetError(f2Name, null);
                string sql_ed = $"update TheDocGia set TenDN='{textBox2.Text}',HoTen=N'{f2Name.Text}',NgaySinh='{f2NgaySinh.Value.ToString("yyyyMMdd")}',DiaChi=N'{f2Address.Text}',Loai='{f2Type.Text}',Email='{f2Email.Text}',TongNo=0 where MS='{textMS.Text}'";
                SqlCommand cmd = new SqlCommand(sql_ed, con);
                try
                {
                    cmd.ExecuteNonQuery();
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
            else if (comboBox1.SelectedIndex == 4)
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
                string sqlFind = "select MS as N'Mã độc giả'," +
                "G.TenDN as N'Tên đăng nhập'," +
                "G.HoTen as N'Họ và tên'," +
                "CONVERT (varchar(10), G.NgaySinh, 103) AS N'Ngày sinh'," +
                "G.DiaChi as N'Địa chỉ'," +
                "G.Loai as N'Loại'," +
                "G.Email," +
                "CONVERT (varchar(10), G.NgayLapThe, 103) AS N'Ngày lập thẻ'," +
                "G.TongNo as N'Tổng nợ'," +
                "S.HoTen as N'Tên người lập' " +
                "from TheDocGia G,HoSo S where MaNgLap=MaNV ";
                if (comboBox1.SelectedIndex == 0) sqlFind += $"and MS ='{text_tìm.Text}'";
                else if (comboBox1.SelectedIndex == 1) sqlFind += $"and G.HoTen like N'%{text_tìm.Text}%'";
                else if (comboBox1.SelectedIndex == 2) sqlFind += $"and Loai ='{text_tìm.Text}'";
                else if (comboBox1.SelectedIndex == 3) sqlFind += $"and DATEDIFF(day,NgayLapThe,Getdate()) > 180";
                SqlCommand cmd = new SqlCommand(sqlFind, con);
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                data d = new data();
                d.Load(rd);
                dataTheDocGia.DataSource = d;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (paddress == true && pdate == true && pmail == true && pname == true && dn == true && mk == true && ptype == true)
            {
  /*                     public string MS;
        public string Ten;
        public string NgaySinh;
        public string NgayLapThe;
        public string Loai;
        public string DiaChi;
        public string Email;
        public string NgLap;*/
        var x = new XuatThe();
                x.MS = textMS.Text;
                x.Ten = f2Name.Text;
                x.Loai = f2Type.Text;
                x.DiaChi = f2Address.Text;
                x.NgayLapThe = dataTheDocGia.SelectedCells[7].Value.ToString();
                x.NgaySinh = f2NgaySinh.Value.ToString("dd/MM/yyyy");
                x.Email = f2Email.Text;
                x.NgLap= dataTheDocGia.SelectedCells[9].Value.ToString();
               this.Hide();
                x.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string sqlXoa;
            sqlXoa = $"DELETE FROM TheDocGia WHERE MS='{textMS.Text}'";
            if (MessageBox.Show($"Có thật sự muốn xóa \"{textMS.Text}-{f2Name.Text}\"", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand(sqlXoa, con);
                cmd.ExecuteNonQuery();
                Hienthi();
                Reset_ThuocTinh();
                SizeBang--;
                ThongKe();
            }
        }

        private void button_Excel_Click(object sender, EventArgs e)
        {
            var x = new XuatTable();
            x.BangThongTin = dataTheDocGia;
            this.Hide();
            x.ShowDialog();
            this.Show();
        }

        private void button_muonlammoi_Click(object sender, EventArgs e)
        {
            txt_muonDG.Text = "";
            txt_muonSach.Text = "";
            txt_muonSach.Enabled = true;
            txt_muonDG.Enabled = true;
            button_muonXoa.Enabled = false;

        }
        
        private void button_themmuon_Click(object sender, EventArgs e)
        {
            if (txt_muonDG.TextLength != 0 && txt_muonSach.TextLength != 0)
            {
                TheDocGia x = new TheDocGia();
                TheDocGia dg = qltv.TheDocGias.SingleOrDefault(p => p.MS == txt_muonDG.Text);
                if (dg != null)
                {
                    DateTime data1 = DateTime.Today;
                    DateTime data2 = dg.NgayLapThe.Value;
                    if(((TimeSpan)(data1-data2)).Days > 180) MessageBox.Show("Thẻ đã hết hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (KiemTraSach(txt_muonSach.Text))
                        {
                            if (KiemtraSachQuaHanCuaNguoiMuon(txt_muonDG.Text))
                            {
                                if (KiemTraSoSachMuonTrong4ngay(txt_muonDG.Text))
                                {
                                    DanhSachSach sach = qltv.DanhSachSaches.SingleOrDefault(p => p.MaSach == txt_muonSach.Text);
                                    sach.TinhTrang = "Không có";
                                    qltv.DanhSachSaches.AddOrUpdate(sach);
                                    string qin = $@"Insert into MuonSach values('{txt_muonDG.Text}','{txt_muonSach.Text}','{DateTime.Today.ToString("yyyyMMdd")}')";
                                    SqlCommand cmd = new SqlCommand(qin, con);
                                    try
                                    {
                                        cmd.ExecuteNonQuery();
                                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                        txt_muonSach.Text = "";
                                        HienThiMuon();
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else MessageBox.Show("Không thể mượn thêm được nữa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else MessageBox.Show("Đã có sách quá hạn chưa trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else MessageBox.Show("Sách không tồn tại hoặc đã mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else MessageBox.Show("Thông tin không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string sql_find = "select MaSach as N'Mã sách'," +
                                           "TenSach as N'Tên sách'," +
                                           "TheLoai as N'Thể loại'," +
                                           "TacGia as N'Tác giả'," +
                                           "NamXuatBan as N'Năm xuất bản'," +
                                           "NhaXuatBan as N'Nhà xuất bản'," +
                                           "CONVERT (varchar(10), NgayNhap, 103) AS N'Ngày nhập'," +
                                           "TriGia as N'Trị giá'," +
                                           "TinhTrang as N'Tình trạng'," +
                                           "HoSo.HoTen as N'Họ và tên người nhận' " +
                                           "from DanhSachSach,HoSo " +
                                           "where DanhSachSach.MaNgNhan = HoSo.MaNV";
                if (comboBox_muonTimSach.SelectedIndex == 0) sql_find += $" and MaSach='{txt_muontimSach.Text}'";
                else if (comboBox_muonTimSach.SelectedIndex == 1) sql_find += $" and TenSach like N'%{txt_muontimSach.Text}%'";
                else if (comboBox_muonTimSach.SelectedIndex == 2) sql_find += $" and TheLoai='{txt_muontimSach.Text}'";
                else if (comboBox_muonTimSach.SelectedIndex == 3) sql_find += $" and TacGia like N'%{txt_muontimSach.Text.Trim()}%'";
                else sql_find += $" and YEAR(GETDATE())-NamXuatBan > 8";
                SqlCommand cmd = new SqlCommand(sql_find, con);
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                data d = new data();
                d.Load(rd);
                dataSachMuon.DataSource = d;
            }
        }

        private void comboBox_muontimPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_muontimPhieu.SelectedIndex == 0)
            {
                txt_muonDG.Enabled = true;
                txt_muonSach.Enabled = false;
            }
            else if (comboBox_muontimPhieu.SelectedIndex == 1)
            {
                txt_muonDG.Enabled = false;
                txt_muonSach.Enabled = true;
            }
            else
            {
                txt_muonDG.Enabled = true;
                txt_muonSach.Enabled = true;
                button_muonXoa.Enabled = false;
                txt_muonDG.Text = "";
                txt_muonSach.Text = "";
            }
        }

        private void button_muonTim_Click(object sender, EventArgs e)
        {
            if (comboBox_muontimPhieu.SelectedIndex == -1) MessageBox.Show("Vui lòng chọn cách tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (comboBox_muontimPhieu.SelectedIndex == 2)
            {
                HienThiMuon();
            }
            else
            {
                string sql_find = "select MaDocGia as N'Mã độc giả',MaSach as N'Mã sách',NgayMuon as N'Ngày mượn' from MuonSach";
                if (comboBox_muontimPhieu.SelectedIndex == 0) sql_find += $" where MaDocGia='{txt_muonDG.Text}'";
                else if (comboBox_muontimPhieu.SelectedIndex == 1) sql_find += $" where MaSach = '{txt_muonSach.Text}'";
                SqlCommand cmd = new SqlCommand(sql_find, con);
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                data d = new data();
                d.Load(rd);
                dataPhieuMuon.DataSource = d;
            }
        }

        private void txt_muonDG_Leave(object sender, EventArgs e)
        {
            string sql_select = "select MS as N'Mã độc giả'," +
                "G.TenDN as N'Tên đăng nhập'," +
                "G.HoTen as N'Họ và tên'," +
                "CONVERT (varchar(10), G.NgaySinh, 103) AS N'Ngày sinh'," +
                "G.DiaChi as N'Địa chỉ'," +
                "G.Loai as N'Loại'," +
                "G.Email," +
                "CONVERT (varchar(10), G.NgayLapThe, 103) AS N'Ngày lập thẻ'," +
                "G.TongNo as N'Tổng nợ'," +
                "S.HoTen as N'Tên người lập' " +
                $"from TheDocGia G,HoSo S where MaNgLap=MaNV and MS='{txt_muonDG.Text}'";
            SqlCommand cmd = new SqlCommand(sql_select, con);
            SqlDataReader rd = cmd.ExecuteReader();
            data d = new data();
            d.Load(rd);
            dataDGMuon.DataSource = d;
        }

        private void button_muonXoa_Click(object sender, EventArgs e)
        {
            if (txt_muonDG.TextLength != 0 && txt_muonSach.TextLength != 0)
            {
                string sqlXoa;
                sqlXoa = $"DELETE FROM MuonSach WHERE MaSach='{txt_muonSach.Text}'and MaDocGia = '{txt_muonDG.Text}'";
                if (MessageBox.Show($"Có thật sự muốn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand(sqlXoa, con);
                    cmd.ExecuteNonQuery();
                    HienThiMuon();
                    DanhSachSach sach = qltv.DanhSachSaches.SingleOrDefault(p => p.MaSach == txt_muonSach.Text);
                    sach.TinhTrang = "Còn";
                    qltv.DanhSachSaches.AddOrUpdate(sach);
                }
            }
        }

        private void dataPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_muonDG.Text = dataPhieuMuon.SelectedCells[0].Value.ToString();
                txt_muonSach.Text = dataPhieuMuon.SelectedCells[1].Value.ToString();
                button_muonXoa.Enabled = true;
                txt_muonDG.Enabled = false;
                txt_muonSach.Enabled = false;
                string sql_select = "select MS as N'Mã độc giả'," +
                "G.TenDN as N'Tên đăng nhập'," +
                "G.HoTen as N'Họ và tên'," +
                "CONVERT (varchar(10), G.NgaySinh, 103) AS N'Ngày sinh'," +
                "G.DiaChi as N'Địa chỉ'," +
                "G.Loai as N'Loại'," +
                "G.Email," +
                "CONVERT (varchar(10), G.NgayLapThe, 103) AS N'Ngày lập thẻ'," +
                "G.TongNo as N'Tổng nợ'," +
                "S.HoTen as N'Tên người lập' " +
                $"from TheDocGia G,HoSo S where MaNgLap=MaNV and MS='{txt_muonDG.Text}'";
                SqlCommand cmd = new SqlCommand(sql_select, con);
                SqlDataReader rd = cmd.ExecuteReader();
                data d = new data();
                d.Load(rd);
                dataDGMuon.DataSource = d;
            }
            catch
            {
                button_muonXoa.Enabled = false;
                txt_muonDG.Enabled = true;
                txt_muonSach.Enabled = true;
            }
        }

        private void button_muonXuatphieu_Click(object sender, EventArgs e)
        {

        }
    }
}
