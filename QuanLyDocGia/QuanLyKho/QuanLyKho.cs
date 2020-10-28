using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using data = System.Data.DataTable;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Data.Entity.Migrations;

namespace QuanLyKho
{
    public partial class QuanLyKho : Form
    {

        public QuanLyKho()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }
        //========================================================Hàm bổ trợ ===================================================
        SqlConnection con;
        public int SizeBang;
        public int i = 1;
        public void HienThi()
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
            dataKho.DataSource = d;

        }
        public void ThongKe()
        {
            double thongke = (double)((SizeBang - 1) * 0.2);
            progressBar_thongke.Value = (int)Math.Round(thongke, 0);
            // MessageBox.Show($"{progressBar_thongke.Value.ToString()}");
            label_thongke.Text = $"{(SizeBang - 1).ToString()}/500";
        }
        public string TaoMa()
        {
            if (i < 10) return $"B.00{i.ToString()}";
            else if (i < 100) return $"B.0{i.ToString()}";
            else return $"B.{i.ToString()}";
        }
        public bool Only_letter(string x)
        {
            char[] DS = { '\'','\\',',','.','/','<','>',';',':','\"','{','[','}',']',
                          '~','`','!','@','#','$','%','^','&','*','(',')','-','_','+','=',};
            for (int i = 0; i < x.Length; i++)
            {
                if (DS.Contains(x[i]))
                {
                    return false;
                }
                else if (Int32.TryParse(x[i].ToString(), out int y))
                {
                    return false;
                }
            }
            return true;
        }
        public void Reset_ThuocTinh()
        {
            Kho_MaSach.Text = "";
            Kho_TenSach.Text = "";
            Kho_TheLoai.SelectedIndex = -1;
            Kho_TacGia.Text = "";
            Kho_NamXuatBan.Value = Kho_NamXuatBan.Minimum;
            Kho_NhaXuatBan.Text = "";
            Kho_Gia.Value = Kho_Gia.Minimum;
        }
        //------------------------------------------------------------Xử lý chức năng----------------------------------------
        private void QuanLyKho_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QuanLyDG"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
            for (int k = 0; k < dataKho.Rows.Count - 1; k++)
            {
                string chuoi = dataKho.Rows[k].Cells[0].Value.ToString();
                string chuoi_so = chuoi.Substring(2);
                // MessageBox.Show($"{chuoi_so}");
                int so = int.Parse($"{chuoi_so}");
                //MessageBox.Show($"{(so).ToString()}");
                if (so != i) break;
                else i++;
            }
            SizeBang = dataKho.Rows.Count;
            //MessageBox.Show($"{i.ToString()}");
            button_Sua.Enabled = false;
            button_Xoa.Enabled = false;
            button_Them.Enabled = true;
            ThongKe();
        }
        private void button_Tim_Click(object sender, EventArgs e)
        {
            if (comboBox_Tim.SelectedIndex == -1) MessageBox.Show("Vui lòng chọn cách tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (comboBox_Tim.SelectedIndex == 5)
            {
                button_Them.Enabled = true;
                button_Sua.Enabled = false;
                button_Xoa.Enabled = false;
                Reset_ThuocTinh();
                HienThi();
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
                if (comboBox_Tim.SelectedIndex == 0) sql_find += $" and MaSach='{Kho_MaSach.Text}'";
                else if (comboBox_Tim.SelectedIndex == 1) sql_find += $" and TenSach like N'%{Kho_TenSach.Text}%'";
                else if (comboBox_Tim.SelectedIndex == 2) sql_find += $" and TheLoai='{Kho_TheLoai.Text}'";
                else if (comboBox_Tim.SelectedIndex == 3) sql_find += $" and TacGia like N'%{Kho_TacGia.Text.Trim()}%'";
                else sql_find += $" and YEAR(GETDATE())-NamXuatBan > 8";
                SqlCommand cmd = new SqlCommand(sql_find, con);
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                data d = new data();
                d.Load(rd);
                dataKho.DataSource = d;
            }
        }

        private void comboBox_Tim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Tim.SelectedIndex == 0)
            {
                Kho_Gia.Enabled = false;
                Kho_NamXuatBan.Enabled = false;
                Kho_TenSach.Enabled = false;
                Kho_TheLoai.Enabled = false;
                Kho_MaSach.Enabled = true;
                Kho_TacGia.Enabled = false;
                Kho_NhaXuatBan.Enabled = false;
            }
            else if (comboBox_Tim.SelectedIndex == 1)
            {
                Kho_Gia.Enabled = false;
                Kho_NamXuatBan.Enabled = false;
                Kho_TenSach.Enabled = true;
                Kho_TheLoai.Enabled = false;
                Kho_MaSach.Enabled = false;
                Kho_TacGia.Enabled = false;
                Kho_NhaXuatBan.Enabled = false;
            }
            else if (comboBox_Tim.SelectedIndex == 3)
            {
                Kho_Gia.Enabled = false;
                Kho_NamXuatBan.Enabled = false;
                Kho_TenSach.Enabled = false;
                Kho_TheLoai.Enabled = false;
                Kho_MaSach.Enabled = false;
                Kho_TacGia.Enabled = true;
                Kho_NhaXuatBan.Enabled = false;
            }
            else if (comboBox_Tim.SelectedIndex == 2)
            {
                Kho_Gia.Enabled = false;
                Kho_NamXuatBan.Enabled = false;
                Kho_TenSach.Enabled = false;
                Kho_TheLoai.Enabled = true;
                Kho_MaSach.Enabled = false;
                Kho_TacGia.Enabled = false;
                Kho_NhaXuatBan.Enabled = false;
            }
            else
            {
                Kho_Gia.Enabled = true;
                Kho_NamXuatBan.Enabled = true;
                Kho_TenSach.Enabled = true;
                Kho_TheLoai.Enabled = true;
                Kho_MaSach.Enabled = false;
                Kho_TacGia.Enabled = true;
                Kho_NhaXuatBan.Enabled = true;
            }
        }
        private void Kho_NamXuatBan_Validating(object sender, CancelEventArgs e)
        {
            if (DateTime.Now.Year - Kho_NamXuatBan.Value <= 8 && DateTime.Now.Year >= Kho_NamXuatBan.Value)
            {
                e.Cancel = false;
                errorProvider1.SetError(Kho_NamXuatBan, null);
                Tick.SetError(Kho_NamXuatBan, "xong");
            }
            else
            {
                e.Cancel = true;
                Tick.Clear();
                errorProvider1.SetError(Kho_NamXuatBan, "Yêu cầu sách xuất bản trong 8 năm đổi lại");
            }
        }

        private void Kho_TacGia_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (Kho_TacGia.Text.Length != 0)
                {
                    string fullname = Kho_TacGia.Text;
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
                    if (Kho_TacGia.Text.Length == 0)
                    {
                        errorProvider1.SetError(this.Kho_TacGia, "Vui lòng nhập lại!");
                        e.Cancel = true;
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
                    if (Kho_TacGia.Text.Length == 0)
                    {
                        errorProvider1.SetError(this.Kho_TacGia, "Vui lòng nhập lại!");
                        e.Cancel = true;
                    }
                    // Xử lý phần dấu cách trước và sau chuỗi xong
                    Kho_TacGia.Text = fullname; // gán lại chuỗi sau khi sửa
                    //Tiếp tục check phần ký tự
                    for (int i = 0; i < Kho_TacGia.Text.Length; i++)
                    {
                        if (Kho_TacGia.Text[i] >= 33 && Kho_TacGia.Text[i] <= 57 || Kho_TacGia.Text[i] >= 58 && Kho_TacGia.Text[i] <= 64 || Kho_TacGia.Text[i] >= 91 && Kho_TacGia.Text[i] <= 96 || Kho_TacGia.Text[i] >= 123 && Kho_TacGia.Text[i] <= 126)
                        {
                            Kho_TacGia.Text = Kho_TacGia.Text.Remove(i, 1);
                            i = -1;
                        }
                    }
                    if (Kho_TacGia.Text.Length == 0)
                    {
                        Tick.Clear();
                        errorProvider1.SetError(this.Kho_TacGia, "Vui lòng nhập lại!");
                        e.Cancel = true;
                    }
                    if (Kho_TacGia.Text.Length != 0)
                    {
                        errorProvider1.Clear();
                        //Đếm số lượng từ có trong tên để viết hoa chữ đầu  
                        int slc = 1;
                        for (int i = 0; i < Kho_TacGia.Text.Length; i++)
                            if (Kho_TacGia.Text[i] == ' ') slc++;
                        //Viết hoa chữ đầu và nhấn đầu chữ sau
                        string[] parts = Kho_TacGia.Text.Split(new string[] { space }, StringSplitOptions.RemoveEmptyEntries);
                        Kho_TacGia.Text = "";
                        bool hetchu = false;
                        for (int i = 0; i < slc; i++)
                        {
                            parts[i] = parts[i].Substring(0, 1).ToUpper() + parts[i].Substring(1, parts[i].Length - 1).ToLower();
                            Kho_TacGia.Text = Kho_TacGia.Text + parts[i];
                            if (i >= 0 && i < slc) hetchu = true;
                            if (hetchu == true) Kho_TacGia.Text += " ";
                        }
                    }
                }
                if (Kho_TacGia.Text.Length == 0)
                {
                    Tick.Clear();
                    errorProvider1.SetError(this.Kho_TacGia, "Bạn chưa nhập tên! ");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.Clear();
                    Tick.SetError(Kho_TacGia, "xong");
                    e.Cancel = false;

                }
            }
            catch
            {
                Tick.Clear();
                errorProvider1.SetError(this.Kho_TacGia, "Vui lòng nhập lại!");
                e.Cancel = true;
            }
        }
        private void Kho_NhaXuatBan_Validating(object sender, CancelEventArgs e)
        {
            if (!Only_letter(Kho_NhaXuatBan.Text) || Kho_NhaXuatBan.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(Kho_NhaXuatBan, "Vui lòng nhập đúng yêu cầu");
                Tick.Clear();
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Kho_NhaXuatBan, null);
                Tick.SetError(Kho_NhaXuatBan, "xong");
            }
        }

        private void Kho_TheLoai_Validating(object sender, CancelEventArgs e)
        {
            if (Kho_TheLoai.SelectedIndex == -1)
            {
                Tick.Clear();
                errorProvider1.SetError(Kho_TheLoai, "Vui lòng chọn thể loại sách");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.Clear();
                Tick.SetError(Kho_TheLoai, "xong");
                e.Cancel = false;
            }
        }

        private void Kho_TenSach_Validating(object sender, CancelEventArgs e)
        {
            if (!(Kho_TenSach.Text.Length == 0))
            {
                errorProvider1.SetError(Kho_TenSach, null);
                Tick.SetError(Kho_TenSach, "xong");
                e.Cancel = false;

            }
            else
            {
                Tick.SetError(Kho_TenSach, null);
                e.Cancel = true;
                errorProvider1.SetError(Kho_TenSach, "Vui lòng nhập tên sách");
            }
        }

        private void Kho_Gia_Validating(object sender, CancelEventArgs e)
        {
            if (Kho_Gia.Value - Kho_Gia.Minimum <= 0)
            {
                Tick.Clear();
                e.Cancel = true;
                errorProvider1.SetError(Kho_MenhGia, "Chưa nhập giá sách");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Kho_MenhGia, null);
                Tick.SetError(Kho_MenhGia, "xong");
            }
        }

        private void QuanLyKho_FormClosing(object sender, FormClosingEventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            Application.Exit();
            con.Close();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string sql_in = $@"Insert into DanhSachSach values(
                        '{TaoMa()}',
                        N'{Kho_TenSach.Text}',
                        N'{Kho_TacGia.Text}',
                        '{Kho_TheLoai.Text}',
                        '{Kho_NamXuatBan.Value.ToString()}',
                        N'{Kho_NhaXuatBan.Text}',
                        '{DateTime.Today.ToString("yyyyMMdd")}',
                        {Kho_Gia.Value * 1000},
                        N'Còn',
                        'E.002'
                    )";
                SqlCommand cmd = new SqlCommand(sql_in, con);
                cmd.ExecuteNonQuery();
                SizeBang++;
                ThongKe();
                i++;
                Reset_ThuocTinh();
                HienThi();
                if (MessageBox.Show("Thêm thành công. Bạn có muốn xuất thông tin sách - PDF không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    var x = new XuatThongTinSach();
                    x.MaSach = TaoMa();
                    x.TheLoai = Kho_TheLoai.Text;
                    x.TenSach = Kho_TenSach.Text;
                    x.TacGia = Kho_TacGia.Text;
                    x.NamXuatBan = Kho_NamXuatBan.Text;
                    x.NhaXuatBan = Kho_NhaXuatBan.Text;
                    x.TriGia = Kho_Gia.Value.ToString()+".000 đồng";
                    x.NgayNhap = DateTime.Today.ToString("dd/MM/yyyy");
                    x.NguoiTiepNhan = "??";
                    this.Hide();
                    x.ShowDialog();
                    this.Show();
                }
            }
            else MessageBox.Show("Đăng kí thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            string sqlXoa;
            sqlXoa = $"DELETE FROM DanhSachSach WHERE MaSach='{Kho_MaSach.Text}'";
            if (MessageBox.Show($"Có thật sự muốn xóa \"{Kho_MaSach.Text}-{Kho_TenSach.Text}\"", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand(sqlXoa, con);
                cmd.ExecuteNonQuery();
                HienThi();
                Reset_ThuocTinh();
                SizeBang--;
                ThongKe();
            }
        }
        private void button_Sua_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string sql_ed = $"update DanhSachSach set TenSach=" +
                    $"N'{Kho_TenSach.Text}',TacGia=N'{Kho_TacGia.Text}'," +
                    $"TheLoai='{Kho_TheLoai.Text}',NamXuatBan={Kho_NamXuatBan.Value}," +
                    $"NhaXuatBan=N'{Kho_NhaXuatBan.Text}',TriGia={Kho_Gia.Value * 1000}" +
                    $"where MaSach='{Kho_MaSach.Text}'";
                SqlCommand cmd = new SqlCommand(sql_ed, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();

                }
                catch
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button_PDF_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var x = new XuatThongTinSach();
                x.MaSach = Kho_MaSach.Text;
                x.TheLoai = Kho_TheLoai.Text;
                x.TenSach = Kho_TenSach.Text;
                x.TacGia = Kho_TacGia.Text;
                x.NamXuatBan = Kho_NamXuatBan.Text;
                x.NhaXuatBan = Kho_NhaXuatBan.Text;
                x.TriGia = Kho_Gia.Value.ToString() + ".000 đồng";
                x.NgayNhap = dataKho.SelectedCells[6].Value.ToString();
                x.NguoiTiepNhan = dataKho.SelectedCells[8].Value.ToString();
                this.Hide();
                x.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Excel_Click(object sender, EventArgs e)
        {
            var x = new XuatKhoSach();
            x.khoSach = dataKho;
            this.Hide();
            x.ShowDialog();
            this.Show();
        }

        private void dataKho_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            try
            {
                if (dgv?.CurrentRow?.Cells != null)
                {
                    // MessageBox.Show("sá");
                    Kho_Gia.Enabled = true;
                    Kho_NamXuatBan.Enabled = true;
                    Kho_TenSach.Enabled = true;
                    Kho_TheLoai.Enabled = true;
                    Kho_MaSach.Enabled = false;
                    Kho_TacGia.Enabled = true;
                    Kho_NhaXuatBan.Enabled = true;
                    Kho_MaSach.Text = dataKho.SelectedCells[0].Value.ToString();
                    Kho_TenSach.Text = dataKho.SelectedCells[1].Value.ToString();
                    Kho_TheLoai.Text = dataKho.SelectedCells[2].Value.ToString();
                    Kho_TacGia.Text = dataKho.SelectedCells[3].Value.ToString();
                    Kho_NamXuatBan.Value = int.Parse(dataKho.SelectedCells[4].Value.ToString());
                    Kho_NhaXuatBan.Text = dataKho.SelectedCells[5].Value.ToString();
                    double money = double.Parse(dataKho.SelectedCells[7].Value.ToString());
                    Kho_Gia.Value = int.Parse((money * 0.001).ToString());
                    button_Them.Enabled = false;
                    button_Sua.Enabled = true;
                    button_Xoa.Enabled = true;
                }
                else
                {
                    button_Them.Enabled = true;
                    button_Sua.Enabled = false;
                    button_Xoa.Enabled = false;
                    Reset_ThuocTinh();
                }
            }
            catch
            {
                button_Them.Enabled = true;
                button_Sua.Enabled = false;
                button_Xoa.Enabled = false;
                Reset_ThuocTinh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = new DanhSachSach();
            x.Dss = dataKho;
                this.Hide();
                x.ShowDialog();
                this.Show();
        }
    }
}
