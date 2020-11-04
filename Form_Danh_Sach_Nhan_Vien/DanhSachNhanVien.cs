using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Danh_Sach_Nhan_Vien
{
    public partial class DanhSachNhanVien : Form
    {
        QuanLyTV cmd = new QuanLyTV();
        public DanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void DanhSachNhanVien_Load(object sender, EventArgs e)
        {
            var DS = from item in cmd.HoSoes where item.BoPhan != "Thủ trưởng"select item;
            foreach (HoSo NV in DS)
            {
                var row = new string[] { NV.MaNV, NV.HoTen,NV.NgaySinh.Value.ToString("dd/MM/yyyy"),NV.DiaChi,NV.DienThoai,NV.BangCap,NV.BoPhan,NV.NgayLamViec.Value.ToString("dd/MM/yyyy") };
                var liv = new ListViewItem(row);
                liv.Tag = NV;
                listViewNhanVien.Items.Add(liv);
            }

        }

        private void listViewNhanVien_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listViewNhanVien.Columns[e.ColumnIndex].Width;
        }
    }

}
