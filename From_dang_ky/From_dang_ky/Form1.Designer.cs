namespace From_dang_ky
{
    partial class Form_DangKy
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
            this.label_Hoten = new System.Windows.Forms.Label();
            this.txt_Hoten = new System.Windows.Forms.TextBox();
            this.label_NgaySinh = new System.Windows.Forms.Label();
            this.label_DiaChi = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.DatePick_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label_BoPhan = new System.Windows.Forms.Label();
            this.combo_Bophan = new System.Windows.Forms.ComboBox();
            this.label_SDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.combo_BangCap = new System.Windows.Forms.ComboBox();
            this.Check = new System.Windows.Forms.ErrorProvider(this.components);
            this.button_DangKy = new System.Windows.Forms.Button();
            this.Button_X = new System.Windows.Forms.Label();
            this.Button_Minisize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Check)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Hoten
            // 
            this.label_Hoten.AutoSize = true;
            this.label_Hoten.BackColor = System.Drawing.Color.Transparent;
            this.label_Hoten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Hoten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_Hoten.Location = new System.Drawing.Point(81, 49);
            this.label_Hoten.Name = "label_Hoten";
            this.label_Hoten.Size = new System.Drawing.Size(74, 19);
            this.label_Hoten.TabIndex = 0;
            this.label_Hoten.Text = "Họ và tên";
            // 
            // txt_Hoten
            // 
            this.txt_Hoten.Location = new System.Drawing.Point(57, 71);
            this.txt_Hoten.Name = "txt_Hoten";
            this.txt_Hoten.Size = new System.Drawing.Size(245, 26);
            this.txt_Hoten.TabIndex = 1;
            this.txt_Hoten.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Hoten_Validating);
            // 
            // label_NgaySinh
            // 
            this.label_NgaySinh.AutoSize = true;
            this.label_NgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.label_NgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_NgaySinh.Location = new System.Drawing.Point(81, 124);
            this.label_NgaySinh.Name = "label_NgaySinh";
            this.label_NgaySinh.Size = new System.Drawing.Size(76, 19);
            this.label_NgaySinh.TabIndex = 0;
            this.label_NgaySinh.Text = "Ngày sinh";
            // 
            // label_DiaChi
            // 
            this.label_DiaChi.AutoSize = true;
            this.label_DiaChi.BackColor = System.Drawing.Color.Transparent;
            this.label_DiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_DiaChi.Location = new System.Drawing.Point(81, 191);
            this.label_DiaChi.Name = "label_DiaChi";
            this.label_DiaChi.Size = new System.Drawing.Size(56, 19);
            this.label_DiaChi.TabIndex = 0;
            this.label_DiaChi.Text = "Địa chỉ";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(57, 213);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(245, 26);
            this.txt_DiaChi.TabIndex = 3;
            this.txt_DiaChi.Validating += new System.ComponentModel.CancelEventHandler(this.txt_DiaChi_Validating);
            // 
            // DatePick_NgaySinh
            // 
            this.DatePick_NgaySinh.CustomFormat = "dd/MM/yyy";
            this.DatePick_NgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePick_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePick_NgaySinh.Location = new System.Drawing.Point(57, 147);
            this.DatePick_NgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.DatePick_NgaySinh.Name = "DatePick_NgaySinh";
            this.DatePick_NgaySinh.Size = new System.Drawing.Size(245, 26);
            this.DatePick_NgaySinh.TabIndex = 2;
            this.DatePick_NgaySinh.Validating += new System.ComponentModel.CancelEventHandler(this.DatePick_NgaySinh_Validating);
            // 
            // label_BoPhan
            // 
            this.label_BoPhan.AutoSize = true;
            this.label_BoPhan.BackColor = System.Drawing.Color.Transparent;
            this.label_BoPhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BoPhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_BoPhan.Location = new System.Drawing.Point(377, 124);
            this.label_BoPhan.Name = "label_BoPhan";
            this.label_BoPhan.Size = new System.Drawing.Size(64, 19);
            this.label_BoPhan.TabIndex = 3;
            this.label_BoPhan.Text = "Bộ phận";
            // 
            // combo_Bophan
            // 
            this.combo_Bophan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Bophan.FormattingEnabled = true;
            this.combo_Bophan.Items.AddRange(new object[] {
            "Thủ thư",
            "Thủ kho",
            "Thủ quỹ"});
            this.combo_Bophan.Location = new System.Drawing.Point(353, 146);
            this.combo_Bophan.Name = "combo_Bophan";
            this.combo_Bophan.Size = new System.Drawing.Size(223, 27);
            this.combo_Bophan.TabIndex = 5;
            this.combo_Bophan.SelectedIndexChanged += new System.EventHandler(this.combo_Bophan_SelectedIndexChanged);
            this.combo_Bophan.Validating += new System.ComponentModel.CancelEventHandler(this.combo_Bophan_Validating);
            // 
            // label_SDT
            // 
            this.label_SDT.AutoSize = true;
            this.label_SDT.BackColor = System.Drawing.Color.Transparent;
            this.label_SDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_SDT.Location = new System.Drawing.Point(377, 191);
            this.label_SDT.Name = "label_SDT";
            this.label_SDT.Size = new System.Drawing.Size(95, 19);
            this.label_SDT.TabIndex = 0;
            this.label_SDT.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(353, 213);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(223, 26);
            this.txtSDT.TabIndex = 6;
            this.txtSDT.Validating += new System.ComponentModel.CancelEventHandler(this.txtSDT_Validating);
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.BackColor = System.Drawing.Color.Transparent;
            this.label_Email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_Email.Location = new System.Drawing.Point(377, 49);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(71, 19);
            this.label_Email.TabIndex = 0;
            this.label_Email.Text = "Bằng cấp";
            // 
            // combo_BangCap
            // 
            this.combo_BangCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_BangCap.FormattingEnabled = true;
            this.combo_BangCap.Items.AddRange(new object[] {
            "Tú tài",
            "Trung cấp",
            "Cao đẳng",
            "Đại học",
            "Thạc sĩ",
            "Tiến sĩ"});
            this.combo_BangCap.Location = new System.Drawing.Point(353, 71);
            this.combo_BangCap.Name = "combo_BangCap";
            this.combo_BangCap.Size = new System.Drawing.Size(223, 27);
            this.combo_BangCap.TabIndex = 4;
            this.combo_BangCap.Validating += new System.ComponentModel.CancelEventHandler(this.combo_BangCap_Validating);
            // 
            // Check
            // 
            this.Check.BlinkRate = 0;
            this.Check.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Check.ContainerControl = this;
            // 
            // button_DangKy
            // 
            this.button_DangKy.AutoSize = true;
            this.button_DangKy.BackColor = System.Drawing.Color.Red;
            this.button_DangKy.FlatAppearance.BorderSize = 0;
            this.button_DangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DangKy.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DangKy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_DangKy.Location = new System.Drawing.Point(255, 293);
            this.button_DangKy.Name = "button_DangKy";
            this.button_DangKy.Size = new System.Drawing.Size(122, 53);
            this.button_DangKy.TabIndex = 7;
            this.button_DangKy.Text = "Đăng ký";
            this.button_DangKy.UseVisualStyleBackColor = false;
            this.button_DangKy.Click += new System.EventHandler(this.button_DangKy_Click);
            // 
            // Button_X
            // 
            this.Button_X.AutoSize = true;
            this.Button_X.BackColor = System.Drawing.Color.Transparent;
            this.Button_X.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_X.Location = new System.Drawing.Point(573, -1);
            this.Button_X.Name = "Button_X";
            this.Button_X.Size = new System.Drawing.Size(23, 27);
            this.Button_X.TabIndex = 8;
            this.Button_X.Text = "X";
            this.Button_X.Click += new System.EventHandler(this.Button_X_Click);
            // 
            // Button_Minisize
            // 
            this.Button_Minisize.AutoSize = true;
            this.Button_Minisize.BackColor = System.Drawing.Color.Transparent;
            this.Button_Minisize.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Minisize.Location = new System.Drawing.Point(538, -10);
            this.Button_Minisize.Name = "Button_Minisize";
            this.Button_Minisize.Size = new System.Drawing.Size(23, 27);
            this.Button_Minisize.TabIndex = 9;
            this.Button_Minisize.Text = "_";
            this.Button_Minisize.Click += new System.EventHandler(this.Button_Minisize_Click);
            // 
            // Form_DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::From_dang_ky.Properties.Resources.vector_wallpaper_29;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 362);
            this.Controls.Add(this.Button_Minisize);
            this.Controls.Add(this.Button_X);
            this.Controls.Add(this.button_DangKy);
            this.Controls.Add(this.combo_BangCap);
            this.Controls.Add(this.combo_Bophan);
            this.Controls.Add(this.label_BoPhan);
            this.Controls.Add(this.DatePick_NgaySinh);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_Hoten);
            this.Controls.Add(this.label_SDT);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_DiaChi);
            this.Controls.Add(this.label_NgaySinh);
            this.Controls.Add(this.label_Hoten);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(50, 50);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_DangKy_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Check)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Hoten;
        private System.Windows.Forms.TextBox txt_Hoten;
        private System.Windows.Forms.Label label_NgaySinh;
        private System.Windows.Forms.Label label_DiaChi;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.DateTimePicker DatePick_NgaySinh;
        private System.Windows.Forms.Label label_BoPhan;
        private System.Windows.Forms.ComboBox combo_Bophan;
        private System.Windows.Forms.Label label_SDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.ComboBox combo_BangCap;
        private System.Windows.Forms.ErrorProvider Check;
        private System.Windows.Forms.Button button_DangKy;
        private System.Windows.Forms.Label Button_X;
        private System.Windows.Forms.Label Button_Minisize;
    }
}

