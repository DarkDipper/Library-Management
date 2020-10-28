﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
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
        int i = 1;
        public string TaoMa()
        {
            if (i < 10) return $"L.00{i.ToString()}";
            else if (i < 100) return $"L.0{i.ToString()}";
            else return $"L.{i.ToString()}";
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


                string sql_in = $@"Insert into TheDocGia values('{TaoMa()}','{textBox2.Text}','{textBox1.Text}',N'{f2Name.Text}','{f2NgaySinh.Value.ToString("yyyyMMdd")}',N'{f2Address.Text}','{f2Type.Text}','{f2Email.Text}','{DateTime.Today.ToString("yyyyMMdd")}',0,'E.001')";
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

    }
}