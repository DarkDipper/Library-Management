﻿namespace QLDG
{
    partial class XuatBAng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XuatBAng));
            this.xuatBang_Thoat = new System.Windows.Forms.Button();
            this.xuatBang_xuat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xuatBang_ten = new System.Windows.Forms.TextBox();
            this.xuatBang_duongdan = new System.Windows.Forms.TextBox();
            this.buttonxuatBang_duongDan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xuatBang_Thoat
            // 
            this.xuatBang_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.xuatBang_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatBang_Thoat.Location = new System.Drawing.Point(272, 89);
            this.xuatBang_Thoat.Name = "xuatBang_Thoat";
            this.xuatBang_Thoat.Size = new System.Drawing.Size(151, 33);
            this.xuatBang_Thoat.TabIndex = 43;
            this.xuatBang_Thoat.Text = "Thoát";
            this.xuatBang_Thoat.UseVisualStyleBackColor = true;
            this.xuatBang_Thoat.Click += new System.EventHandler(this.xuatBang_Thoat_Click);
            // 
            // xuatBang_xuat
            // 
            this.xuatBang_xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatBang_xuat.Location = new System.Drawing.Point(94, 89);
            this.xuatBang_xuat.Name = "xuatBang_xuat";
            this.xuatBang_xuat.Size = new System.Drawing.Size(151, 33);
            this.xuatBang_xuat.TabIndex = 42;
            this.xuatBang_xuat.Text = "Xuất phiếu";
            this.xuatBang_xuat.UseVisualStyleBackColor = true;
            this.xuatBang_xuat.Click += new System.EventHandler(this.xuatBang_xuat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tên file :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Địa chỉ :";
            // 
            // xuatBang_ten
            // 
            this.xuatBang_ten.Location = new System.Drawing.Point(84, 50);
            this.xuatBang_ten.Name = "xuatBang_ten";
            this.xuatBang_ten.Size = new System.Drawing.Size(248, 20);
            this.xuatBang_ten.TabIndex = 39;
            // 
            // xuatBang_duongdan
            // 
            this.xuatBang_duongdan.Location = new System.Drawing.Point(84, 24);
            this.xuatBang_duongdan.Name = "xuatBang_duongdan";
            this.xuatBang_duongdan.ReadOnly = true;
            this.xuatBang_duongdan.Size = new System.Drawing.Size(337, 20);
            this.xuatBang_duongdan.TabIndex = 38;
            this.xuatBang_duongdan.Text = "C:\\Users\\";
            // 
            // buttonxuatBang_duongDan
            // 
            this.buttonxuatBang_duongDan.Location = new System.Drawing.Point(425, 23);
            this.buttonxuatBang_duongDan.Name = "buttonxuatBang_duongDan";
            this.buttonxuatBang_duongDan.Size = new System.Drawing.Size(126, 23);
            this.buttonxuatBang_duongDan.TabIndex = 37;
            this.buttonxuatBang_duongDan.Text = "Thay đổi đường dẫn";
            this.buttonxuatBang_duongDan.UseVisualStyleBackColor = true;
            this.buttonxuatBang_duongDan.Click += new System.EventHandler(this.buttonxuatBang_duongDan_Click);
            // 
            // XuatBAng
            // 
            this.AcceptButton = this.xuatBang_xuat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.xuatBang_Thoat;
            this.ClientSize = new System.Drawing.Size(560, 138);
            this.Controls.Add(this.xuatBang_Thoat);
            this.Controls.Add(this.xuatBang_xuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xuatBang_ten);
            this.Controls.Add(this.xuatBang_duongdan);
            this.Controls.Add(this.buttonxuatBang_duongDan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "XuatBAng";
            this.Text = "Xuất bảng thông kê thẻ độc giả";
            this.Load += new System.EventHandler(this.XuatBAng_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button xuatBang_Thoat;
        private System.Windows.Forms.Button xuatBang_xuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xuatBang_ten;
        private System.Windows.Forms.TextBox xuatBang_duongdan;
        private System.Windows.Forms.Button buttonxuatBang_duongDan;
    }
}