namespace QuanLyKho
{
    partial class QuanLyKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyKho));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Kho_Gia = new System.Windows.Forms.NumericUpDown();
            this.Kho_MenhGia = new System.Windows.Forms.TextBox();
            this.Kho_NhaXuatBan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Kho_NamXuatBan = new System.Windows.Forms.NumericUpDown();
            this.Kho_TheLoai = new System.Windows.Forms.ComboBox();
            this.Kho_MaSach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Kho_TacGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Kho_TenSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_Tim = new System.Windows.Forms.Button();
            this.comboBox_Tim = new System.Windows.Forms.ComboBox();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_Excel = new System.Windows.Forms.Button();
            this.button_PDF = new System.Windows.Forms.Button();
            this.progressBar_thongke = new System.Windows.Forms.ProgressBar();
            this.label_thongke = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Tick = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataKho = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kho_Gia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kho_NamXuatBan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKho)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Kho_Gia);
            this.groupBox1.Controls.Add(this.Kho_MenhGia);
            this.groupBox1.Controls.Add(this.Kho_NhaXuatBan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Kho_NamXuatBan);
            this.groupBox1.Controls.Add(this.Kho_TheLoai);
            this.groupBox1.Controls.Add(this.Kho_MaSach);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Kho_TacGia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Kho_TenSach);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhập";
            // 
            // Kho_Gia
            // 
            this.Kho_Gia.Location = new System.Drawing.Point(87, 242);
            this.Kho_Gia.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.Kho_Gia.Name = "Kho_Gia";
            this.Kho_Gia.Size = new System.Drawing.Size(128, 22);
            this.Kho_Gia.TabIndex = 6;
            this.Kho_Gia.Validating += new System.ComponentModel.CancelEventHandler(this.Kho_Gia_Validating);
            // 
            // Kho_MenhGia
            // 
            this.Kho_MenhGia.Location = new System.Drawing.Point(213, 242);
            this.Kho_MenhGia.Name = "Kho_MenhGia";
            this.Kho_MenhGia.ReadOnly = true;
            this.Kho_MenhGia.Size = new System.Drawing.Size(79, 22);
            this.Kho_MenhGia.TabIndex = 6;
            this.Kho_MenhGia.Text = ".000 đồng";
            // 
            // Kho_NhaXuatBan
            // 
            this.Kho_NhaXuatBan.Location = new System.Drawing.Point(87, 208);
            this.Kho_NhaXuatBan.Name = "Kho_NhaXuatBan";
            this.Kho_NhaXuatBan.Size = new System.Drawing.Size(205, 22);
            this.Kho_NhaXuatBan.TabIndex = 5;
            this.Kho_NhaXuatBan.Validating += new System.ComponentModel.CancelEventHandler(this.Kho_NhaXuatBan_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nhà xuất bản :";
            // 
            // Kho_NamXuatBan
            // 
            this.Kho_NamXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kho_NamXuatBan.Location = new System.Drawing.Point(86, 172);
            this.Kho_NamXuatBan.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.Kho_NamXuatBan.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Kho_NamXuatBan.Name = "Kho_NamXuatBan";
            this.Kho_NamXuatBan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Kho_NamXuatBan.Size = new System.Drawing.Size(205, 22);
            this.Kho_NamXuatBan.TabIndex = 4;
            this.Kho_NamXuatBan.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Kho_NamXuatBan.Validating += new System.ComponentModel.CancelEventHandler(this.Kho_NamXuatBan_Validating);
            // 
            // Kho_TheLoai
            // 
            this.Kho_TheLoai.BackColor = System.Drawing.SystemColors.Window;
            this.Kho_TheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Kho_TheLoai.FormattingEnabled = true;
            this.Kho_TheLoai.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.Kho_TheLoai.Location = new System.Drawing.Point(86, 102);
            this.Kho_TheLoai.Name = "Kho_TheLoai";
            this.Kho_TheLoai.Size = new System.Drawing.Size(205, 24);
            this.Kho_TheLoai.TabIndex = 2;
            this.Kho_TheLoai.Validating += new System.ComponentModel.CancelEventHandler(this.Kho_TheLoai_Validating);
            // 
            // Kho_MaSach
            // 
            this.Kho_MaSach.Enabled = false;
            this.Kho_MaSach.Location = new System.Drawing.Point(87, 31);
            this.Kho_MaSach.Name = "Kho_MaSach";
            this.Kho_MaSach.Size = new System.Drawing.Size(204, 22);
            this.Kho_MaSach.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Giá :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Năm xuất bản :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thể loại :";
            // 
            // Kho_TacGia
            // 
            this.Kho_TacGia.Location = new System.Drawing.Point(86, 139);
            this.Kho_TacGia.Name = "Kho_TacGia";
            this.Kho_TacGia.Size = new System.Drawing.Size(205, 22);
            this.Kho_TacGia.TabIndex = 3;
            this.Kho_TacGia.Validating += new System.ComponentModel.CancelEventHandler(this.Kho_TacGia_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tác giả :";
            // 
            // Kho_TenSach
            // 
            this.Kho_TenSach.Location = new System.Drawing.Point(87, 59);
            this.Kho_TenSach.Multiline = true;
            this.Kho_TenSach.Name = "Kho_TenSach";
            this.Kho_TenSach.Size = new System.Drawing.Size(204, 34);
            this.Kho_TenSach.TabIndex = 1;
            this.Kho_TenSach.Validating += new System.ComponentModel.CancelEventHandler(this.Kho_TenSach_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sách :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button_Tim);
            this.groupBox2.Controls.Add(this.comboBox_Tim);
            this.groupBox2.Controls.Add(this.button_Sua);
            this.groupBox2.Controls.Add(this.button_Xoa);
            this.groupBox2.Controls.Add(this.button_Them);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(332, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 275);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Chọn cách tìm";
            // 
            // button_Tim
            // 
            this.button_Tim.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Tim.Location = new System.Drawing.Point(6, 215);
            this.button_Tim.Name = "button_Tim";
            this.button_Tim.Size = new System.Drawing.Size(75, 45);
            this.button_Tim.TabIndex = 4;
            this.button_Tim.Text = "Tìm";
            this.button_Tim.UseVisualStyleBackColor = true;
            this.button_Tim.Click += new System.EventHandler(this.button_Tim_Click);
            // 
            // comboBox_Tim
            // 
            this.comboBox_Tim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Tim.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Tim.FormattingEnabled = true;
            this.comboBox_Tim.Items.AddRange(new object[] {
            "Mã sách",
            "Tên sách",
            "Thể loại",
            "Tên tác giả",
            "Đã cũ",
            "Tất cả"});
            this.comboBox_Tim.Location = new System.Drawing.Point(6, 185);
            this.comboBox_Tim.Name = "comboBox_Tim";
            this.comboBox_Tim.Size = new System.Drawing.Size(75, 24);
            this.comboBox_Tim.TabIndex = 3;
            this.comboBox_Tim.SelectedIndexChanged += new System.EventHandler(this.comboBox_Tim_SelectedIndexChanged);
            // 
            // button_Sua
            // 
            this.button_Sua.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sua.Location = new System.Drawing.Point(6, 117);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(75, 40);
            this.button_Sua.TabIndex = 2;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.Location = new System.Drawing.Point(6, 71);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(75, 40);
            this.button_Xoa.TabIndex = 1;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Them
            // 
            this.button_Them.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.Location = new System.Drawing.Point(6, 25);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(75, 40);
            this.button_Them.TabIndex = 0;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button_Excel);
            this.groupBox3.Controls.Add(this.button_PDF);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(442, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 56);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xuất dữ liệu";
            // 
            // button_Excel
            // 
            this.button_Excel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Excel.Image = global::QuanLyKho.Properties.Resources.file_type_excel_icon_130611;
            this.button_Excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Excel.Location = new System.Drawing.Point(361, 21);
            this.button_Excel.Name = "button_Excel";
            this.button_Excel.Size = new System.Drawing.Size(137, 25);
            this.button_Excel.TabIndex = 5;
            this.button_Excel.Text = "Kho sách Excel";
            this.button_Excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Excel.UseVisualStyleBackColor = true;
            this.button_Excel.Click += new System.EventHandler(this.button_Excel_Click);
            // 
            // button_PDF
            // 
            this.button_PDF.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PDF.Image = global::QuanLyKho.Properties.Resources.file_type_pdf_icon_130274;
            this.button_PDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_PDF.Location = new System.Drawing.Point(11, 21);
            this.button_PDF.Name = "button_PDF";
            this.button_PDF.Size = new System.Drawing.Size(162, 25);
            this.button_PDF.TabIndex = 4;
            this.button_PDF.Text = " Thông tin sách PDF";
            this.button_PDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_PDF.UseVisualStyleBackColor = true;
            this.button_PDF.Click += new System.EventHandler(this.button_PDF_Click);
            // 
            // progressBar_thongke
            // 
            this.progressBar_thongke.Location = new System.Drawing.Point(442, 260);
            this.progressBar_thongke.Name = "progressBar_thongke";
            this.progressBar_thongke.Size = new System.Drawing.Size(453, 23);
            this.progressBar_thongke.TabIndex = 5;
            // 
            // label_thongke
            // 
            this.label_thongke.AutoSize = true;
            this.label_thongke.Location = new System.Drawing.Point(901, 266);
            this.label_thongke.Name = "label_thongke";
            this.label_thongke.Size = new System.Drawing.Size(42, 13);
            this.label_thongke.TabIndex = 6;
            this.label_thongke.Text = "??/500";
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
            // dataKho
            // 
            this.dataKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKho.Location = new System.Drawing.Point(442, 88);
            this.dataKho.Name = "dataKho";
            this.dataKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKho.Size = new System.Drawing.Size(504, 166);
            this.dataKho.TabIndex = 7;
            this.dataKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKho_CellClick_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(647, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Kho sách";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(442, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 2);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(724, 77);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 2);
            this.textBox2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::QuanLyKho.Properties.Resources.file_type_pdf_icon_130274;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(183, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Danh sách sách PDF";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 295);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataKho);
            this.Controls.Add(this.label_thongke);
            this.Controls.Add(this.progressBar_thongke);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuanLyKho";
            this.Text = "Quản lý kho sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuanLyKho_FormClosing);
            this.Load += new System.EventHandler(this.QuanLyKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kho_Gia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kho_NamXuatBan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Kho_TacGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Kho_TenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_Tim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox_Tim;
        private System.Windows.Forms.TextBox Kho_MaSach;
        private System.Windows.Forms.Button button_Excel;
        private System.Windows.Forms.Button button_PDF;
        private System.Windows.Forms.ComboBox Kho_TheLoai;
        private System.Windows.Forms.NumericUpDown Kho_NamXuatBan;
        private System.Windows.Forms.ProgressBar progressBar_thongke;
        private System.Windows.Forms.Label label_thongke;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider Tick;
        private System.Windows.Forms.TextBox Kho_NhaXuatBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Kho_MenhGia;
        private System.Windows.Forms.NumericUpDown Kho_Gia;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataKho;
        private System.Windows.Forms.Button button1;
    }
}

