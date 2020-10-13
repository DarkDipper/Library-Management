using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using data = System.Data.DataTable;
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
using System.Globalization;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
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
                Tick.SetError(f2Name, "xong");
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
            else if(textBox1.Text.Length < 9)
            {
                Tick.Clear();
                checkMK.SetError(textBox1, "Mật khẩu quá ngắn");
                mk = false;
            }
            else if (Regex.IsMatch(textBox1.Text, "^[!-~]*$"))
            {
                checkMK.Clear();
                Tick.SetError(textBox1, "xong");
                mk = true;
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
            if(Regex.IsMatch(f2Email.Text,@"^([a-zA-Z0-9]+)@([a-zA-Z0-9]+)\.(([a-zA-Z0-9])+)$"))
            {
                checkEmail.Clear();
                Tick.SetError(f2Email, "xong");
                pmail = true;
            }
            else
            {
                pmail = false;
                Tick.Clear();
                checkEmail.SetError(this.f2Email, "Bạn nhập sai định dạng  email! "); //Phản hồi ngay sau khi nhập sai email và leave 
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
        public string TaoMa()
        { 
              if (i < 10) return $"L.00{i.ToString()}";
              else if (i < 100) return $"L.0{i.ToString()}";
              else return $"L.{i.ToString()}";
        }
        public void Hienthi()
        {
            string sql_select = "select MS,TeDN,MatKhau,HoTen,CONVERT (varchar(10), NgaySinh, 103) AS [NgaySinh],DiaChi,Loai,Email,CONVERT (varchar(10), NgayLapThe, 103) AS [NgayLapThe],TongNo,MaNgLap,MaNgThuTien from TheDocGia";
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
            checkTen.SetError(f2Name, null);
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
            checkTen.SetError(f2Name, null);
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
            text_Xoa.Text = "";
        }
        public void ThongKe()
        {
            double thongke = (double)((dataTheDocGia.Rows.Count-1) * 0.2);
            progressBar_thongke.Value = (int)Math.Round(thongke, 0);
            // MessageBox.Show($"{progressBar_thongke.Value.ToString()}");
            label_thongke.Text = $"{(dataTheDocGia.Rows.Count-1).ToString()}/500";
        }
        private void Export_Excel(DataGridView g, string duongDan, string Tentep)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for(int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for(int i = 0; i < g.Rows.Count; i++)
            {
                for(int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + Tentep + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
            MessageBox.Show("Cập nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // ........................................................................................Xử lý.................................................................................................
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
                string chuoi_so = chuoi.Substring(2);
               // MessageBox.Show($"{chuoi_so}");
                int so = int.Parse($"{chuoi_so}");
                //MessageBox.Show($"{(so).ToString()}");
                if (so != i) break;
                else i++;
            }
           //MessageBox.Show($"{i.ToString()}");
            checkTen.SetError(f2Name, null);
            buttonSua.Enabled = false;
            ThongKe();
        }
        
        private void TheDocGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Trở về \"Đăng nhập\" ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
                con.Close();
            }
            

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
                    MessageBox.Show("Đăng kí thành công. Bạn có muốn xuất thẻ đọc giả không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    Reset_ThuocTinh();
                    Set_false();
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
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string sqlXoa;
            if (text_Xoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
                sqlXoa = $"DELETE FROM TheDocGia WHERE MS='{text_Xoa.Text}'";
                if (MessageBox.Show($"Có thật sự muốn xóa \"{text_Xoa.Text}\"", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand(sqlXoa, con);
                    cmd.ExecuteNonQuery();
                    Hienthi();
                    Reset_ThuocTinh();
                    Set_false();
                    ThongKe();
                }
            }
        }

        private void buttonTìm_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == -1) MessageBox.Show("Vui lòng chọn phương thức tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string sqlFind = "";
                info_tim.Text = "   ";
                if (comboBox1.SelectedIndex == 0) sqlFind = $"select *from TheDocGia where HoTen =N'{text_tìm.Text}'";
                else if (comboBox1.SelectedIndex == 1) sqlFind = $"select *from TheDocGia where MS ='{text_tìm.Text}'";
                SqlCommand cmd = new SqlCommand(sqlFind, con);
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                data d = new data();
                d.Load(rd);
                dataTheDocGia.DataSource = d;
            }
        }

        private void dataTheDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                buttonSua.Enabled = true;
                f2Name.Text = dataTheDocGia.SelectedCells[3].Value.ToString();
                f2Address.Text = dataTheDocGia.SelectedCells[5].Value.ToString();
                textBox2.Text = dataTheDocGia.SelectedCells[1].Value.ToString();
                textBox1.Text = dataTheDocGia.SelectedCells[2].Value.ToString();
                f2Email.Text = dataTheDocGia.SelectedCells[7].Value.ToString();
                f2Type.Text = dataTheDocGia.SelectedCells[6].Value.ToString();
                f2NgaySinh.Value = DateTime.ParseExact(dataTheDocGia.SelectedCells[4].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                textMS.Text = dataTheDocGia.SelectedCells[0].Value.ToString();
                text_Xoa.Text = dataTheDocGia.SelectedCells[0].Value.ToString();
                buttonSign_up.Enabled = false;
                //f2Type.Enabled = false;
                Set_true();
            }
            catch {
             
                 Hienthi();
            }
        }


        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (paddress == true && pdate == true && pmail == true && pname == true && dn == true && mk == true && ptype == true)
            {
                checkTen.SetError(f2Name, null);
                string sql_ed = $"update TheDocGia set TeDN='{textBox2.Text}',MatKhau='{textBox1.Text}',HoTen=N'{f2Name.Text}',NgaySinh='{f2NgaySinh.Value.ToString("yyyyMMdd")}',DiaChi=N'{f2Address.Text}',Loai='{f2Type.Text}',Email='{f2Email.Text}',TongNo=0,MaNgLap=null,MaNgThuTien=null where MS='{textMS.Text}'";
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
        int dem = 0;
        private void button_Eye_Click(object sender, EventArgs e)
        {
            dem++;
            if (dem % 2 == 1) { textBox1.UseSystemPasswordChar = false; }
            else textBox1.UseSystemPasswordChar = true;
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            buttonSua.Enabled = false;
            buttonSign_up.Enabled = true;
            Reset_ThuocTinh();
            Set_false();
            Hienthi();
            f2NgaySinh.Value = DateTime.Now;
        }

        private void button_Excel_Click(object sender, EventArgs e)
        {
            Export_Excel(dataTheDocGia, @"C:\Users\kun\source\repos\DarkDipper\Libary-Management\LOC\documents\", "QLDG");
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "1. File Excel được lưu tại địa chỉ " +
                "C:\\Users\\kun\\source\\repos\\DarkDipper\\Libary-Management\\LOC\\documents\\ với tên là QLDG.xlsx",
                "Thông tin hướng dẫn",
                MessageBoxButtons.OK
                );
        }
    }
}
