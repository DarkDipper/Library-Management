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
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }
        QuanLyTV quanLy = new QuanLyTV();
        private void button1_Click(object sender, EventArgs e)
        {
            int tong = 0;
            string ngay = dateTimePicker1.Value.ToString("MM/yyyy");
            var x = from i in quanLy.LichSuMuons where i.Thang == ngay select i;
            try { 
                foreach (var i in x)
                {
                    if (i.TheLoai == "Khoa học")
                    {
                        kh.Text = i.SoLuot.ToString();
                        tong += int.Parse(kh.Text);
                    }
                    else if (i.TheLoai == "Tiểu thuyết")
                    {
                        tt.Text = i.SoLuot.ToString();
                        tong += int.Parse(tt.Text);
                    }
                    else if (i.TheLoai == "Xã hội")
                    {
                        xh.Text = i.SoLuot.ToString();
                        tong += int.Parse(xh.Text);
                    }
                }
                tonglm.Text = tong.ToString();
                double tlm = double.Parse(tonglm.Text);
                double d_kh = double.Parse(kh.Text);
                double d_tt = double.Parse(tt.Text);
                double d_xh = double.Parse(xh.Text);
                circularProgressBar1.Value = (int)d_tt * 100 / (int)tlm;
                circularProgressBar2.Value = (int)d_kh *100 / (int)tlm;
                circularProgressBar3.Value = (int)d_xh * 100 / (int)tlm;
                circularProgressBar1.SubscriptText = Math.Round(d_tt*100 / tlm,2).ToString() + "%";
                circularProgressBar2.SubscriptText = Math.Round(d_kh*100 / tlm,2).ToString() + "%";
                circularProgressBar3.SubscriptText = Math.Round(d_xh*100 / tlm,2).ToString() + "%";
            }
            catch
            {
                circularProgressBar1.Value = 0;
                circularProgressBar2.Value = 0;
                circularProgressBar3.Value = 0;
                circularProgressBar1.SubscriptText = "0 %";
                circularProgressBar2.SubscriptText = "0 %";
                circularProgressBar3.SubscriptText = "0 %";
                kh.Text = "0";
                xh.Text = "0";
                tt.Text = "0";
                tonglm.Text = "0";
            }
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            string[] b = new string[4];
            ListViewItem dss;
            var danhSaches = from i in quanLy.DanhSachSaches select i;
            try
            {
                int k = 1;
                int cu = 0, mat = 0;
                foreach (var i in danhSaches)
                {

                    if (DateTime.Today.Year - i.NamXuatBan > 8)
                    {
                        b[0] = k.ToString();
                        b[1] = i.MaSach;
                        b[2] = i.TenSach;
                        b[3] = "Đã cũ";
                        dss = new ListViewItem(b);
                        listView1.Items.Add(dss);
                        k++;
                        cu++;
                    }
                    if (i.TinhTrang == "Mất")
                    {
                        b[0] = k.ToString();
                        b[1] = i.MaSach;
                        b[2] = i.TenSach;
                        b[3] = "Đã mất";
                        dss = new ListViewItem(b);
                        listView1.Items.Add(dss);
                        k++;
                        mat++;
                    }
                }
                Cu.Text = cu.ToString();
                Mat.Text = mat.ToString();
            }
            catch
            {

            }
            int tong = 0;
            string ngay = dateTimePicker1.Value.ToString("MM/yyyy");
            var x = from i in quanLy.LichSuMuons where i.Thang == ngay select i;
            try
            {
                foreach (var i in x)
                {
                    if (i.TheLoai == "Khoa học")
                    {
                        kh.Text = i.SoLuot.ToString();
                        tong += int.Parse(kh.Text);
                    }
                    else if (i.TheLoai == "Tiểu thuyết")
                    {
                        tt.Text = i.SoLuot.ToString();
                        tong += int.Parse(tt.Text);
                    }
                    else if (i.TheLoai == "Xã hội")
                    {
                        xh.Text = i.SoLuot.ToString();
                        tong += int.Parse(xh.Text);
                    }
                }
                tonglm.Text = tong.ToString();
                double tlm = double.Parse(tonglm.Text);
                double d_kh = double.Parse(kh.Text);
                double d_tt = double.Parse(tt.Text);
                double d_xh = double.Parse(xh.Text);
                circularProgressBar1.Value = (int)d_tt * 100 / (int)tlm;
                circularProgressBar2.Value = (int)d_kh * 100 / (int)tlm;
                circularProgressBar3.Value = (int)d_xh * 100 / (int)tlm;
                circularProgressBar1.SubscriptText = Math.Round(d_tt * 100 / tlm, 2).ToString() + "%";
                circularProgressBar2.SubscriptText = Math.Round(d_kh * 100 / tlm, 2).ToString() + "%";
                circularProgressBar3.SubscriptText = Math.Round(d_xh * 100 / tlm, 2).ToString() + "%";
            }
            catch
            {
                circularProgressBar1.Value = 0;
                circularProgressBar2.Value = 0;
                circularProgressBar3.Value = 0;
                circularProgressBar1.SubscriptText = "0 %";
                circularProgressBar2.SubscriptText = "0 %";
                circularProgressBar3.SubscriptText = "0 %";
                kh.Text = "0";
                xh.Text = "0";
                tt.Text = "0";
                tonglm.Text = "0";
            }
            ngaythangnamphat.Text = DateTime.Today.ToString("dd/MM/yyyy");
            ListViewItem ds;
            string[] a = new string[3];
            var no = from i in quanLy.TheDocGias where i.TongNo > 0 orderby i.TongNo descending select i;
            try
            {
                int dem = 1;
                int tongno = 0;
                foreach (var xn in no)
                {
                    a[0] = dem.ToString();
                    a[1] = xn.HoTen.ToString();
                    a[2] = xn.TongNo.ToString();
                    tongno += (int)xn.TongNo;
                    ds = new ListViewItem(a);
                    listViewNo.Items.Add(ds);
                    dem++;
                }
                string kq = "000";
                string xultchuoi = tongno.ToString();
                //MessageBox.Show(xultchuoi);
                int l = xultchuoi.Length;
                if (l > 3) l -= 3;
               // MessageBox.Show(l.ToString());
                while(l > 3)
                {
                    kq = xultchuoi.Substring(l-3,3)+"." +kq;
                   /// MessageBox.Show(kq);
                    l -= 3;
                }
                tongphat.Text =xultchuoi.Substring(0,l)+"."+ kq+" đồng";
            }
            catch
            {

            }
            string[] c = new string[4];
            ListViewItem ds1;
            var phaluat = from i in quanLy.TheDocGias where i.TongNo > 500000 && (DateTime.Today - i.NgayLapThe).Value.Days > 180 select i;
            try
            {
                int d = 0;
                foreach(var i in phaluat)
                {
                    c[0] = d.ToString();
                    c[1] = i.MS;
                    c[2] = i.HoTen;
                    c[3] = i.NgaySinh.Value.ToString("dd/MM/yyyy");
                    d++;
                    ds1 = new ListViewItem(c);
                    listView2.Items.Add(ds1);
                }
                dansu.Text = d.ToString();
            }
            catch
            {

            }
          
        }
    }
}
