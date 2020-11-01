namespace QLDG
{
    partial class PhieuMuon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuMuon));
            this.xuatMuon_Thoat = new System.Windows.Forms.Button();
            this.xuatMuon_xuat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xuatMuon_ten = new System.Windows.Forms.TextBox();
            this.xuatMuon_duongdan = new System.Windows.Forms.TextBox();
            this.buttonxuatMuon_duongDan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xuatMuon_Thoat
            // 
            this.xuatMuon_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.xuatMuon_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatMuon_Thoat.Location = new System.Drawing.Point(308, 85);
            this.xuatMuon_Thoat.Name = "xuatMuon_Thoat";
            this.xuatMuon_Thoat.Size = new System.Drawing.Size(151, 33);
            this.xuatMuon_Thoat.TabIndex = 29;
            this.xuatMuon_Thoat.Text = "Thoát";
            this.xuatMuon_Thoat.UseVisualStyleBackColor = true;
            this.xuatMuon_Thoat.Click += new System.EventHandler(this.xuatMuon_Thoat_Click);
            // 
            // xuatMuon_xuat
            // 
            this.xuatMuon_xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatMuon_xuat.Location = new System.Drawing.Point(130, 85);
            this.xuatMuon_xuat.Name = "xuatMuon_xuat";
            this.xuatMuon_xuat.Size = new System.Drawing.Size(151, 33);
            this.xuatMuon_xuat.TabIndex = 28;
            this.xuatMuon_xuat.Text = "Xuất và cập nhật";
            this.xuatMuon_xuat.UseVisualStyleBackColor = true;
            this.xuatMuon_xuat.Click += new System.EventHandler(this.xuatMuon_xuat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tên file :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Địa chỉ :";
            // 
            // xuatMuon_ten
            // 
            this.xuatMuon_ten.Location = new System.Drawing.Point(120, 46);
            this.xuatMuon_ten.Name = "xuatMuon_ten";
            this.xuatMuon_ten.Size = new System.Drawing.Size(248, 20);
            this.xuatMuon_ten.TabIndex = 25;
            // 
            // xuatMuon_duongdan
            // 
            this.xuatMuon_duongdan.Location = new System.Drawing.Point(120, 20);
            this.xuatMuon_duongdan.Name = "xuatMuon_duongdan";
            this.xuatMuon_duongdan.ReadOnly = true;
            this.xuatMuon_duongdan.Size = new System.Drawing.Size(337, 20);
            this.xuatMuon_duongdan.TabIndex = 24;
            this.xuatMuon_duongdan.Text = "C:\\Users\\";
            // 
            // buttonxuatMuon_duongDan
            // 
            this.buttonxuatMuon_duongDan.Location = new System.Drawing.Point(461, 19);
            this.buttonxuatMuon_duongDan.Name = "buttonxuatMuon_duongDan";
            this.buttonxuatMuon_duongDan.Size = new System.Drawing.Size(126, 23);
            this.buttonxuatMuon_duongDan.TabIndex = 23;
            this.buttonxuatMuon_duongDan.Text = "Thay đổi đường dẫn";
            this.buttonxuatMuon_duongDan.UseVisualStyleBackColor = true;
            this.buttonxuatMuon_duongDan.Click += new System.EventHandler(this.buttonxuatMuon_duongDan_Click);
            // 
            // PhieuMuon
            // 
            this.AcceptButton = this.xuatMuon_xuat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.xuatMuon_Thoat;
            this.ClientSize = new System.Drawing.Size(677, 134);
            this.Controls.Add(this.xuatMuon_Thoat);
            this.Controls.Add(this.xuatMuon_xuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xuatMuon_ten);
            this.Controls.Add(this.xuatMuon_duongdan);
            this.Controls.Add(this.buttonxuatMuon_duongDan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PhieuMuon";
            this.Text = "PhieuMuon";
            this.Load += new System.EventHandler(this.PhieuMuon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button xuatMuon_Thoat;
        private System.Windows.Forms.Button xuatMuon_xuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xuatMuon_ten;
        private System.Windows.Forms.TextBox xuatMuon_duongdan;
        private System.Windows.Forms.Button buttonxuatMuon_duongDan;
    }
}