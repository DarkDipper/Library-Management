using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // thư viện dùng để check
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Windows.Forms.VisualStyles;

namespace BM2
{
    public partial class TheDocGia : Form
    {
       
       //Console.OutputEncoding = System.Text.Encoding.UTF8;
       
        public TheDocGia()
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
        bool ok = false;
        private void f2Creater_Leave(object sender, EventArgs e)
        {
           // pcreater = true;
        }
        
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
                    checkTen.SetError(this.f2Name, "Vui lòng nhập lại!");
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
                    checkTen.SetError(this.f2Name, "Vui lòng nhập lại!");
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
                    checkTen.SetError(this.f2Name, "Vui lòng nhập lại!");
                    pname = false;
                }
                if (f2Name.Text.Length != 0)
                {
                    checkTen.Clear();
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
                checkTen.SetError(this.f2Name, "Bạn chưa nhập tên! ");
                pname = false;
            }
            else
            {
                checkTen.Clear();
                Tick.SetError(f2Name, " xong");
                pname = true;
                
            }
        }

        private void f2Address_Leave(object sender, EventArgs e)
        {
            if (f2Address.Text.Length == 0)
            {
                Tick.Clear();
                checkDiaChi.SetError(this.f2Address, "Bạn chưa nhập địa chỉ! ");
                paddress = false;
            }
            else
            {
                checkDiaChi.Clear();
                Tick.SetError(f2Address, "xong");
                paddress = true;
                
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

            if (textBox2.Text.Length == 0)
            {
                Tick.Clear();
                checkDN.SetError(this.textBox2, "Bạn chưa nhập tên đăng nhập! ");
                dn = false;
            }
            else if (Regex.IsMatch(textBox2.Text,"^[a-zA-Z0-9]*$")){
                checkDN.Clear();
                Tick.SetError(textBox2, "xong");
                dn = true;
            }
            else
            {
                Tick.Clear();
                checkDN.SetError(textBox2, "Không đúng dữ liệu nhập");
                dn = false; 
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                Tick.Clear();
                checkMK.SetError(this.textBox1, "Bạn chưa nhập mật khẩu! ");
                mk = false;
            }
            else if (Regex.IsMatch(textBox1.Text, "^[!-~]*$"))
            {
                checkMK.Clear();
                Tick.SetError(textBox1, "xong");
                mk = true;
            }
            else if(textBox1.Text.Length<9)
            {
                Tick.Clear();
                checkMK.SetError(textBox1, "Mật khẩu quá ngắn");
                mk = false;
            }
            else
            {
                Tick.Clear();
                checkMK.SetError(textBox1, "Không đúng dữ liệu nhập");
                mk = false;
            }
        }

        private void f2Email_Leave(object sender, EventArgs e)
        {
            /*string checkemail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (Regex.IsMatch(f2Email.Text, checkemail))
            {
                checkTen.Clear(); // Nếu đúng thì không hiển thị
                Tick.SetError(f2Email, "xong");
                pmail = true;
                
            }
            else*/
            if(Regex.IsMatch(f2Email.Text,@"^([a-zA-Z0-9]+)@([a-zA-Z0-9]+)(\.([a-zA-Z0-9])+)$"))
            {
                checkTen.Clear();
                Tick.SetError(f2Email, "xong");
                pmail = true;
            }
            else
            {
                pmail = false;
                Tick.Clear();
                checkTen.SetError(this.f2Email, "Bạn nhập sai định dạng  email! "); //Phản hồi ngay sau khi nhập sai email và leave 
                //pmail = true;
            }
        }

        private void f2Type_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(f2Type.Text))
            {
                checkDocGia.SetError(this.f2Type, "Vui lòng chọn độc giả! ");
                ptype = false;
            }
            if (f2Type.Text != "X" && f2Type.Text != "Y")
            {
                checkDocGia.SetError(this.f2Type, "Vui lòng chọn đúng loại đọc giả sẵn có! ");
                ptype = false;
            }
            else
            {
                checkDocGia.SetError(this.f2Type, null);
                Tick.SetError(f2Type, "xong");
                //checkDocGia.Clear();
                ptype = true;
                
            }
        }

        private void f2NgaySinh_Leave_1(object sender, EventArgs e)
        {
            if (DateTime.Now.Year - f2NgaySinh.Value.Year >= 18 && DateTime.Now.Year - f2NgaySinh.Value.Year <= 55)
            {
                pdate = true;
                checkNgaySinh.Clear();
                Tick.SetError(f2NgaySinh, "xong");
                
            }
            else
            {
                Tick.Clear();
                checkNgaySinh.SetError(f2NgaySinh, "Độ tuổi yêu cầu từ 18 đến 55!!");
                pdate = false;
            }
        }
        int i =1;
        int j =1;
        public string TaoMa()
        {
           int tmp;
              if (f2Type.Text == "X") tmp = i;
              else tmp = j;
              if (tmp < 10) return $"{f2Type.Text}.00{tmp.ToString()}";
              else if (tmp < 100) return $"{f2Type.Text}.0{tmp.ToString()}";
              else return $"{f2Type.Text}.{tmp.ToString()}";
        }
        public void Hienthi()
        {
            string sql_select = "SELECT *FROM TheDocGia";
            SqlCommand cmd = new SqlCommand(sql_select, con);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable d = new DataTable();
            d.Load(rd);
            dataTheDocGia.DataSource = d;

        }
        // Xử lý.................................................................................................
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyThuVienDataSet.TheDocGia' table.  can move, or remove it, as needed.
            this.theDocGiaTableAdapter.Fill(this.quanLyThuVienDataSet.TheDocGia);
            this.ActiveControl = f2Name;  // Con trỏ đặt ngay tại Name 
            string conString = ConfigurationManager.ConnectionStrings["QuanLyDG"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            Hienthi();
            f2NgaySinh.Text = DateTime.Today.ToString();
            for(int k = 0; k < dataTheDocGia.Rows.Count-1; k++)
            {
                string chuoi=dataTheDocGia.Rows[k].Cells[0].Value.ToString();
                //MessageBox.Show(chuoi.ToString());
                if (chuoi[0] == 'X')
                {
                    int so = int.Parse($"{chuoi[2]+chuoi[3]+chuoi[4]}");
                    //MessageBox.Show($"{so.ToString()}\n");
                    if (so -144!= i) break;
                    else i++;
                }
                else if (chuoi[0] == 'Y')
                {
                    int so = int.Parse($"{chuoi[2] + chuoi[3] + chuoi[4]}");
                    //MessageBox.Show($"{so.ToString()}\n");
                    if (so - 144 != j) break;
                    else j++;
                }
            }
        }
        
        private void TheDocGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Trở về \"Đăng nhập\" ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            con.Close();

        }
        private void buttonSign_up_Click_1(object sender, EventArgs e)
        {
           // MessageBox.Show($"{paddress.ToString()}\n{pdate.ToString()}\n{pmail.ToString()}\n{pname.ToString()}\n{pname.ToString()}\n{dn.ToString()}\n{mk.ToString()}\n{ptype.ToString()}");
            if (paddress == true && pdate == true && pmail == true && pname == true && dn == true && mk == true && ptype == true)
            {


                string sql_in = $@"Insert into TheDocGia values('{TaoMa()}','{textBox2.Text}','{textBox1.Text}',N'{f2Name.Text}','{f2NgaySinh.Value.ToString("yyyyMMdd")}',N'{f2Address.Text}','{f2Type.Text}','{f2Email.Text}','{DateTime.Today.ToString("yyyyMMdd")}',0,null,null)";
                SqlCommand cmd = new SqlCommand(sql_in, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hienthi();
                    if (f2Type.Text == "X") i++;
                    else j++;
                    
               }
                catch
              {
                   MessageBox.Show("Đăng kí thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Đăng kí thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string sqlXoa;
            if (text_TimvaXoa.Text=="") MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            sqlXoa = $"DELETE FROM TheDocGia WHERE MS='{text_TimvaXoa.Text}'";
            if (MessageBox.Show($"Có thật sự muốn xóa \"{text_TimvaXoa.Text}\"", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                    SqlCommand cmd = new SqlCommand(sqlXoa, con);
                    cmd.ExecuteNonQuery();
                    Hienthi();
                
            }
        }

        private void buttonTìm_Click(object sender, EventArgs e)
        {
            string sqlFind = $"select *from TheDocGia where MS ='{text_TimvaXoa.Text}'";
            SqlCommand cmd = new SqlCommand(sqlFind, con);
            cmd.ExecuteNonQuery();
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable d = new DataTable();
            d.Load(rd);
            dataTheDocGia.DataSource = d;
        }

        private void dataTheDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                f2Name.Text = dataTheDocGia.SelectedCells[3].Value.ToString();
                f2Address.Text = dataTheDocGia.SelectedCells[5].Value.ToString();
                textBox2.Text = dataTheDocGia.SelectedCells[1].Value.ToString();
                textBox1.Text = dataTheDocGia.SelectedCells[2].Value.ToString();
                f2Email.Text = dataTheDocGia.SelectedCells[7].Value.ToString();
                f2Type.Text = dataTheDocGia.SelectedCells[6].Value.ToString();
                f2NgaySinh.Value = DateTime.Parse(dataTheDocGia.SelectedCells[4].Value.ToString());
                textMS.Text = dataTheDocGia.SelectedCells[0].Value.ToString(); 
                buttonSign_up.Enabled = false;
                f2Type.Enabled = false;
            }
            catch { MessageBox.Show("Vùng không thể cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void TheDocGia_Click(object sender, EventArgs e)
        {
            buttonSign_up.Enabled = true;
            f2Type.Enabled = true;
            f2Name.Text = "";
            f2Address.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            f2Email.Text = "";
            f2Type.SelectedIndex = -1;
            textMS.Text = "";
            f2NgaySinh.Value = DateTime.Now;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            string sql_ed = $"update TheDocGia set TeDN='{textBox2.Text}',MatKhau='{textBox1.Text}',HoTen=N'{f2Name.Text}',NgaySinh='{f2NgaySinh.Value.ToString("yyyyMMdd")}',DiaChi=N'{f2Address.Text}',Loai='{f2Type.Text}',Email='{f2Email.Text}',NgayLapThe='{DateTime.Today.ToString("yyyyMMdd")}',TongNo=0,MaNgLap=null,MaNgThuTien=null where MS='{textMS.Text}'";
            SqlCommand cmd = new SqlCommand(sql_ed, con);
           // try
          //  {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hienthi();

           // }
          //  catch
          //  {
                //MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
          //  }
        }
        int dem = 0;
        private void button_Eye_Click(object sender, EventArgs e)
        {
            dem++;
            if (dem % 2 == 1) { textBox1.UseSystemPasswordChar = false; }
            else textBox1.UseSystemPasswordChar = true;
        }
    }
}
