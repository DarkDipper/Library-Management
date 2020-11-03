namespace QLDG
{
    partial class PhieuTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuTra));
            this.xuatTra_Thoat = new System.Windows.Forms.Button();
            this.xuatTra_xuat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xuatTra_ten = new System.Windows.Forms.TextBox();
            this.xuatTra_duongdan = new System.Windows.Forms.TextBox();
            this.buttonxuatTra_duongDan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xuatTra_Thoat
            // 
            this.xuatTra_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.xuatTra_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatTra_Thoat.Location = new System.Drawing.Point(301, 83);
            this.xuatTra_Thoat.Name = "xuatTra_Thoat";
            this.xuatTra_Thoat.Size = new System.Drawing.Size(151, 33);
            this.xuatTra_Thoat.TabIndex = 36;
            this.xuatTra_Thoat.Text = "Thoát";
            this.xuatTra_Thoat.UseVisualStyleBackColor = true;
            this.xuatTra_Thoat.Click += new System.EventHandler(this.xuatTra_Thoat_Click);
            // 
            // xuatTra_xuat
            // 
            this.xuatTra_xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatTra_xuat.Location = new System.Drawing.Point(123, 83);
            this.xuatTra_xuat.Name = "xuatTra_xuat";
            this.xuatTra_xuat.Size = new System.Drawing.Size(151, 33);
            this.xuatTra_xuat.TabIndex = 35;
            this.xuatTra_xuat.Text = "Xuất phiếu";
            this.xuatTra_xuat.UseVisualStyleBackColor = true;
            this.xuatTra_xuat.Click += new System.EventHandler(this.xuatTra_xuat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tên file :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Địa chỉ :";
            // 
            // xuatTra_ten
            // 
            this.xuatTra_ten.Location = new System.Drawing.Point(113, 44);
            this.xuatTra_ten.Name = "xuatTra_ten";
            this.xuatTra_ten.Size = new System.Drawing.Size(248, 20);
            this.xuatTra_ten.TabIndex = 32;
            // 
            // xuatTra_duongdan
            // 
            this.xuatTra_duongdan.Location = new System.Drawing.Point(113, 18);
            this.xuatTra_duongdan.Name = "xuatTra_duongdan";
            this.xuatTra_duongdan.ReadOnly = true;
            this.xuatTra_duongdan.Size = new System.Drawing.Size(337, 20);
            this.xuatTra_duongdan.TabIndex = 31;
            this.xuatTra_duongdan.Text = "C:\\Users\\";
            // 
            // buttonxuatTra_duongDan
            // 
            this.buttonxuatTra_duongDan.Location = new System.Drawing.Point(454, 17);
            this.buttonxuatTra_duongDan.Name = "buttonxuatTra_duongDan";
            this.buttonxuatTra_duongDan.Size = new System.Drawing.Size(126, 23);
            this.buttonxuatTra_duongDan.TabIndex = 30;
            this.buttonxuatTra_duongDan.Text = "Thay đổi đường dẫn";
            this.buttonxuatTra_duongDan.UseVisualStyleBackColor = true;
            this.buttonxuatTra_duongDan.Click += new System.EventHandler(this.buttonxuatTra_duongDan_Click);
            // 
            // PhieuTra
            // 
            this.AcceptButton = this.xuatTra_xuat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.xuatTra_Thoat;
            this.ClientSize = new System.Drawing.Size(607, 139);
            this.Controls.Add(this.xuatTra_Thoat);
            this.Controls.Add(this.xuatTra_xuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xuatTra_ten);
            this.Controls.Add(this.xuatTra_duongdan);
            this.Controls.Add(this.buttonxuatTra_duongDan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PhieuTra";
            this.Text = "Xuất phiếu trả";
            this.Load += new System.EventHandler(this.PhieuTra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button xuatTra_Thoat;
        private System.Windows.Forms.Button xuatTra_xuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xuatTra_ten;
        private System.Windows.Forms.TextBox xuatTra_duongdan;
        private System.Windows.Forms.Button buttonxuatTra_duongDan;
    }
}