﻿namespace WindowsFormsApp4
{
    partial class ThongtinThuquy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongtinThuquy));
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.DangXuat = new System.Windows.Forms.Button();
            this.LuuThayDoi = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tt_Matkhau = new System.Windows.Forms.TextBox();
            this.tt_tenDN = new System.Windows.Forms.TextBox();
            this.tt_mnv = new System.Windows.Forms.Label();
            this.tt = new System.Windows.Forms.Label();
            this.tt_tdn = new System.Windows.Forms.Label();
            this.tt_mk = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tt_dienthoai = new System.Windows.Forms.TextBox();
            this.tt_nlv = new System.Windows.Forms.Label();
            this.tt3 = new System.Windows.Forms.Label();
            this.tt_diachi = new System.Windows.Forms.Label();
            this.tt_bangcap = new System.Windows.Forms.Label();
            this.tt_ngaysinh = new System.Windows.Forms.Label();
            this.tt_Ten = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Tick = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.DangXuat);
            this.groupBox9.Controls.Add(this.LuuThayDoi);
            this.groupBox9.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox9.Location = new System.Drawing.Point(439, 205);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(419, 100);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Thao tác";
            // 
            // DangXuat
            // 
            this.DangXuat.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangXuat.ForeColor = System.Drawing.Color.Gray;
            this.DangXuat.Location = new System.Drawing.Point(226, 33);
            this.DangXuat.Name = "DangXuat";
            this.DangXuat.Size = new System.Drawing.Size(170, 46);
            this.DangXuat.TabIndex = 1;
            this.DangXuat.Text = "Đăng xuất";
            this.DangXuat.UseVisualStyleBackColor = true;
            this.DangXuat.Click += new System.EventHandler(this.DangXuat_Click);
            // 
            // LuuThayDoi
            // 
            this.LuuThayDoi.Enabled = false;
            this.LuuThayDoi.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuuThayDoi.ForeColor = System.Drawing.Color.Gray;
            this.LuuThayDoi.Location = new System.Drawing.Point(28, 33);
            this.LuuThayDoi.Name = "LuuThayDoi";
            this.LuuThayDoi.Size = new System.Drawing.Size(170, 46);
            this.LuuThayDoi.TabIndex = 0;
            this.LuuThayDoi.Text = "Lưu thay đổi";
            this.LuuThayDoi.UseVisualStyleBackColor = true;
            this.LuuThayDoi.Click += new System.EventHandler(this.LuuThayDoi_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tt_Matkhau);
            this.groupBox8.Controls.Add(this.tt_tenDN);
            this.groupBox8.Controls.Add(this.tt_mnv);
            this.groupBox8.Controls.Add(this.tt);
            this.groupBox8.Controls.Add(this.tt_tdn);
            this.groupBox8.Controls.Add(this.tt_mk);
            this.groupBox8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox8.Location = new System.Drawing.Point(438, 13);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(420, 188);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Thông tin bảo mật";
            // 
            // tt_Matkhau
            // 
            this.tt_Matkhau.Enabled = false;
            this.tt_Matkhau.Location = new System.Drawing.Point(176, 90);
            this.tt_Matkhau.Multiline = true;
            this.tt_Matkhau.Name = "tt_Matkhau";
            this.tt_Matkhau.Size = new System.Drawing.Size(213, 42);
            this.tt_Matkhau.TabIndex = 14;
            this.tt_Matkhau.Leave += new System.EventHandler(this.tt_Matkhau_Leave);
            // 
            // tt_tenDN
            // 
            this.tt_tenDN.Enabled = false;
            this.tt_tenDN.Location = new System.Drawing.Point(176, 42);
            this.tt_tenDN.Multiline = true;
            this.tt_tenDN.Name = "tt_tenDN";
            this.tt_tenDN.Size = new System.Drawing.Size(213, 39);
            this.tt_tenDN.TabIndex = 13;
            this.tt_tenDN.Leave += new System.EventHandler(this.tt_tenDN_Leave);
            // 
            // tt_mnv
            // 
            this.tt_mnv.AutoSize = true;
            this.tt_mnv.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_mnv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tt_mnv.Location = new System.Drawing.Point(162, 143);
            this.tt_mnv.Name = "tt_mnv";
            this.tt_mnv.Size = new System.Drawing.Size(95, 22);
            this.tt_mnv.TabIndex = 10;
            this.tt_mnv.Text = "(Unknow)";
            // 
            // tt
            // 
            this.tt.AutoSize = true;
            this.tt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt.ForeColor = System.Drawing.Color.Red;
            this.tt.Location = new System.Drawing.Point(17, 141);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(139, 25);
            this.tt.TabIndex = 12;
            this.tt.Text = "Mã nhân viên :";
            // 
            // tt_tdn
            // 
            this.tt_tdn.AutoSize = true;
            this.tt_tdn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_tdn.ForeColor = System.Drawing.Color.Red;
            this.tt_tdn.Location = new System.Drawing.Point(17, 48);
            this.tt_tdn.Name = "tt_tdn";
            this.tt_tdn.Size = new System.Drawing.Size(152, 25);
            this.tt_tdn.TabIndex = 10;
            this.tt_tdn.Text = "Tên đăng nhập :";
            // 
            // tt_mk
            // 
            this.tt_mk.AutoSize = true;
            this.tt_mk.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_mk.ForeColor = System.Drawing.Color.Red;
            this.tt_mk.Location = new System.Drawing.Point(17, 95);
            this.tt_mk.Name = "tt_mk";
            this.tt_mk.Size = new System.Drawing.Size(109, 25);
            this.tt_mk.TabIndex = 11;
            this.tt_mk.Text = "Mật khẩu : ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tt_dienthoai);
            this.groupBox5.Controls.Add(this.tt_nlv);
            this.groupBox5.Controls.Add(this.tt3);
            this.groupBox5.Controls.Add(this.tt_diachi);
            this.groupBox5.Controls.Add(this.tt_bangcap);
            this.groupBox5.Controls.Add(this.tt_ngaysinh);
            this.groupBox5.Controls.Add(this.tt_Ten);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(421, 293);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin hồ sơ";
            // 
            // tt_dienthoai
            // 
            this.tt_dienthoai.Enabled = false;
            this.tt_dienthoai.Location = new System.Drawing.Point(135, 209);
            this.tt_dienthoai.Name = "tt_dienthoai";
            this.tt_dienthoai.Size = new System.Drawing.Size(249, 36);
            this.tt_dienthoai.TabIndex = 12;
            this.tt_dienthoai.Leave += new System.EventHandler(this.tt_dienthoai_Leave);
            // 
            // tt_nlv
            // 
            this.tt_nlv.AutoSize = true;
            this.tt_nlv.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_nlv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tt_nlv.Location = new System.Drawing.Point(160, 258);
            this.tt_nlv.Name = "tt_nlv";
            this.tt_nlv.Size = new System.Drawing.Size(95, 22);
            this.tt_nlv.TabIndex = 11;
            this.tt_nlv.Text = "(Unknow)";
            // 
            // tt3
            // 
            this.tt3.AutoSize = true;
            this.tt3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt3.ForeColor = System.Drawing.Color.DarkGreen;
            this.tt3.Location = new System.Drawing.Point(12, 258);
            this.tt3.Name = "tt3";
            this.tt3.Size = new System.Drawing.Size(151, 25);
            this.tt3.TabIndex = 10;
            this.tt3.Text = "Ngày làm việc : ";
            // 
            // tt_diachi
            // 
            this.tt_diachi.AutoSize = true;
            this.tt_diachi.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_diachi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tt_diachi.Location = new System.Drawing.Point(131, 168);
            this.tt_diachi.Name = "tt_diachi";
            this.tt_diachi.Size = new System.Drawing.Size(95, 22);
            this.tt_diachi.TabIndex = 8;
            this.tt_diachi.Text = "(Unknow)";
            // 
            // tt_bangcap
            // 
            this.tt_bangcap.AutoSize = true;
            this.tt_bangcap.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_bangcap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tt_bangcap.Location = new System.Drawing.Point(131, 123);
            this.tt_bangcap.Name = "tt_bangcap";
            this.tt_bangcap.Size = new System.Drawing.Size(95, 22);
            this.tt_bangcap.TabIndex = 7;
            this.tt_bangcap.Text = "(Unknow)";
            // 
            // tt_ngaysinh
            // 
            this.tt_ngaysinh.AutoSize = true;
            this.tt_ngaysinh.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_ngaysinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tt_ngaysinh.Location = new System.Drawing.Point(131, 77);
            this.tt_ngaysinh.Name = "tt_ngaysinh";
            this.tt_ngaysinh.Size = new System.Drawing.Size(95, 22);
            this.tt_ngaysinh.TabIndex = 6;
            this.tt_ngaysinh.Text = "(Unknow)";
            // 
            // tt_Ten
            // 
            this.tt_Ten.AutoSize = true;
            this.tt_Ten.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_Ten.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tt_Ten.Location = new System.Drawing.Point(131, 31);
            this.tt_Ten.Name = "tt_Ten";
            this.tt_Ten.Size = new System.Drawing.Size(95, 22);
            this.tt_Ten.TabIndex = 5;
            this.tt_Ten.Text = "(Unknow)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkGreen;
            this.label12.Location = new System.Drawing.Point(12, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 25);
            this.label12.TabIndex = 4;
            this.label12.Text = "Điện thoại :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGreen;
            this.label11.Location = new System.Drawing.Point(12, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Địa chỉ :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGreen;
            this.label10.Location = new System.Drawing.Point(12, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Bằng cấp :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkGreen;
            this.label13.Location = new System.Drawing.Point(12, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "Ngày sinh :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkGreen;
            this.label14.Location = new System.Drawing.Point(12, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Họ và tên :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Tick
            // 
            this.Tick.BlinkRate = 0;
            this.Tick.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Tick.ContainerControl = this;
            this.Tick.Icon = ((System.Drawing.Icon)(resources.GetObject("Tick.Icon")));
            // 
            // ThongtinThuquy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 322);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ThongtinThuquy";
            this.Text = "Thông tin thủ quỹ";
            this.Load += new System.EventHandler(this.ThongtinThuquy_Load);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button DangXuat;
        private System.Windows.Forms.Button LuuThayDoi;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox tt_Matkhau;
        private System.Windows.Forms.TextBox tt_tenDN;
        private System.Windows.Forms.Label tt_mnv;
        private System.Windows.Forms.Label tt;
        private System.Windows.Forms.Label tt_tdn;
        private System.Windows.Forms.Label tt_mk;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tt_dienthoai;
        private System.Windows.Forms.Label tt_nlv;
        private System.Windows.Forms.Label tt3;
        private System.Windows.Forms.Label tt_diachi;
        private System.Windows.Forms.Label tt_bangcap;
        private System.Windows.Forms.Label tt_ngaysinh;
        private System.Windows.Forms.Label tt_Ten;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider Tick;
    }
}