﻿namespace Trang_Chu
{
    partial class Log_in
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.User_name = new System.Windows.Forms.TextBox();
            this.Pass_word = new System.Windows.Forms.TextBox();
            this.List = new System.Windows.Forms.ComboBox();
            this.Dang_nhap_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu:";
            // 
            // User_name
            // 
            this.User_name.Location = new System.Drawing.Point(212, 78);
            this.User_name.Name = "User_name";
            this.User_name.Size = new System.Drawing.Size(265, 22);
            this.User_name.TabIndex = 3;
            // 
            // Pass_word
            // 
            this.Pass_word.Location = new System.Drawing.Point(212, 140);
            this.Pass_word.Name = "Pass_word";
            this.Pass_word.Size = new System.Drawing.Size(265, 22);
            this.Pass_word.TabIndex = 4;
            // 
            // List
            // 
            this.List.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List.FormattingEnabled = true;
            this.List.Items.AddRange(new object[] {
            "Độc giả",
            "Thủ quỹ",
            "Thủ thư",
            "Thủ kho",
            "Thủ trưởng"});
            this.List.Location = new System.Drawing.Point(212, 204);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(265, 27);
            this.List.TabIndex = 5;
            // 
            // Dang_nhap_button
            // 
            this.Dang_nhap_button.AutoSize = true;
            this.Dang_nhap_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dang_nhap_button.Location = new System.Drawing.Point(212, 267);
            this.Dang_nhap_button.Name = "Dang_nhap_button";
            this.Dang_nhap_button.Size = new System.Drawing.Size(103, 32);
            this.Dang_nhap_button.TabIndex = 6;
            this.Dang_nhap_button.Text = "Đăng nhập";
            this.Dang_nhap_button.UseVisualStyleBackColor = true;
            // 
            // Log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 393);
            this.Controls.Add(this.Dang_nhap_button);
            this.Controls.Add(this.List);
            this.Controls.Add(this.Pass_word);
            this.Controls.Add(this.User_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Log_in";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox User_name;
        private System.Windows.Forms.TextBox Pass_word;
        private System.Windows.Forms.ComboBox List;
        private System.Windows.Forms.Button Dang_nhap_button;
    }
}

