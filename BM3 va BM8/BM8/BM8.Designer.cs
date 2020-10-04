namespace BM8
{
    partial class BM8
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
            this.label1 = new System.Windows.Forms.Label();
            this.MS_ten_sach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MS_ngay_ghi_nhan = new System.Windows.Forms.TextBox();
            this.MS_ten_doc_gia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MS_tien_phat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MS_nguoi_ghi_nhan = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Xac_nhan_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sách:";
            // 
            // MS_ten_sach
            // 
            this.MS_ten_sach.Location = new System.Drawing.Point(225, 50);
            this.MS_ten_sach.Name = "MS_ten_sach";
            this.MS_ten_sach.Size = new System.Drawing.Size(384, 22);
            this.MS_ten_sach.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày ghi nhận:";
            // 
            // MS_ngay_ghi_nhan
            // 
            this.MS_ngay_ghi_nhan.Location = new System.Drawing.Point(225, 102);
            this.MS_ngay_ghi_nhan.Name = "MS_ngay_ghi_nhan";
            this.MS_ngay_ghi_nhan.Size = new System.Drawing.Size(384, 22);
            this.MS_ngay_ghi_nhan.TabIndex = 3;
            this.MS_ngay_ghi_nhan.Validating += new System.ComponentModel.CancelEventHandler(this.MS_ngay_ghi_nhan_Validating);
            // 
            // MS_ten_doc_gia
            // 
            this.MS_ten_doc_gia.Location = new System.Drawing.Point(225, 160);
            this.MS_ten_doc_gia.Name = "MS_ten_doc_gia";
            this.MS_ten_doc_gia.Size = new System.Drawing.Size(384, 22);
            this.MS_ten_doc_gia.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ tên độc giả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tiền phạt:";
            // 
            // MS_tien_phat
            // 
            this.MS_tien_phat.Location = new System.Drawing.Point(225, 212);
            this.MS_tien_phat.Name = "MS_tien_phat";
            this.MS_tien_phat.Size = new System.Drawing.Size(384, 22);
            this.MS_tien_phat.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Người ghi nhận";
            // 
            // MS_nguoi_ghi_nhan
            // 
            this.MS_nguoi_ghi_nhan.Location = new System.Drawing.Point(225, 257);
            this.MS_nguoi_ghi_nhan.Name = "MS_nguoi_ghi_nhan";
            this.MS_nguoi_ghi_nhan.Size = new System.Drawing.Size(384, 22);
            this.MS_nguoi_ghi_nhan.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Xac_nhan_button
            // 
            this.Xac_nhan_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xac_nhan_button.Location = new System.Drawing.Point(340, 338);
            this.Xac_nhan_button.Name = "Xac_nhan_button";
            this.Xac_nhan_button.Size = new System.Drawing.Size(104, 43);
            this.Xac_nhan_button.TabIndex = 10;
            this.Xac_nhan_button.Text = "Xác nhận";
            this.Xac_nhan_button.UseVisualStyleBackColor = true;
            this.Xac_nhan_button.Click += new System.EventHandler(this.Xac_nhan_button_Click);
            // 
            // BM8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Xac_nhan_button);
            this.Controls.Add(this.MS_nguoi_ghi_nhan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MS_tien_phat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MS_ten_doc_gia);
            this.Controls.Add(this.MS_ngay_ghi_nhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MS_ten_sach);
            this.Controls.Add(this.label1);
            this.Name = "BM8";
            this.Text = "Ghi nhận mất sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BM8_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MS_ten_sach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MS_ngay_ghi_nhan;
        private System.Windows.Forms.TextBox MS_ten_doc_gia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MS_tien_phat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MS_nguoi_ghi_nhan;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Xac_nhan_button;
    }
}

