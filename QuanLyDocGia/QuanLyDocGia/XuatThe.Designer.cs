﻿namespace BM2
{
    partial class XuatThe
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
            this.xuatThe_ten = new System.Windows.Forms.TextBox();
            this.buttonxuatThe_duongDan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xuatThe_duongdan = new System.Windows.Forms.TextBox();
            this.xuatThe_xuat = new System.Windows.Forms.Button();
            this.xuatThe_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xuatThe_ten
            // 
            this.xuatThe_ten.Location = new System.Drawing.Point(139, 41);
            this.xuatThe_ten.Name = "xuatThe_ten";
            this.xuatThe_ten.Size = new System.Drawing.Size(248, 20);
            this.xuatThe_ten.TabIndex = 3;
            // 
            // buttonxuatThe_duongDan
            // 
            this.buttonxuatThe_duongDan.Location = new System.Drawing.Point(480, 14);
            this.buttonxuatThe_duongDan.Name = "buttonxuatThe_duongDan";
            this.buttonxuatThe_duongDan.Size = new System.Drawing.Size(160, 23);
            this.buttonxuatThe_duongDan.TabIndex = 0;
            this.buttonxuatThe_duongDan.Text = "Thay đổi đường dẫn mặc định ";
            this.buttonxuatThe_duongDan.UseVisualStyleBackColor = true;
            this.buttonxuatThe_duongDan.Click += new System.EventHandler(this.xuatThe_duongDan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Địa chỉ xuất :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên file :";
            // 
            // xuatThe_duongdan
            // 
            this.xuatThe_duongdan.Location = new System.Drawing.Point(139, 15);
            this.xuatThe_duongdan.Name = "xuatThe_duongdan";
            this.xuatThe_duongdan.ReadOnly = true;
            this.xuatThe_duongdan.Size = new System.Drawing.Size(337, 20);
            this.xuatThe_duongdan.TabIndex = 1;
            this.xuatThe_duongdan.Text = "C:\\Users\\";
            // 
            // xuatThe_xuat
            // 
            this.xuatThe_xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatThe_xuat.Location = new System.Drawing.Point(191, 80);
            this.xuatThe_xuat.Name = "xuatThe_xuat";
            this.xuatThe_xuat.Size = new System.Drawing.Size(109, 33);
            this.xuatThe_xuat.TabIndex = 7;
            this.xuatThe_xuat.Text = "Xuất thẻ";
            this.xuatThe_xuat.UseVisualStyleBackColor = true;
            this.xuatThe_xuat.Click += new System.EventHandler(this.xuatThe_xuat_Click);
            // 
            // xuatThe_Thoat
            // 
            this.xuatThe_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.xuatThe_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatThe_Thoat.Location = new System.Drawing.Point(327, 80);
            this.xuatThe_Thoat.Name = "xuatThe_Thoat";
            this.xuatThe_Thoat.Size = new System.Drawing.Size(109, 33);
            this.xuatThe_Thoat.TabIndex = 8;
            this.xuatThe_Thoat.Text = "Thoát";
            this.xuatThe_Thoat.UseVisualStyleBackColor = true;
            this.xuatThe_Thoat.Click += new System.EventHandler(this.xuatThe_Thoat_Click);
            // 
            // XuatThe
            // 
            this.AcceptButton = this.xuatThe_xuat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.xuatThe_Thoat;
            this.ClientSize = new System.Drawing.Size(652, 125);
            this.Controls.Add(this.xuatThe_Thoat);
            this.Controls.Add(this.xuatThe_xuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xuatThe_ten);
            this.Controls.Add(this.xuatThe_duongdan);
            this.Controls.Add(this.buttonxuatThe_duongDan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "XuatThe";
            this.Text = "Xuất thẻ độc giả";
            this.Load += new System.EventHandler(this.XuatThe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox xuatThe_ten;
        private System.Windows.Forms.Button buttonxuatThe_duongDan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xuatThe_duongdan;
        private System.Windows.Forms.Button xuatThe_xuat;
        private System.Windows.Forms.Button xuatThe_Thoat;
    }
}