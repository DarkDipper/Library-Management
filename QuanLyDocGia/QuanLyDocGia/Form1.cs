using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using data = System.Data.DataTable;

namespace BM2
{
    public partial class Form1 : Form
    {
        public Form1()
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
                "H.HoTen as N'Tên người lập' " +
                "from TheDocGia G,HoSo S" +
                "where MaNgLap=MaNV";
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

        private void Form1_Load(object sender, EventArgs e)
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
            ThongKe();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Trở về \"Đăng nhập\" ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
                con.Close();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_thongke_Click(object sender, EventArgs e)
        {

        }

        private void progressBar_thongke_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataTheDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
