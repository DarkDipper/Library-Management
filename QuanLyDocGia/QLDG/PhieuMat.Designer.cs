namespace QLDG
{
    partial class PhieuMat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuMat));
            this.xuatMat_Thoat = new System.Windows.Forms.Button();
            this.xuatMat_xuat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xuatMat_ten = new System.Windows.Forms.TextBox();
            this.xuatMat_duongdan = new System.Windows.Forms.TextBox();
            this.buttonxuatMat_duongDan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xuatMat_Thoat
            // 
            this.xuatMat_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.xuatMat_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatMat_Thoat.Location = new System.Drawing.Point(275, 84);
            this.xuatMat_Thoat.Name = "xuatMat_Thoat";
            this.xuatMat_Thoat.Size = new System.Drawing.Size(151, 33);
            this.xuatMat_Thoat.TabIndex = 43;
            this.xuatMat_Thoat.Text = "Thoát";
            this.xuatMat_Thoat.UseVisualStyleBackColor = true;
            this.xuatMat_Thoat.Click += new System.EventHandler(this.xuatMat_Thoat_Click);
            // 
            // xuatMat_xuat
            // 
            this.xuatMat_xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatMat_xuat.Location = new System.Drawing.Point(97, 84);
            this.xuatMat_xuat.Name = "xuatMat_xuat";
            this.xuatMat_xuat.Size = new System.Drawing.Size(151, 33);
            this.xuatMat_xuat.TabIndex = 42;
            this.xuatMat_xuat.Text = "Xuất phiếu";
            this.xuatMat_xuat.UseVisualStyleBackColor = true;
            this.xuatMat_xuat.Click += new System.EventHandler(this.xuatMat_xuat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tên file :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Địa chỉ :";
            // 
            // xuatMat_ten
            // 
            this.xuatMat_ten.Location = new System.Drawing.Point(87, 45);
            this.xuatMat_ten.Name = "xuatMat_ten";
            this.xuatMat_ten.Size = new System.Drawing.Size(248, 20);
            this.xuatMat_ten.TabIndex = 39;
            // 
            // xuatMat_duongdan
            // 
            this.xuatMat_duongdan.Location = new System.Drawing.Point(87, 19);
            this.xuatMat_duongdan.Name = "xuatMat_duongdan";
            this.xuatMat_duongdan.ReadOnly = true;
            this.xuatMat_duongdan.Size = new System.Drawing.Size(337, 20);
            this.xuatMat_duongdan.TabIndex = 38;
            this.xuatMat_duongdan.Text = "C:\\Users\\";
            // 
            // buttonxuatMat_duongDan
            // 
            this.buttonxuatMat_duongDan.BackColor = System.Drawing.SystemColors.Control;
            this.buttonxuatMat_duongDan.Location = new System.Drawing.Point(428, 18);
            this.buttonxuatMat_duongDan.Name = "buttonxuatMat_duongDan";
            this.buttonxuatMat_duongDan.Size = new System.Drawing.Size(126, 23);
            this.buttonxuatMat_duongDan.TabIndex = 37;
            this.buttonxuatMat_duongDan.Text = "Thay đổi đường dẫn";
            this.buttonxuatMat_duongDan.UseVisualStyleBackColor = false;
            this.buttonxuatMat_duongDan.Click += new System.EventHandler(this.buttonxuatMat_duongDan_Click);
            // 
            // PhieuMat
            // 
            this.AcceptButton = this.xuatMat_xuat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.xuatMat_Thoat;
            this.ClientSize = new System.Drawing.Size(579, 136);
            this.Controls.Add(this.xuatMat_Thoat);
            this.Controls.Add(this.xuatMat_xuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xuatMat_ten);
            this.Controls.Add(this.xuatMat_duongdan);
            this.Controls.Add(this.buttonxuatMat_duongDan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PhieuMat";
            this.Text = "Ghi nhận mất sách";
            this.Load += new System.EventHandler(this.PhieuMat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button xuatMat_Thoat;
        private System.Windows.Forms.Button xuatMat_xuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xuatMat_ten;
        private System.Windows.Forms.TextBox xuatMat_duongdan;
        private System.Windows.Forms.Button buttonxuatMat_duongDan;
    }
}