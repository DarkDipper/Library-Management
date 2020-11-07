using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormThuTruong
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        QuanLyTV qltv = new QuanLyTV();
        string[] a = new string[7];
        ListViewItem ds;
        private void NhanVien_Load(object sender, EventArgs e)
        {
            var x = from item in qltv.HoSoes select item;
            foreach(var nv in x)
            {
                a[0] = nv.MaNV;
                a[1] = nv.HoTen;
                a[2] = nv.NgaySinh.Value.ToString("dd/MM/yyyy");
                a[3] = nv.BangCap;
                a[4] = nv.DiaChi; 
                a[5] = nv.DienThoai;
                a[6] = nv.NgayLamViec.Value.ToString("dd/MM/yyyy");
                ds = new ListViewItem(a);
                if (nv.BoPhan=="Thủ thư")
                {
                    listView1.Items.Add(ds);
                }
                if (nv.BoPhan == "Thủ kho")
                {
                    listView2.Items.Add(ds);
                }
                if (nv.BoPhan == "Thủ quỹ")
                {
                    listView3.Items.Add(ds);
                }
            }
        }


    }
}
