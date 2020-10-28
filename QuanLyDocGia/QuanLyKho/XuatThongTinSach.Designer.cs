namespace QuanLyKho
{
    partial class XuatThongTinSach
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
            this.xuatThongTinSach_Thoat = new System.Windows.Forms.Button();
            this.xuatThongTinSach_xuat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xuatThongTinSach_ten = new System.Windows.Forms.TextBox();
            this.xuatThongTinSach_duongdan = new System.Windows.Forms.TextBox();
            this.buttonxuatThongTinSach_duongDan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xuatThongTinSach_Thoat
            // 
            this.xuatThongTinSach_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.xuatThongTinSach_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatThongTinSach_Thoat.Location = new System.Drawing.Point(358, 77);
            this.xuatThongTinSach_Thoat.Name = "xuatThongTinSach_Thoat";
            this.xuatThongTinSach_Thoat.Size = new System.Drawing.Size(109, 33);
            this.xuatThongTinSach_Thoat.TabIndex = 15;
            this.xuatThongTinSach_Thoat.Text = "Thoát";
            this.xuatThongTinSach_Thoat.UseVisualStyleBackColor = true;
            this.xuatThongTinSach_Thoat.Click += new System.EventHandler(this.xuatThongTinSach_Thoat_Click);
            // 
            // xuatThongTinSach_xuat
            // 
            this.xuatThongTinSach_xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatThongTinSach_xuat.Location = new System.Drawing.Point(173, 77);
            this.xuatThongTinSach_xuat.Name = "xuatThongTinSach_xuat";
            this.xuatThongTinSach_xuat.Size = new System.Drawing.Size(148, 33);
            this.xuatThongTinSach_xuat.TabIndex = 14;
            this.xuatThongTinSach_xuat.Text = "Xuất thông tin sách";
            this.xuatThongTinSach_xuat.UseVisualStyleBackColor = true;
            this.xuatThongTinSach_xuat.Click += new System.EventHandler(this.xuatThongTinSach_xuat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên file :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Địa chỉ xuất :";
            // 
            // xuatThongTinSach_ten
            // 
            this.xuatThongTinSach_ten.Location = new System.Drawing.Point(121, 38);
            this.xuatThongTinSach_ten.Name = "xuatThongTinSach_ten";
            this.xuatThongTinSach_ten.Size = new System.Drawing.Size(248, 20);
            this.xuatThongTinSach_ten.TabIndex = 11;
            // 
            // xuatThongTinSach_duongdan
            // 
            this.xuatThongTinSach_duongdan.Location = new System.Drawing.Point(121, 12);
            this.xuatThongTinSach_duongdan.Name = "xuatThongTinSach_duongdan";
            this.xuatThongTinSach_duongdan.ReadOnly = true;
            this.xuatThongTinSach_duongdan.Size = new System.Drawing.Size(337, 20);
            this.xuatThongTinSach_duongdan.TabIndex = 10;
            this.xuatThongTinSach_duongdan.Text = "C:\\Users\\";
            // 
            // buttonxuatThongTinSach_duongDan
            // 
            this.buttonxuatThongTinSach_duongDan.Location = new System.Drawing.Point(462, 11);
            this.buttonxuatThongTinSach_duongDan.Name = "buttonxuatThongTinSach_duongDan";
            this.buttonxuatThongTinSach_duongDan.Size = new System.Drawing.Size(160, 23);
            this.buttonxuatThongTinSach_duongDan.TabIndex = 9;
            this.buttonxuatThongTinSach_duongDan.Text = "Thay đổi đường dẫn mặc định ";
            this.buttonxuatThongTinSach_duongDan.UseVisualStyleBackColor = true;
            this.buttonxuatThongTinSach_duongDan.Click += new System.EventHandler(this.buttonxuatThongTinSach_duongDan_Click);
            // 
            // XuatThongTinSach
            // 
            this.AcceptButton = this.xuatThongTinSach_xuat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.xuatThongTinSach_Thoat;
            this.ClientSize = new System.Drawing.Size(677, 120);
            this.Controls.Add(this.xuatThongTinSach_Thoat);
            this.Controls.Add(this.xuatThongTinSach_xuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xuatThongTinSach_ten);
            this.Controls.Add(this.xuatThongTinSach_duongdan);
            this.Controls.Add(this.buttonxuatThongTinSach_duongDan);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "XuatThongTinSach";
            this.Text = "Xuất thông tin sách - PDF";
            this.Load += new System.EventHandler(this.XuatThongTinSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button xuatThongTinSach_Thoat;
        private System.Windows.Forms.Button xuatThongTinSach_xuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xuatThongTinSach_ten;
        private System.Windows.Forms.TextBox xuatThongTinSach_duongdan;
        private System.Windows.Forms.Button buttonxuatThongTinSach_duongDan;
    }
}