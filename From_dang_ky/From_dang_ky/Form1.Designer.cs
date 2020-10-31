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
            ((System.ComponentModel.ISupportInitialize)(this.Check)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Hoten
            // 
            this.label_Hoten.AutoSize = true;
            this.label_Hoten.Location = new System.Drawing.Point(49, 53);
            this.label_Hoten.Name = "label_Hoten";
            this.label_Hoten.Size = new System.Drawing.Size(86, 22);
            this.label_Hoten.TabIndex = 0;
            this.label_Hoten.Text = "Họ và tên";
            // 
            // txt_Hoten
            // 
            this.txt_Hoten.Location = new System.Drawing.Point(169, 53);
            this.txt_Hoten.Name = "txt_Hoten";
            this.txt_Hoten.Size = new System.Drawing.Size(245, 30);
            this.txt_Hoten.TabIndex = 1;
            this.txt_Hoten.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Hoten_Validating);
            // 
            // label_NgaySinh
            // 
            this.label_NgaySinh.AutoSize = true;
            this.label_NgaySinh.Location = new System.Drawing.Point(49, 116);
            this.label_NgaySinh.Name = "label_NgaySinh";
            this.label_NgaySinh.Size = new System.Drawing.Size(88, 22);
            this.label_NgaySinh.TabIndex = 0;
            this.label_NgaySinh.Text = "Ngày sinh";
            // 
            // label_DiaChi
            // 
            this.label_DiaChi.AutoSize = true;
            this.label_DiaChi.Location = new System.Drawing.Point(49, 188);
            this.label_DiaChi.Name = "label_DiaChi";
            this.label_DiaChi.Size = new System.Drawing.Size(68, 22);
            this.label_DiaChi.TabIndex = 0;
            this.label_DiaChi.Text = "Địa chỉ";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(169, 180);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(245, 30);
            this.txt_DiaChi.TabIndex = 3;
            // 
            // DatePick_NgaySinh
            // 
            this.DatePick_NgaySinh.CustomFormat = "dd/MM/yyy";
            this.DatePick_NgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePick_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePick_NgaySinh.Location = new System.Drawing.Point(169, 116);
            this.DatePick_NgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.DatePick_NgaySinh.Name = "DatePick_NgaySinh";
            this.DatePick_NgaySinh.Size = new System.Drawing.Size(245, 30);
            this.DatePick_NgaySinh.TabIndex = 2;
            this.DatePick_NgaySinh.Validating += new System.ComponentModel.CancelEventHandler(this.DatePick_NgaySinh_Validating);
            // 
            // label_BoPhan
            // 
            this.label_BoPhan.AutoSize = true;
            this.label_BoPhan.Location = new System.Drawing.Point(49, 308);
            this.label_BoPhan.Name = "label_BoPhan";
            this.label_BoPhan.Size = new System.Drawing.Size(75, 22);
            this.label_BoPhan.TabIndex = 3;
            this.label_BoPhan.Text = "Bộ phận";
            // 
            // combo_Bophan
            // 
            this.combo_Bophan.FormattingEnabled = true;
            this.combo_Bophan.Items.AddRange(new object[] {
            "Thủ thư",
            "Thủ kho",
            "Thủ quỹ"});
            this.combo_Bophan.Location = new System.Drawing.Point(169, 300);
            this.combo_Bophan.Name = "combo_Bophan";
            this.combo_Bophan.Size = new System.Drawing.Size(245, 30);
            this.combo_Bophan.TabIndex = 5;
            this.combo_Bophan.Validating += new System.ComponentModel.CancelEventHandler(this.combo_Bophan_Validating);
            // 
            // label_SDT
            // 
            this.label_SDT.AutoSize = true;
            this.label_SDT.Location = new System.Drawing.Point(49, 363);
            this.label_SDT.Name = "label_SDT";
            this.label_SDT.Size = new System.Drawing.Size(114, 22);
            this.label_SDT.TabIndex = 0;
            this.label_SDT.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(169, 355);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(245, 30);
            this.txtSDT.TabIndex = 6;
            this.txtSDT.Validating += new System.ComponentModel.CancelEventHandler(this.txtSDT_Validating);
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(49, 248);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(83, 22);
            this.label_Email.TabIndex = 0;
            this.label_Email.Text = "Bằng cấp";
            // 
            // combo_BangCap
            // 
            this.combo_BangCap.FormattingEnabled = true;
            this.combo_BangCap.Items.AddRange(new object[] {
            "Tú tài",
            "Trung cấp",
            "Cao đẳng",
            "Đại học",
            "Thạc sĩ",
            "Tiến sĩ"});
            this.combo_BangCap.Location = new System.Drawing.Point(169, 240);
            this.combo_BangCap.Name = "combo_BangCap";
            this.combo_BangCap.Size = new System.Drawing.Size(245, 30);
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
            this.button_DangKy.Location = new System.Drawing.Point(169, 426);
            this.button_DangKy.Name = "button_DangKy";
            this.button_DangKy.Size = new System.Drawing.Size(85, 32);
            this.button_DangKy.TabIndex = 7;
            this.button_DangKy.Text = "Đăng ký";
            this.button_DangKy.UseVisualStyleBackColor = true;
            this.button_DangKy.Click += new System.EventHandler(this.button_DangKy_Click);
            // 
            // Form_DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(565, 514);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_DangKy";
            this.Text = "Đăng ký";
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
    }
}

