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
using System.Text.RegularExpressions;
using System.IO;
using System.Reflection;

namespace QuanLyKho
{
    public partial class QuanLyKho : Form
    {
        public QuanLyKho()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }
        public int SizeBang;
        public int i = 0;
        public string Mathukho = "E.002";
        public bool check = false;
        //bool chon_anh = false;
        QuanLyTV qltv = new QuanLyTV();

        //========================================================Hàm bổ trợ ===================================================
        //SqlConnection con;

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);

                return returnImage;
            }
        }
        // Ảnh sang byte
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);

                return ms.ToArray();
            }
        }
        public void HienThi()
        {/*SqlCommand cmd = new SqlCommand("select MaSach as N'Mã sách'," +
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
                     "where DanhSachSach.MaNgNhan = HoSo.MaNV", con);*/
            var dsk = from item in qltv.DanhSachSaches from a in qltv.HoSoes where a.MaNV == item.MaNgNhan select new { ms = item.MaSach, tens = item.TenSach,tl=item.TheLoai,tg=item.TacGia,nxb=item.NamXuatBan,nhaxb=item.NhaXuatBan,nn=item.NgayNhap,trg=item.TriGia, tt = item.TinhTrang,ngn= a.HoTen};
            dataKho.DataSource = dsk.ToList();
            dataKho.Columns[0].HeaderText = "Mã sách";
            dataKho.Columns[1].HeaderText = "Tên sách";
            dataKho.Columns[2].HeaderText = "Thể Loại";
            dataKho.Columns[3].HeaderText = "Tác giả";
            dataKho.Columns[4].HeaderText = "Năm xuất bản";
            dataKho.Columns[5].HeaderText = "Nhà xuất bản";
            dataKho.Columns[6].HeaderText = "Ngày nhập";
            dataKho.Columns[7].HeaderText = "Trị giá";
            dataKho.Columns[8].HeaderText = "Tình trạng";
            dataKho.Columns[9].HeaderText = "Người nhận";

        }
        public void ThongKe()
        {
            double thongke = (double)((SizeBang - 1) * 1);
            progressBar_thongke.Value = (int)Math.Round(thongke, 0);
            // MessageBox.Show($"{progressBar_thongke.Value.ToString()}");
            label_thongke.Text = $"{(SizeBang - 1).ToString()}/100";
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
            text_MoTA.Text = "";
        }
        void LoadForm()
        {
            i = 0;
            for (int k = 0; k < dataKho.Rows.Count ; k++)
            {
                string chuoi = dataKho.Rows[k].Cells[0].Value.ToString();
                string chuoi_so = chuoi.Substring(2);
                // MessageBox.Show($"{chuoi_so}");
                int so = int.Parse($"{chuoi_so}");
                //MessageBox.Show($"{(so).ToString()}");
                if (so != i) break;
                else i++;
            }
            //MessageBox.Show(i.ToString());
           SizeBang = dataKho.Rows.Count + 1;
        }
        //------------------------------------------------------------Xử lý chức năng----------------------------------------
        private void QuanLyKho_Load(object sender, EventArgs e)
        {
            if (!check)
            {
                HoSo x = qltv.HoSoes.SingleOrDefault(p => p.MaNV == Mathukho);
                tt_Ten.Text = x.HoTen;
                tt_ngaysinh.Text = x.NgaySinh.Value.ToString("dd/MM/yyyy");
                tt_diachi.Text = x.DiaChi;
                tt_dienthoai.Text = x.DienThoai;
                tt_bangcap.Text = x.BangCap;
                tt_nlv.Text = x.NgayLamViec.Value.ToString("dd/MM/yyyy");
                TaiKhoanNV y = qltv.TaiKhoanNVs.SingleOrDefault(p => p.MaNV == Mathukho);
                tt_tenDN.Text = y.TenDN;
                tt_Matkhau.Text = y.MatKhau;
                tt_mnv.Text = y.MaNV;
                tt_tenDN.Enabled = true;
                tt_Matkhau.Enabled = true;
                tt_dienthoai.Enabled = true;
                LuuThayDoi.Enabled = true;
            } 
         //   string conString = ConfigurationManager.ConnectionStrings["QuanLyDG"].ConnectionString.ToString();
           // con = new SqlConnection(conString);
           // con.Open();
            HienThi();
            
            //MessageBox.Show($"{i.ToString()}");
            button_Sua.Enabled = false;
            button_Xoa.Enabled = false;
            button_Them.Enabled = true;
            LoadForm();
           // MessageBox.Show(i.ToString());
            ThongKe();
        }
        //==============================================Xử Lý==========================================
        private void button_Excel_Click_1(object sender, EventArgs e)
        {
            var x = new XuatKhoSach();
            x.khoSach = dataKho;
            this.Hide();
            x.ShowDialog();
            this.Show();
        }

        private void dataKho_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    var sach = qltv.DanhSachSaches.SingleOrDefault(p => p.MaSach == Kho_MaSach.Text);
                    text_MoTA.Text = sach.MoTa;
                    if (sach.Anh != null) pictureBox1.Image = ByteArrayToImage(sach.Anh);
                    else pictureBox1.Image = null;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            var x = new DanhSachSach_PDF();
            x.Dss = dataKho;
            this.Hide();
            x.ShowDialog();
            this.Show();
        }

        private void button_PDF_Click_1(object sender, EventArgs e)
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
                x.anh = pictureBox1.Image;
                this.Hide();
                x.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Tim_Click_1(object sender, EventArgs e)
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
                /*string sql_find = "select MaSach as N'Mã sách'," +
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
                                           "where DanhSachSach.MaNgNhan = HoSo.MaNV";*/
                var dsss = from i in qltv.DanhSachSaches select i;
                List<DanhSachSach> tim = new List<DanhSachSach>();
                if (comboBox_Tim.SelectedIndex == 0)
                {
                    foreach(var x in dsss)
                    {
                        if (x.MaSach == Kho_MaSach.Text) tim.Add(x);
                    }
                }
                else if (comboBox_Tim.SelectedIndex == 1)
                {
                    foreach (var x in dsss)
                    {
                        if (x.TenSach.Contains(Kho_TenSach.Text)) tim.Add(x);
                    }
                }
                else if (comboBox_Tim.SelectedIndex == 2)
                {
                    foreach (var x in dsss)
                    {
                        if (x.TheLoai == Kho_TheLoai.Text) tim.Add(x);
                    }
                }
                else if (comboBox_Tim.SelectedIndex == 3)
                {
                    foreach (var x in dsss)
                    {
                        if (x.TacGia.Contains(Kho_TacGia.Text)) tim.Add(x);
                    }
                }
                else
                {
                    foreach (var x in dsss)
                    {
                        if (DateTime.Today.Year - x.NamXuatBan > 8) tim.Add(x);
                    }
                }
                var dsk = from item in tim from a in qltv.HoSoes where a.MaNV == item.MaNgNhan select new { ms = item.MaSach, tens = item.TenSach, tl = item.TheLoai, tg = item.TacGia, nxb = item.NamXuatBan, nhaxb = item.NhaXuatBan, nn = item.NgayNhap, trg = item.TriGia, tt = item.TinhTrang,ngn = a.HoTen };
                dataKho.DataSource = dsk.ToList();
                dataKho.Columns[0].HeaderText = "Mã sách";
                dataKho.Columns[1].HeaderText = "Tên sách";
                dataKho.Columns[2].HeaderText = "Thể Loại";
                dataKho.Columns[3].HeaderText = "Tác giả";
                dataKho.Columns[4].HeaderText = "Năm xuất bản";
                dataKho.Columns[5].HeaderText = "Nhà xuất bản";
                dataKho.Columns[6].HeaderText = "Ngày nhập";
                dataKho.Columns[7].HeaderText = "Trị giá";
                dataKho.Columns[8].HeaderText = "Tình trạng";
                dataKho.Columns[9].HeaderText = "Người nhận";
            }
        }
        bool Check = false;
        private void button_Sua_Click_1(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                DanhSachSach x = qltv.DanhSachSaches.SingleOrDefault(p => p.MaSach == Kho_MaSach.Text);
                x.TenSach = Kho_TenSach.Text;
                x.TheLoai = Kho_TheLoai.Text;
                x.TacGia = Kho_TacGia.Text;
                x.NamXuatBan = int.Parse(Kho_NamXuatBan.Value.ToString());
                x.NhaXuatBan = Kho_NhaXuatBan.Text;
                x.TriGia = int.Parse((double.Parse(Kho_Gia.Value.ToString()) * 1000).ToString());
                x.MoTa = text_MoTA.Text;
                if (Check)
                {
                    x.Anh = ImageToByteArray(pictureBox1.Image);
                }
               // if(pictureBox1.Image!=null)
                //x.Anh = ImageToByteArray(pictureBox1.Image);
                /*string sql_ed = $"update DanhSachSach set TenSach=" +
                    $"N'{Kho_TenSach.Text}',TacGia=N'{Kho_TacGia.Text}'," +
                    $"TheLoai=N'{Kho_TheLoai.Text}',NamXuatBan={Kho_NamXuatBan.Value}," +
                    $"NhaXuatBan=N'{Kho_NhaXuatBan.Text}',TriGia={Kho_Gia.Value * 1000}" +
                    $"where MaSach='{Kho_MaSach.Text}'";
                SqlCommand cmd = new SqlCommand(sql_ed, con);
                cmd.ExecuteNonQuery();*/
                try
                {
                    qltv.DanhSachSaches.AddOrUpdate(x); 
                    qltv.SaveChanges();
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

        private void button_Xoa_Click_1(object sender, EventArgs e)
        {
            
            if (MessageBox.Show($"Có thật sự muốn xóa \"{Kho_MaSach.Text}-{Kho_TenSach.Text}\"", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                var sach = qltv.DanhSachSaches.SingleOrDefault(p=>p.MaSach==Kho_MaSach.Text);
                // SqlCommand cmd = new SqlCommand(sqlXoa, con);
                qltv.DanhSachSaches.Remove(sach);
                qltv.SaveChanges();
               // cmd.ExecuteNonQuery();
                
                Reset_ThuocTinh();
               
                
            }
            HienThi();
            LoadForm();
           // MessageBox.Show(i.ToString());
            ThongKe();
        }

        private void button_Them_Click_1(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var y =new DanhSachSach();
                y.MaSach = TaoMa();
                y.TheLoai = Kho_TheLoai.Text;
                y.TenSach = Kho_TenSach.Text;
                y.TacGia = Kho_TacGia.Text;
                y.NamXuatBan = int.Parse(Kho_NamXuatBan.Value.ToString());
                y.NhaXuatBan = Kho_NhaXuatBan.Text;
                y.TriGia = int.Parse((double.Parse(Kho_Gia.Value.ToString()) * 1000).ToString());
                y.NgayNhap = DateTime.Today;
                y.MaNgNhan = Mathukho;
                y.TinhTrang = "Còn";
                y.DanhGia = 0;
                y.LuotDanhGia = "";
                y.MoTa = text_MoTA.Text;
                if (pictureBox1.Image!=null) {
                    Image anh = pictureBox1.Image;
                    var byte_anh = ImageToByteArray(anh);
                    y.Anh = byte_anh;
                }
               /*      Image Y = pictureBox1.BackgroundImage;
                var Z = ImageToByteArray(Y);
                SaveFile A = new SaveFile();
                A.Name = "Yes";
                A.Files = Z;
                x.SaveFiles.Add(A);
                x.SaveChanges();*/
                qltv.DanhSachSaches.Add(y);
                qltv.SaveChanges();
                Reset_ThuocTinh();
                
                
                MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            else MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            HienThi();
            LoadForm();
           // MessageBox.Show(i.ToString());
            ThongKe();
        }

       /* private void QuanLyKho_FormClosing(object sender, FormClosingEventArgs e)
        {
                AutoValidate = AutoValidate.Disable;
                e.Cancel = true;
              //  con.Close();
        }*/

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

        private void Kho_TacGia_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (Kho_TacGia.Text.Length != 0)
                {
                    char[] trimChars = { '\\', '|', '\'', ' ', '@', ' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '_', '+', '[', '{', ']', '}', ';', ':', '"', ',', '<', '.', '>', '/', '?' };
                    Kho_TacGia.Text = Kho_TacGia.Text.Trim(trimChars);
                    int slc = 0;
                    bool c = false;
                    for (int i = 0; i < Kho_TacGia.Text.Length; i++)
                    {
                        if (Kho_TacGia.Text[i] >= 33 && Kho_TacGia.Text[i] <= 57 || Kho_TacGia.Text[i] >= 58 && Kho_TacGia.Text[i] <= 64 || Kho_TacGia.Text[i] >= 91 && Kho_TacGia.Text[i] <= 96 || Kho_TacGia.Text[i] >= 123 && Kho_TacGia.Text[i] <= 126)
                        {
                            Kho_TacGia.Text = Kho_TacGia.Text.Remove(i, 1);
                            i = -1;
                        }
                    }
                    for (int i = 0; i < Kho_TacGia.Text.Length; i++)
                    {
                        if (c != true && Kho_TacGia.Text[i] >= 'a' && Kho_TacGia.Text[i] <= 'z' || c != true && Kho_TacGia.Text[i] >= 'A' && Kho_TacGia.Text[i] <= 'Z')
                        {
                            slc++;
                            c = true;
                        }
                        if (Kho_TacGia.Text[i] == ' ' && c == true)
                        {
                            c = false;
                        }
                    }
                    for (int i = 0; i < Kho_TacGia.Text.Length; i++)
                    {
                        if (Kho_TacGia.Text[i] == ' ' && Kho_TacGia.Text[i + 1] == ' ')
                        {
                            Kho_TacGia.Text = Kho_TacGia.Text.Remove(i, 1);
                        }
                    }
                    c = false;
                    string x = "";
                    string xx = "";
                    for (int i = 0; i < Kho_TacGia.Text.Length; i++)
                    {
                        if (c == false && Kho_TacGia.Text[i] >= 127 || c == false && Kho_TacGia.Text[i] >= 'a' && Kho_TacGia.Text[i] <= 'z' || c == false && Kho_TacGia.Text[i] >= 'A' && Kho_TacGia.Text[i] <= 'Z')
                        {
                            x += Kho_TacGia.Text[i];
                        }
                        if (Kho_TacGia.Text[i] == ' ')
                        {
                            c = true;
                        }
                        if (c == true || i + 1 == Kho_TacGia.Text.Length)
                        {
                            x = x.Substring(0, 1).ToUpper() + x.Substring(1, x.Length - 1).ToLower();
                            slc--;
                            xx += x + " ";
                            x = "";
                            c = false;
                        }
                    }
                    Kho_TacGia.Text = xx.Trim();
                }
                if (Kho_TacGia.Text.Length == 0)
                {
                    Tick.Clear();
                    errorProvider1.SetError(this.Kho_TacGia, "Vui lòng nhập lại!!");
                    e.Cancel=true;
                }
                else
                {
                    errorProvider1.Clear();
                    Tick.SetError(Kho_TacGia, "You passed!");
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
                text_MoTA.Enabled = false;
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
                text_MoTA.Enabled = false;
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
                text_MoTA.Enabled = false;
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
                text_MoTA.Enabled = false;
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
                text_MoTA.Enabled = true;
            }
        }
        bool mk = false;
        bool dt = false;
        
        private void tt_Matkhau_Leave(object sender, EventArgs e)
        {
            if (tt_Matkhau.Text.Length == 0)
            {
                Tick.Clear();
                errorProvider1.SetError(this.tt_Matkhau, "Bạn chưa nhập mật khẩu! ");
                mk = false;
            }
            else if (tt_Matkhau.Text.Length < 9)
            {
                Tick.Clear();
                errorProvider1.SetError(tt_Matkhau, "Mật khẩu quá ngắn");
                mk = false;
            }
            else if (Regex.IsMatch(tt_Matkhau.Text, "^[!-~]*$"))
            {
                errorProvider1.Clear();
                Tick.SetError(tt_Matkhau, "xong");
                mk = true;
            }
            else
            {
                Tick.Clear();
                errorProvider1.SetError(tt_Matkhau, "Không đúng dữ liệu nhập");
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
                            errorProvider1.SetError(tt_dienthoai, "Có ký tự không phải số trong số điện thoại");
                            dt = false;
                            return;
                        }
                    }
                }
                else
                {
                    Tick.Clear();
                    errorProvider1.SetError(tt_dienthoai, "Số điện thoại phải bắt đầu số 0 ");
                    dt = false;
                }
                errorProvider1.Clear();
                Tick.SetError(tt_dienthoai, "Xong");
                dt = true;
            }
            else
            {
                Tick.Clear();
                errorProvider1.SetError(tt_dienthoai, "Số điện thoại không đủ 10 chữ số");
                dt = false;
            }
        }
        private void LuuThayDoi_Click_1(object sender, EventArgs e)
        {
            if (mk == true && dt == true)
            {
                TaiKhoanNV x = qltv.TaiKhoanNVs.SingleOrDefault(p => p.MaNV == Mathukho);
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

        private void DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kho_MaSach_Validating(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var fbd = new OpenFileDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.FileName))
                {
                    pictureBox1.Image = Image.FromFile(fbd.FileName);
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Check = true;
        }
    }
}
