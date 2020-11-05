﻿using FormThuTruong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trang_Chu
{
    public partial class LayLaiMatKhau : Form
    {
        public LayLaiMatKhau()
        {
            InitializeComponent();
        }
        QuanLyTV quanLy = new QuanLyTV();
        private void button1_Click(object sender, EventArgs e)
        {
            var nv = quanLy.HoSoes.SingleOrDefault(p => p.MaNV == manv.Text);
          //  MessageBox.Show($"{ nv.HoTen}, {nv.NgaySinh.Value} {nv.BangCap} {nv.DiaChi} {nv.BoPhan} ");
            if (nv!=null && nv.HoTen == tennv.Text && nv.NgaySinh.Value.ToString("dd/MM/yyyy") == nsnv.Value.ToString("dd/MM/yyyy") && nv.BangCap == bcnv.Text && nv.DiaChi == dcnv.Text && nv.BoPhan == bpnv.Text)
            {
                
                var tk = quanLy.TaiKhoanNVs.SingleOrDefault(p => p.MaNV == manv.Text);
                tk.MatKhau = "123";
                quanLy.TaiKhoanNVs.AddOrUpdate(tk);
                quanLy.SaveChanges();
                MessageBox.Show("Thành công. Mật khẩu mới của bạn là: 123", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thất bại. Vui lòng nhập đúng thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
