namespace QuanLyKho
{
    partial class DanhSachSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachSach));
            this.xuatDanhSachSach_Thoat = new System.Windows.Forms.Button();
            this.xuatDanhSachSach_xuat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xuatDanhSachSach_ten = new System.Windows.Forms.TextBox();
            this.xuatDanhSachSach_duongdan = new System.Windows.Forms.TextBox();
            this.buttonxuatDanhSachSach_duongDan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xuatDanhSachSach_Thoat
            // 
            this.xuatDanhSachSach_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.xuatDanhSachSach_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatDanhSachSach_Thoat.Location = new System.Drawing.Point(340, 84);
            this.xuatDanhSachSach_Thoat.Name = "xuatDanhSachSach_Thoat";
            this.xuatDanhSachSach_Thoat.Size = new System.Drawing.Size(109, 33);
            this.xuatDanhSachSach_Thoat.TabIndex = 22;
            this.xuatDanhSachSach_Thoat.Text = "Thoát";
            this.xuatDanhSachSach_Thoat.UseVisualStyleBackColor = true;
            this.xuatDanhSachSach_Thoat.Click += new System.EventHandler(this.xuatDanhSachSach_Thoat_Click);
            // 
            // xuatDanhSachSach_xuat
            // 
            this.xuatDanhSachSach_xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatDanhSachSach_xuat.Location = new System.Drawing.Point(155, 84);
            this.xuatDanhSachSach_xuat.Name = "xuatDanhSachSach_xuat";
            this.xuatDanhSachSach_xuat.Size = new System.Drawing.Size(164, 33);
            this.xuatDanhSachSach_xuat.TabIndex = 21;
            this.xuatDanhSachSach_xuat.Text = "Xuất danh sách sách";
            this.xuatDanhSachSach_xuat.UseVisualStyleBackColor = true;
            this.xuatDanhSachSach_xuat.Click += new System.EventHandler(this.xuatDanhSachSach_xuat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên file :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Địa chỉ xuất :";
            // 
            // xuatDanhSachSach_ten
            // 
            this.xuatDanhSachSach_ten.Location = new System.Drawing.Point(103, 45);
            this.xuatDanhSachSach_ten.Name = "xuatDanhSachSach_ten";
            this.xuatDanhSachSach_ten.Size = new System.Drawing.Size(248, 20);
            this.xuatDanhSachSach_ten.TabIndex = 18;
            // 
            // xuatDanhSachSach_duongdan
            // 
            this.xuatDanhSachSach_duongdan.Location = new System.Drawing.Point(103, 19);
            this.xuatDanhSachSach_duongdan.Name = "xuatDanhSachSach_duongdan";
            this.xuatDanhSachSach_duongdan.ReadOnly = true;
            this.xuatDanhSachSach_duongdan.Size = new System.Drawing.Size(337, 20);
            this.xuatDanhSachSach_duongdan.TabIndex = 17;
            this.xuatDanhSachSach_duongdan.Text = "C:\\Users\\";
            // 
            // buttonxuatDanhSachSach_duongDan
            // 
            this.buttonxuatDanhSachSach_duongDan.Location = new System.Drawing.Point(444, 18);
            this.buttonxuatDanhSachSach_duongDan.Name = "buttonxuatDanhSachSach_duongDan";
            this.buttonxuatDanhSachSach_duongDan.Size = new System.Drawing.Size(160, 23);
            this.buttonxuatDanhSachSach_duongDan.TabIndex = 16;
            this.buttonxuatDanhSachSach_duongDan.Text = "Thay đổi đường dẫn mặc định ";
            this.buttonxuatDanhSachSach_duongDan.UseVisualStyleBackColor = true;
            this.buttonxuatDanhSachSach_duongDan.Click += new System.EventHandler(this.buttonxuatDanhSachSach_duongDan_Click);
            // 
            // DanhSachSach
            // 
            this.AcceptButton = this.xuatDanhSachSach_xuat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.xuatDanhSachSach_Thoat;
            this.ClientSize = new System.Drawing.Size(629, 139);
            this.Controls.Add(this.xuatDanhSachSach_Thoat);
            this.Controls.Add(this.xuatDanhSachSach_xuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xuatDanhSachSach_ten);
            this.Controls.Add(this.xuatDanhSachSach_duongdan);
            this.Controls.Add(this.buttonxuatDanhSachSach_duongDan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DanhSachSach";
            this.Text = "Xuất danh sách sách - PDF";
            this.Load += new System.EventHandler(this.DanhSachSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button xuatDanhSachSach_Thoat;
        private System.Windows.Forms.Button xuatDanhSachSach_xuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xuatDanhSachSach_ten;
        private System.Windows.Forms.TextBox xuatDanhSachSach_duongdan;
        private System.Windows.Forms.Button buttonxuatDanhSachSach_duongDan;
    }
}