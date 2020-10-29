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
namespace BM2
{
    public partial class TheDocGia : Form
    {
        //Console.OutputEncoding = System.Text.Encoding.UTF8; 
        public TheDocGia()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = f2Name;  // Con trỏ đặt ngay tại Name 

        }
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
            pcreater = true;
        }
        private void f2Type_Leave(object sender, EventArgs e)
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
                Tick.SetError(f2Type, "Passed!");
                //checkDocGia.Clear();
                ptype = true;
            }
        }
        private void f2NgaySinh_Leave(object sender, EventArgs e)
        {
            if (DateTime.Now.Year - f2NgaySinh.Value.Year >= 18 && DateTime.Now.Year - f2NgaySinh.Value.Year <= 55)
            {
                pdate = true;
                checkNgaySinh.Clear();
                Tick.SetError(f2NgaySinh, "Passed!");
            }
            else
            {
                Tick.Clear();
                checkNgaySinh.SetError(f2NgaySinh, "Độ tuổi yêu cầu từ 18 đến 55!!");
                pdate = false;
            }
        }

        private void f2Name_Leave_1(object sender, EventArgs e)
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
                Tick.SetError(f2Name, "You passed!");
                pname = true;
            }
        }

        private void f2Address_Leave_1(object sender, EventArgs e)
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
                Tick.SetError(f2Address, "You passed!");
                paddress = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                Tick.Clear();
               checkDN.SetError(this.textBox2, "Bạn chưa nhập tên đăng nhập! ");
                dn= false;
            }
            else
            {
                checkDN.Clear();
                Tick.SetError(textBox2, "You passed!");
                dn = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                Tick.Clear();
                checkMK.SetError(this.textBox1, "Bạn chưa nhập mật khẩu! ");
                mk= false;
            }
            else
            {
                checkMK.Clear();
                Tick.SetError(textBox1, "You passed!");
                mk = true;
            }
        }

        private void f2Email_Leave(object sender, EventArgs e)
        {
            string checkemail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
           if (Regex.IsMatch(f2Email.Text, checkemail))
            {
                checkTen.Clear(); // Nếu đúng thì không hiển thị
                Tick.SetError(f2Email, "Passed!");
                pmail = true;
            }
            else
            {
                pmail = false;
                Tick.Clear();
                checkTen.SetError(this.f2Email, "Bạn nhập sai định dạng  email! "); //Phản hồi ngay sau khi nhập sai email và leave 
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TheDocGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Trở về trang \"Quản lý đọc giả\" ?","Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
                    
        }
    }
}
