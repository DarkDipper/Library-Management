﻿namespace FormThuTruong
{
    partial class CaNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaNhan));
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.DangXuat = new System.Windows.Forms.Button();
            this.LuuThayDoi = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tt_tenDN = new System.Windows.Forms.Label();
            this.tt_Matkhau = new System.Windows.Forms.TextBox();
            this.tt_mnv = new System.Windows.Forms.Label();
            this.tt = new System.Windows.Forms.Label();
            this.tt_tdn = new System.Windows.Forms.Label();
            this.tt_mk = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tt_nlv = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tt_dienthoai = new System.Windows.Forms.Label();
            this.tt_diachi = new System.Windows.Forms.Label();
            this.tt_bangcap = new System.Windows.Forms.Label();
            this.tt_ngaysinh = new System.Windows.Forms.Label();
            this.tt_Ten = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Tick = new System.Windows.Forms.ErrorProvider(this.components);
            this.er = new System.Windows.Forms.ErrorProvider(this.components);
            this.Button_X = new System.Windows.Forms.Label();
            this.Button_Minisize = new System.Windows.Forms.Label();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.DangXuat);
            this.groupBox9.Controls.Add(this.LuuThayDoi);
            this.groupBox9.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox9.Location = new System.Drawing.Point(584, 292);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Size = new System.Drawing.Size(559, 121);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Thao tác";
            // 
            // DangXuat
            // 
            this.DangXuat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DangXuat.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangXuat.ForeColor = System.Drawing.Color.Gray;
            this.DangXuat.Image = global::FormThuTruong.Properties.Resources.log_out_icon_153555;
            this.DangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DangXuat.Location = new System.Drawing.Point(301, 41);
            this.DangXuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DangXuat.Name = "DangXuat";
            this.DangXuat.Size = new System.Drawing.Size(227, 57);
            this.DangXuat.TabIndex = 1;
            this.DangXuat.Text = "     Đăng xuất";
            this.DangXuat.UseVisualStyleBackColor = true;
            this.DangXuat.Click += new System.EventHandler(this.DangXuat_Click);
            // 
            // LuuThayDoi
            // 
            this.LuuThayDoi.Enabled = false;
            this.LuuThayDoi.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuuThayDoi.ForeColor = System.Drawing.Color.Gray;
            this.LuuThayDoi.Image = global::FormThuTruong.Properties.Resources.diskette_save_saveas_1514;
            this.LuuThayDoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LuuThayDoi.Location = new System.Drawing.Point(37, 41);
            this.LuuThayDoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LuuThayDoi.Name = "LuuThayDoi";
            this.LuuThayDoi.Size = new System.Drawing.Size(227, 57);
            this.LuuThayDoi.TabIndex = 0;
            this.LuuThayDoi.Text = "     Lưu thay đổi";
            this.LuuThayDoi.UseVisualStyleBackColor = true;
            this.LuuThayDoi.Click += new System.EventHandler(this.LuuThayDoi_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tt_tenDN);
            this.groupBox8.Controls.Add(this.tt_Matkhau);
            this.groupBox8.Controls.Add(this.tt_mnv);
            this.groupBox8.Controls.Add(this.tt);
            this.groupBox8.Controls.Add(this.tt_tdn);
            this.groupBox8.Controls.Add(this.tt_mk);
            this.groupBox8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox8.Location = new System.Drawing.Point(583, 53);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Size = new System.Drawing.Size(560, 224);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Thông tin bảo mật";
            // 
            // tt_tenDN
            // 
            this.tt_tenDN.AutoSize = true;
            this.tt_tenDN.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_tenDN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tt_tenDN.Location = new System.Drawing.Point(229, 63);
            this.tt_tenDN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tt_tenDN.Name = "tt_tenDN";
            this.tt_tenDN.Size = new System.Drawing.Size(121, 28);
            this.tt_tenDN.TabIndex = 12;
            this.tt_tenDN.Text = "(Unknow)";
            // 
            // tt_Matkhau
            // 
            this.tt_Matkhau.Enabled = false;
            this.tt_Matkhau.Location = new System.Drawing.Point(235, 111);
            this.tt_Matkhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tt_Matkhau.Multiline = true;
            this.tt_Matkhau.Name = "tt_Matkhau";
            this.tt_Matkhau.Size = new System.Drawing.Size(283, 51);
            this.tt_Matkhau.TabIndex = 14;
            this.tt_Matkhau.Leave += new System.EventHandler(this.tt_Matkhau_Leave);
            // 
            // tt_mnv
            // 
            this.tt_mnv.AutoSize = true;
            this.tt_mnv.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_mnv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tt_mnv.Location = new System.Drawing.Point(216, 176);
            this.tt_mnv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tt_mnv.Name = "tt_mnv";
            this.tt_mnv.Size = new System.Drawing.Size(121, 28);
            this.tt_mnv.TabIndex = 10;
            this.tt_mnv.Text = "(Unknow)";
            // 
            // tt
            // 
            this.tt.AutoSize = true;
            this.tt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt.ForeColor = System.Drawing.Color.Red;
            this.tt.Location = new System.Drawing.Point(23, 174);
            this.tt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(177, 32);
            this.tt.TabIndex = 12;
            this.tt.Text = "Mã nhân viên :";
            // 
            // tt_tdn
            // 
            this.tt_tdn.AutoSize = true;
            this.tt_tdn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_tdn.ForeColor = System.Drawing.Color.Red;
            this.tt_tdn.Location = new System.Drawing.Point(23, 59);
            this.tt_tdn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tt_tdn.Name = "tt_tdn";
            this.tt_tdn.Size = new System.Drawing.Size(193, 32);
            this.tt_tdn.TabIndex = 10;
            this.tt_tdn.Text = "Tên đăng nhập :";
            // 
            // tt_mk
            // 
            this.tt_mk.AutoSize = true;
            this.tt_mk.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_mk.ForeColor = System.Drawing.Color.Red;
            this.tt_mk.Location = new System.Drawing.Point(23, 117);
            this.tt_mk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tt_mk.Name = "tt_mk";
            this.tt_mk.Size = new System.Drawing.Size(139, 32);
            this.tt_mk.TabIndex = 11;
            this.tt_mk.Text = "Mật khẩu : ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tt_nlv);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.tt_dienthoai);
            this.groupBox5.Controls.Add(this.tt_diachi);
            this.groupBox5.Controls.Add(this.tt_bangcap);
            this.groupBox5.Controls.Add(this.tt_ngaysinh);
            this.groupBox5.Controls.Add(this.tt_Ten);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox5.Location = new System.Drawing.Point(15, 53);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(561, 359);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin hồ sơ";
            // 
            // tt_nlv
            // 
            this.tt_nlv.AutoSize = true;
            this.tt_nlv.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_nlv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tt_nlv.Location = new System.Drawing.Point(212, 318);
            this.tt_nlv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tt_nlv.Name = "tt_nlv";
            this.tt_nlv.Size = new System.Drawing.Size(121, 28);
            this.tt_nlv.TabIndex = 11;
            this.tt_nlv.Text = "(Unknow)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkGreen;
            this.label14.Location = new System.Drawing.Point(16, 318);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(185, 32);
            this.label14.TabIndex = 10;
            this.label14.Text = "Ngày làm việc :";
            // 
            // tt_dienthoai
            // 
            this.tt_dienthoai.AutoSize = true;
            this.tt_dienthoai.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_dienthoai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tt_dienthoai.Location = new System.Drawing.Point(175, 266);
            this.tt_dienthoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tt_dienthoai.Name = "tt_dienthoai";
            this.tt_dienthoai.Size = new System.Drawing.Size(121, 28);
            this.tt_dienthoai.TabIndex = 9;
            this.tt_dienthoai.Text = "(Unknow)";
            // 
            // tt_diachi
            // 
            this.tt_diachi.AutoSize = true;
            this.tt_diachi.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_diachi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tt_diachi.Location = new System.Drawing.Point(175, 209);
            this.tt_diachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tt_diachi.Name = "tt_diachi";
            this.tt_diachi.Size = new System.Drawing.Size(121, 28);
            this.tt_diachi.TabIndex = 8;
            this.tt_diachi.Text = "(Unknow)";
            // 
            // tt_bangcap
            // 
            this.tt_bangcap.AutoSize = true;
            this.tt_bangcap.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_bangcap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tt_bangcap.Location = new System.Drawing.Point(175, 154);
            this.tt_bangcap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tt_bangcap.Name = "tt_bangcap";
            this.tt_bangcap.Size = new System.Drawing.Size(121, 28);
            this.tt_bangcap.TabIndex = 7;
            this.tt_bangcap.Text = "(Unknow)";
            // 
            // tt_ngaysinh
            // 
            this.tt_ngaysinh.AutoSize = true;
            this.tt_ngaysinh.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_ngaysinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tt_ngaysinh.Location = new System.Drawing.Point(175, 97);
            this.tt_ngaysinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tt_ngaysinh.Name = "tt_ngaysinh";
            this.tt_ngaysinh.Size = new System.Drawing.Size(121, 28);
            this.tt_ngaysinh.TabIndex = 6;
            this.tt_ngaysinh.Text = "(Unknow)";
            // 
            // tt_Ten
            // 
            this.tt_Ten.AutoSize = true;
            this.tt_Ten.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_Ten.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tt_Ten.Location = new System.Drawing.Point(175, 41);
            this.tt_Ten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tt_Ten.Name = "tt_Ten";
            this.tt_Ten.Size = new System.Drawing.Size(121, 28);
            this.tt_Ten.TabIndex = 5;
            this.tt_Ten.Text = "(Unknow)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkGreen;
            this.label12.Location = new System.Drawing.Point(16, 266);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 32);
            this.label12.TabIndex = 4;
            this.label12.Text = "Điện thoại :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGreen;
            this.label11.Location = new System.Drawing.Point(16, 209);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 32);
            this.label11.TabIndex = 3;
            this.label11.Text = "Địa chỉ :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGreen;
            this.label10.Location = new System.Drawing.Point(16, 154);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 32);
            this.label10.TabIndex = 2;
            this.label10.Text = "Bằng cấp :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(16, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ngày sinh :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(16, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Họ và tên :";
            // 
            // Tick
            // 
            this.Tick.BlinkRate = 0;
            this.Tick.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Tick.ContainerControl = this;
            this.Tick.Icon = ((System.Drawing.Icon)(resources.GetObject("Tick.Icon")));
            // 
            // er
            // 
            this.er.BlinkRate = 0;
            this.er.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.er.ContainerControl = this;
            // 
            // Button_X
            // 
            this.Button_X.AutoSize = true;
            this.Button_X.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_X.Location = new System.Drawing.Point(1131, 0);
            this.Button_X.Name = "Button_X";
            this.Button_X.Size = new System.Drawing.Size(25, 29);
            this.Button_X.TabIndex = 6;
            this.Button_X.Text = "X";
            this.Button_X.Click += new System.EventHandler(this.Button_X_Click);
            // 
            // Button_Minisize
            // 
            this.Button_Minisize.AutoSize = true;
            this.Button_Minisize.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Minisize.Location = new System.Drawing.Point(1094, -5);
            this.Button_Minisize.Name = "Button_Minisize";
            this.Button_Minisize.Size = new System.Drawing.Size(25, 29);
            this.Button_Minisize.TabIndex = 6;
            this.Button_Minisize.Text = "_";
            this.Button_Minisize.Click += new System.EventHandler(this.Button_Minisize_Click);
            // 
            // CaNhan
            // 
            this.AcceptButton = this.LuuThayDoi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DangXuat;
            this.ClientSize = new System.Drawing.Size(1159, 432);
            this.Controls.Add(this.Button_Minisize);
            this.Controls.Add(this.Button_X);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "CaNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin thủ trưởng";
            this.Load += new System.EventHandler(this.CaNhan_Load);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button DangXuat;
        private System.Windows.Forms.Button LuuThayDoi;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox tt_Matkhau;
        private System.Windows.Forms.Label tt_mnv;
        private System.Windows.Forms.Label tt;
        private System.Windows.Forms.Label tt_tdn;
        private System.Windows.Forms.Label tt_mk;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label tt_nlv;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label tt_dienthoai;
        private System.Windows.Forms.Label tt_diachi;
        private System.Windows.Forms.Label tt_bangcap;
        private System.Windows.Forms.Label tt_ngaysinh;
        private System.Windows.Forms.Label tt_Ten;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider Tick;
        private System.Windows.Forms.ErrorProvider er;
        private System.Windows.Forms.Label tt_tenDN;
        private System.Windows.Forms.Label Button_Minisize;
        private System.Windows.Forms.Label Button_X;
    }
}