namespace BM2
{
    partial class Form1
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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Thongtin = new System.Windows.Forms.TabPage();
            this.label_thongke = new System.Windows.Forms.Label();
            this.progressBar_thongke = new System.Windows.Forms.ProgressBar();
            this.dataTheDocGia = new System.Windows.Forms.DataGridView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_Excel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonTìm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textMS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Eye = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonSign_up = new System.Windows.Forms.Button();
            this.f2NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.f2Type = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.f2Email = new System.Windows.Forms.TextBox();
            this.f2Address = new System.Windows.Forms.TextBox();
            this.f2Name = new System.Windows.Forms.TextBox();
            this.t7 = new System.Windows.Forms.Label();
            this.t6 = new System.Windows.Forms.Label();
            this.t5 = new System.Windows.Forms.Label();
            this.t4 = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.Label();
            this.t3 = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.Label();
            this.muon = new System.Windows.Forms.TabPage();
            this.tra = new System.Windows.Forms.TabPage();
            this.mat = new System.Windows.Forms.TabPage();
            this.er = new System.Windows.Forms.ErrorProvider(this.components);
            this.Tick = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.Thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTheDocGia)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.er)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Thongtin);
            this.tabControl1.Controls.Add(this.muon);
            this.tabControl1.Controls.Add(this.tra);
            this.tabControl1.Controls.Add(this.mat);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(938, 435);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Thongtin
            // 
            this.Thongtin.Controls.Add(this.label_thongke);
            this.Thongtin.Controls.Add(this.progressBar_thongke);
            this.Thongtin.Controls.Add(this.dataTheDocGia);
            this.Thongtin.Controls.Add(this.textBox5);
            this.Thongtin.Controls.Add(this.textBox4);
            this.Thongtin.Controls.Add(this.label2);
            this.Thongtin.Controls.Add(this.groupBox3);
            this.Thongtin.Controls.Add(this.groupBox2);
            this.Thongtin.Controls.Add(this.groupBox1);
            this.Thongtin.Location = new System.Drawing.Point(4, 22);
            this.Thongtin.Name = "Thongtin";
            this.Thongtin.Padding = new System.Windows.Forms.Padding(3);
            this.Thongtin.Size = new System.Drawing.Size(930, 409);
            this.Thongtin.TabIndex = 0;
            this.Thongtin.Text = "Thông tin";
            this.Thongtin.UseVisualStyleBackColor = true;
            // 
            // label_thongke
            // 
            this.label_thongke.AutoSize = true;
            this.label_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_thongke.Location = new System.Drawing.Point(874, 373);
            this.label_thongke.Name = "label_thongke";
            this.label_thongke.Size = new System.Drawing.Size(47, 16);
            this.label_thongke.TabIndex = 21;
            this.label_thongke.Text = "??/500";
            this.label_thongke.Click += new System.EventHandler(this.label_thongke_Click);
            // 
            // progressBar_thongke
            // 
            this.progressBar_thongke.Location = new System.Drawing.Point(7, 369);
            this.progressBar_thongke.Name = "progressBar_thongke";
            this.progressBar_thongke.Size = new System.Drawing.Size(861, 23);
            this.progressBar_thongke.TabIndex = 22;
            this.progressBar_thongke.Click += new System.EventHandler(this.progressBar_thongke_Click);
            // 
            // dataTheDocGia
            // 
            this.dataTheDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTheDocGia.Location = new System.Drawing.Point(7, 191);
            this.dataTheDocGia.Name = "dataTheDocGia";
            this.dataTheDocGia.Size = new System.Drawing.Size(911, 172);
            this.dataTheDocGia.TabIndex = 21;
            this.dataTheDocGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTheDocGia_CellContentClick);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Gold;
            this.textBox5.Location = new System.Drawing.Point(567, 180);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(351, 2);
            this.textBox5.TabIndex = 20;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Gold;
            this.textBox4.Location = new System.Drawing.Point(6, 179);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(347, 2);
            this.textBox4.TabIndex = 19;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "o0 Danh sách thẻ độc giả 0o";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Excel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(629, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 76);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xuất bảng sang Excel";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button_Excel
            // 
            this.button_Excel.Location = new System.Drawing.Point(83, 27);
            this.button_Excel.Name = "button_Excel";
            this.button_Excel.Size = new System.Drawing.Size(174, 33);
            this.button_Excel.TabIndex = 18;
            this.button_Excel.Text = "Xuất Excel";
            this.button_Excel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.buttonTìm);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(629, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 85);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(280, 22);
            this.textBox3.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tìm theo :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "X",
            "Y"});
            this.comboBox1.Location = new System.Drawing.Point(76, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 24);
            this.comboBox1.TabIndex = 19;
            // 
            // buttonTìm
            // 
            this.buttonTìm.Location = new System.Drawing.Point(172, 12);
            this.buttonTìm.Name = "buttonTìm";
            this.buttonTìm.Size = new System.Drawing.Size(117, 33);
            this.buttonTìm.TabIndex = 18;
            this.buttonTìm.Text = "Tìm kiếm";
            this.buttonTìm.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textMS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button_Eye);
            this.groupBox1.Controls.Add(this.buttonXoa);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.buttonSua);
            this.groupBox1.Controls.Add(this.buttonSign_up);
            this.groupBox1.Controls.Add(this.f2NgaySinh);
            this.groupBox1.Controls.Add(this.f2Type);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.f2Email);
            this.groupBox1.Controls.Add(this.f2Address);
            this.groupBox1.Controls.Add(this.f2Name);
            this.groupBox1.Controls.Add(this.t7);
            this.groupBox1.Controls.Add(this.t6);
            this.groupBox1.Controls.Add(this.t5);
            this.groupBox1.Controls.Add(this.t4);
            this.groupBox1.Controls.Add(this.t2);
            this.groupBox1.Controls.Add(this.t3);
            this.groupBox1.Controls.Add(this.t1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng chính";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textMS
            // 
            this.textMS.Location = new System.Drawing.Point(414, 73);
            this.textMS.Name = "textMS";
            this.textMS.ReadOnly = true;
            this.textMS.Size = new System.Drawing.Size(180, 22);
            this.textMS.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã độc giả :";
            // 
            // button_Eye
            // 
            this.button_Eye.Image = global::BM2.Properties.Resources._1490793864_user_interface16_82335;
            this.button_Eye.Location = new System.Drawing.Point(572, 43);
            this.button_Eye.Name = "button_Eye";
            this.button_Eye.Size = new System.Drawing.Size(22, 23);
            this.button_Eye.TabIndex = 18;
            this.button_Eye.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(472, 132);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(117, 30);
            this.buttonXoa.TabIndex = 17;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(333, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 30);
            this.button3.TabIndex = 16;
            this.button3.Text = "Xuất thẻ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(472, 101);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(117, 30);
            this.buttonSua.TabIndex = 15;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            // 
            // buttonSign_up
            // 
            this.buttonSign_up.Location = new System.Drawing.Point(333, 100);
            this.buttonSign_up.Name = "buttonSign_up";
            this.buttonSign_up.Size = new System.Drawing.Size(117, 30);
            this.buttonSign_up.TabIndex = 14;
            this.buttonSign_up.Text = "Đăng kí";
            this.buttonSign_up.UseVisualStyleBackColor = true;
            // 
            // f2NgaySinh
            // 
            this.f2NgaySinh.CustomFormat = "dd/MM/yyy";
            this.f2NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f2NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.f2NgaySinh.Location = new System.Drawing.Point(85, 46);
            this.f2NgaySinh.Name = "f2NgaySinh";
            this.f2NgaySinh.Size = new System.Drawing.Size(217, 22);
            this.f2NgaySinh.TabIndex = 13;
            this.f2NgaySinh.Leave += new System.EventHandler(this.f2NgaySinh_Leave);
            // 
            // f2Type
            // 
            this.f2Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.f2Type.FormattingEnabled = true;
            this.f2Type.Items.AddRange(new object[] {
            "X",
            "Y"});
            this.f2Type.Location = new System.Drawing.Point(85, 133);
            this.f2Type.Name = "f2Type";
            this.f2Type.Size = new System.Drawing.Size(217, 24);
            this.f2Type.TabIndex = 12;
            this.f2Type.Leave += new System.EventHandler(this.f2Type_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(414, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(414, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // f2Email
            // 
            this.f2Email.Location = new System.Drawing.Point(85, 104);
            this.f2Email.Name = "f2Email";
            this.f2Email.Size = new System.Drawing.Size(217, 22);
            this.f2Email.TabIndex = 9;
            this.f2Email.Leave += new System.EventHandler(this.f2Email_Leave);
            // 
            // f2Address
            // 
            this.f2Address.Location = new System.Drawing.Point(85, 76);
            this.f2Address.Name = "f2Address";
            this.f2Address.Size = new System.Drawing.Size(217, 22);
            this.f2Address.TabIndex = 8;
            this.f2Address.Leave += new System.EventHandler(this.f2Address_Leave);
            // 
            // f2Name
            // 
            this.f2Name.Location = new System.Drawing.Point(85, 15);
            this.f2Name.Name = "f2Name";
            this.f2Name.Size = new System.Drawing.Size(217, 22);
            this.f2Name.TabIndex = 7;
            this.f2Name.Leave += new System.EventHandler(this.f2Name_Leave);
            // 
            // t7
            // 
            this.t7.AutoSize = true;
            this.t7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t7.Location = new System.Drawing.Point(320, 47);
            this.t7.Name = "t7";
            this.t7.Size = new System.Drawing.Size(68, 16);
            this.t7.TabIndex = 6;
            this.t7.Text = "Mật khẩu :";
            // 
            // t6
            // 
            this.t6.AutoSize = true;
            this.t6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t6.Location = new System.Drawing.Point(316, 21);
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(102, 16);
            this.t6.TabIndex = 5;
            this.t6.Text = "Tên đăng nhập:";
            // 
            // t5
            // 
            this.t5.AutoSize = true;
            this.t5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t5.Location = new System.Drawing.Point(13, 138);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(40, 16);
            this.t5.TabIndex = 4;
            this.t5.Text = "Loại :";
            // 
            // t4
            // 
            this.t4.AutoSize = true;
            this.t4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t4.Location = new System.Drawing.Point(13, 110);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(48, 16);
            this.t4.TabIndex = 3;
            this.t4.Text = "Email :";
            // 
            // t2
            // 
            this.t2.AutoSize = true;
            this.t2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2.Location = new System.Drawing.Point(13, 49);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(74, 16);
            this.t2.TabIndex = 2;
            this.t2.Text = "Ngày sinh :";
            // 
            // t3
            // 
            this.t3.AutoSize = true;
            this.t3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t3.Location = new System.Drawing.Point(13, 80);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(54, 16);
            this.t3.TabIndex = 1;
            this.t3.Text = "Địa chỉ :";
            // 
            // t1
            // 
            this.t1.AutoSize = true;
            this.t1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1.Location = new System.Drawing.Point(13, 20);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(71, 16);
            this.t1.TabIndex = 0;
            this.t1.Text = "Họ và tên :";
            // 
            // muon
            // 
            this.muon.Location = new System.Drawing.Point(4, 22);
            this.muon.Name = "muon";
            this.muon.Padding = new System.Windows.Forms.Padding(3);
            this.muon.Size = new System.Drawing.Size(930, 409);
            this.muon.TabIndex = 1;
            this.muon.Text = "Mượn sách";
            this.muon.UseVisualStyleBackColor = true;
            // 
            // tra
            // 
            this.tra.Location = new System.Drawing.Point(4, 22);
            this.tra.Name = "tra";
            this.tra.Size = new System.Drawing.Size(930, 409);
            this.tra.TabIndex = 2;
            this.tra.Text = "Trả sách";
            this.tra.UseVisualStyleBackColor = true;
            // 
            // mat
            // 
            this.mat.Location = new System.Drawing.Point(4, 22);
            this.mat.Name = "mat";
            this.mat.Size = new System.Drawing.Size(930, 409);
            this.mat.TabIndex = 3;
            this.mat.Text = "Mất sách";
            this.mat.UseVisualStyleBackColor = true;
            // 
            // er
            // 
            this.er.ContainerControl = this;
            // 
            // Tick
            // 
            this.Tick.ContainerControl = this;
            this.Tick.Icon = ((System.Drawing.Icon)(resources.GetObject("Tick.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 459);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Thongtin.ResumeLayout(false);
            this.Thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTheDocGia)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.er)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Thongtin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label t7;
        private System.Windows.Forms.Label t6;
        private System.Windows.Forms.Label t5;
        private System.Windows.Forms.Label t4;
        private System.Windows.Forms.Label t2;
        private System.Windows.Forms.Label t3;
        private System.Windows.Forms.Label t1;
        private System.Windows.Forms.TabPage muon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker f2NgaySinh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox f2Email;
        private System.Windows.Forms.TextBox f2Address;
        private System.Windows.Forms.TextBox f2Name;
        private System.Windows.Forms.DataGridView dataTheDocGia;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Excel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonTìm;
        private System.Windows.Forms.Button button_Eye;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonSign_up;
        private System.Windows.Forms.ComboBox f2Type;
        private System.Windows.Forms.ErrorProvider er;
        private System.Windows.Forms.ErrorProvider Tick;
        private System.Windows.Forms.TabPage tra;
        private System.Windows.Forms.TabPage mat;
        private System.Windows.Forms.TextBox textMS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_thongke;
        private System.Windows.Forms.ProgressBar progressBar_thongke;
    }
}