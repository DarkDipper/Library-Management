namespace QuanLyKho
{
    partial class XuatKhoSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XuatKhoSach));
            this.xuatKho_Thoat = new System.Windows.Forms.Button();
            this.xuatKho_xuat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xuatKho_ten = new System.Windows.Forms.TextBox();
            this.xuatKho_duongdan = new System.Windows.Forms.TextBox();
            this.buttonxuatKho_duongDan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xuatKho_Thoat
            // 
            this.xuatKho_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.xuatKho_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatKho_Thoat.Location = new System.Drawing.Point(297, 89);
            this.xuatKho_Thoat.Name = "xuatKho_Thoat";
            this.xuatKho_Thoat.Size = new System.Drawing.Size(151, 33);
            this.xuatKho_Thoat.TabIndex = 22;
            this.xuatKho_Thoat.Text = "Thoát";
            this.xuatKho_Thoat.UseVisualStyleBackColor = true;
            this.xuatKho_Thoat.Click += new System.EventHandler(this.xuatKho_Thoat_Click);
            // 
            // xuatKho_xuat
            // 
            this.xuatKho_xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatKho_xuat.Location = new System.Drawing.Point(119, 89);
            this.xuatKho_xuat.Name = "xuatKho_xuat";
            this.xuatKho_xuat.Size = new System.Drawing.Size(151, 33);
            this.xuatKho_xuat.TabIndex = 21;
            this.xuatKho_xuat.Text = "Xuất và cập nhật";
            this.xuatKho_xuat.UseVisualStyleBackColor = true;
            this.xuatKho_xuat.Click += new System.EventHandler(this.xuatKho_xuat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên file :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Địa chỉ :";
            // 
            // xuatKho_ten
            // 
            this.xuatKho_ten.Location = new System.Drawing.Point(109, 50);
            this.xuatKho_ten.Name = "xuatKho_ten";
            this.xuatKho_ten.Size = new System.Drawing.Size(248, 20);
            this.xuatKho_ten.TabIndex = 18;
            // 
            // xuatKho_duongdan
            // 
            this.xuatKho_duongdan.Location = new System.Drawing.Point(109, 24);
            this.xuatKho_duongdan.Name = "xuatKho_duongdan";
            this.xuatKho_duongdan.ReadOnly = true;
            this.xuatKho_duongdan.Size = new System.Drawing.Size(337, 20);
            this.xuatKho_duongdan.TabIndex = 17;
            this.xuatKho_duongdan.Text = "C:\\Users\\";
            // 
            // buttonxuatKho_duongDan
            // 
            this.buttonxuatKho_duongDan.Location = new System.Drawing.Point(450, 23);
            this.buttonxuatKho_duongDan.Name = "buttonxuatKho_duongDan";
            this.buttonxuatKho_duongDan.Size = new System.Drawing.Size(126, 23);
            this.buttonxuatKho_duongDan.TabIndex = 16;
            this.buttonxuatKho_duongDan.Text = "Thay đổi đường dẫn";
            this.buttonxuatKho_duongDan.UseVisualStyleBackColor = true;
            this.buttonxuatKho_duongDan.Click += new System.EventHandler(this.buttonxuatKho_duongDan_Click);
            // 
            // XuatKhoSach
            // 
            this.AcceptButton = this.xuatKho_xuat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.xuatKho_Thoat;
            this.ClientSize = new System.Drawing.Size(629, 147);
            this.Controls.Add(this.xuatKho_Thoat);
            this.Controls.Add(this.xuatKho_xuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xuatKho_ten);
            this.Controls.Add(this.xuatKho_duongdan);
            this.Controls.Add(this.buttonxuatKho_duongDan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "XuatKhoSach";
            this.Text = "Xuất kho sách - Excel";
            this.Load += new System.EventHandler(this.XuatKhoSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button xuatKho_Thoat;
        private System.Windows.Forms.Button xuatKho_xuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xuatKho_ten;
        private System.Windows.Forms.TextBox xuatKho_duongdan;
        private System.Windows.Forms.Button buttonxuatKho_duongDan;
    }
}