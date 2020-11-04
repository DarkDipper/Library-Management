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
        string[] a = new string[2];
        ListViewItem ds;
        private void NhanVien_Load(object sender, EventArgs e)
        {
            var x = from item in qltv.HoSoes select item;
            foreach(var nv in x)
            {
                if(nv.BoPhan=="Thủ thư")
                {
                    a[0] = nv.MaNV;
                    a[1] = nv.HoTen;
                    ds = new ListViewItem(a);
                    listView1.Items.Add(ds);
                }
                if (nv.BoPhan == "Thủ kho")
                {
                    a[0] = nv.MaNV;
                    a[1] = nv.HoTen;
                    ds = new ListViewItem(a);
                    listView2.Items.Add(ds);
                }
                if (nv.BoPhan == "Thủ quỹ")
                {
                    a[0] = nv.MaNV;
                    a[1] = nv.HoTen;
                    ds = new ListViewItem(a);
                    listView3.Items.Add(ds);
                }
            }
        }


    }
}
