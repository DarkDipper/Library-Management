namespace WindowsFormsApp4
{
    partial class PhieuTraNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuTraNo));
            this.xuatNo_Thoat = new System.Windows.Forms.Button();
            this.xuatNo_xuat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xuatNo_ten = new System.Windows.Forms.TextBox();
            this.xuatNo_duongdan = new System.Windows.Forms.TextBox();
            this.buttonxuatNo_duongDan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xuatNo_Thoat
            // 
            this.xuatNo_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.xuatNo_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatNo_Thoat.Location = new System.Drawing.Point(280, 81);
            this.xuatNo_Thoat.Name = "xuatNo_Thoat";
            this.xuatNo_Thoat.Size = new System.Drawing.Size(151, 33);
            this.xuatNo_Thoat.TabIndex = 43;
            this.xuatNo_Thoat.Text = "Thoát";
            this.xuatNo_Thoat.UseVisualStyleBackColor = true;
            // 
            // xuatNo_xuat
            // 
            this.xuatNo_xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatNo_xuat.Location = new System.Drawing.Point(102, 81);
            this.xuatNo_xuat.Name = "xuatNo_xuat";
            this.xuatNo_xuat.Size = new System.Drawing.Size(151, 33);
            this.xuatNo_xuat.TabIndex = 42;
            this.xuatNo_xuat.Text = "Xuất phiếu";
            this.xuatNo_xuat.UseVisualStyleBackColor = true;
            this.xuatNo_xuat.Click += new System.EventHandler(this.xuatNo_xuat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tên file :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Địa chỉ :";
            // 
            // xuatNo_ten
            // 
            this.xuatNo_ten.Location = new System.Drawing.Point(92, 42);
            this.xuatNo_ten.Name = "xuatNo_ten";
            this.xuatNo_ten.Size = new System.Drawing.Size(248, 20);
            this.xuatNo_ten.TabIndex = 39;
            // 
            // xuatNo_duongdan
            // 
            this.xuatNo_duongdan.Location = new System.Drawing.Point(92, 16);
            this.xuatNo_duongdan.Name = "xuatNo_duongdan";
            this.xuatNo_duongdan.ReadOnly = true;
            this.xuatNo_duongdan.Size = new System.Drawing.Size(337, 20);
            this.xuatNo_duongdan.TabIndex = 38;
            this.xuatNo_duongdan.Text = "C:\\Users\\";
            // 
            // buttonxuatNo_duongDan
            // 
            this.buttonxuatNo_duongDan.Location = new System.Drawing.Point(433, 15);
            this.buttonxuatNo_duongDan.Name = "buttonxuatNo_duongDan";
            this.buttonxuatNo_duongDan.Size = new System.Drawing.Size(126, 23);
            this.buttonxuatNo_duongDan.TabIndex = 37;
            this.buttonxuatNo_duongDan.Text = "Thay đổi đường dẫn";
            this.buttonxuatNo_duongDan.UseVisualStyleBackColor = true;
            this.buttonxuatNo_duongDan.Click += new System.EventHandler(this.buttonxuatNo_duongDan_Click);
            // 
            // PhieuTraNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 135);
            this.Controls.Add(this.xuatNo_Thoat);
            this.Controls.Add(this.xuatNo_xuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xuatNo_ten);
            this.Controls.Add(this.xuatNo_duongdan);
            this.Controls.Add(this.buttonxuatNo_duongDan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PhieuTraNo";
            this.Text = "Xuất phiếu nợ";
            this.Load += new System.EventHandler(this.PhieuTraNo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button xuatNo_Thoat;
        private System.Windows.Forms.Button xuatNo_xuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xuatNo_ten;
        private System.Windows.Forms.TextBox xuatNo_duongdan;
        private System.Windows.Forms.Button buttonxuatNo_duongDan;
    }
}