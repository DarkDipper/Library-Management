namespace Form_Danh_Sach_Nhan_Vien
{
    partial class DanhSachNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachNhanVien));
            this.listViewNhanVien = new System.Windows.Forms.ListView();
            this.columnMaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDienThoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBangCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBoPhan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNgayLamViec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewNhanVien
            // 
            this.listViewNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMaNV,
            this.columnHoTen,
            this.columnNgaySinh,
            this.columnDiaChi,
            this.columnDienThoai,
            this.columnBangCap,
            this.columnBoPhan,
            this.columnNgayLamViec});
            this.listViewNhanVien.FullRowSelect = true;
            this.listViewNhanVien.GridLines = true;
            this.listViewNhanVien.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewNhanVien.HideSelection = false;
            this.listViewNhanVien.Location = new System.Drawing.Point(3, 280);
            this.listViewNhanVien.MultiSelect = false;
            this.listViewNhanVien.Name = "listViewNhanVien";
            this.listViewNhanVien.Size = new System.Drawing.Size(968, 273);
            this.listViewNhanVien.TabIndex = 0;
            this.listViewNhanVien.UseCompatibleStateImageBehavior = false;
            this.listViewNhanVien.View = System.Windows.Forms.View.Details;
            this.listViewNhanVien.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listViewNhanVien_ColumnWidthChanging);
            // 
            // columnMaNV
            // 
            this.columnMaNV.Text = "Mã Nhân Viên";
            this.columnMaNV.Width = 114;
            // 
            // columnHoTen
            // 
            this.columnHoTen.Text = "Họ Và Tên";
            this.columnHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHoTen.Width = 159;
            // 
            // columnNgaySinh
            // 
            this.columnNgaySinh.Text = "Ngày Sinh";
            this.columnNgaySinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnNgaySinh.Width = 116;
            // 
            // columnDiaChi
            // 
            this.columnDiaChi.Text = "Địa Chỉ";
            this.columnDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDiaChi.Width = 206;
            // 
            // columnDienThoai
            // 
            this.columnDienThoai.Text = "Số Điện Thoại";
            this.columnDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDienThoai.Width = 110;
            // 
            // columnBangCap
            // 
            this.columnBangCap.Text = "Bằng Cấp";
            this.columnBangCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnBangCap.Width = 97;
            // 
            // columnBoPhan
            // 
            this.columnBoPhan.Text = "Bộ Phận";
            this.columnBoPhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnBoPhan.Width = 118;
            // 
            // columnNgayLamViec
            // 
            this.columnNgayLamViec.Text = "Ngày Làm Việc";
            this.columnNgayLamViec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnNgayLamViec.Width = 138;
            // 
            // DanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(983, 551);
            this.Controls.Add(this.listViewNhanVien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(150, 150);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DanhSachNhanVien";
            this.Text = "Danh Sách Nhân Viên";
            this.Load += new System.EventHandler(this.DanhSachNhanVien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewNhanVien;
        private System.Windows.Forms.ColumnHeader columnMaNV;
        private System.Windows.Forms.ColumnHeader columnHoTen;
        private System.Windows.Forms.ColumnHeader columnNgaySinh;
        private System.Windows.Forms.ColumnHeader columnDiaChi;
        private System.Windows.Forms.ColumnHeader columnDienThoai;
        private System.Windows.Forms.ColumnHeader columnBangCap;
        private System.Windows.Forms.ColumnHeader columnBoPhan;
        private System.Windows.Forms.ColumnHeader columnNgayLamViec;
    }
}

