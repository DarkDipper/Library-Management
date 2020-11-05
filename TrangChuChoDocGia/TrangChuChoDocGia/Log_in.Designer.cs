namespace Trang_Chu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_in));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.User_name = new System.Windows.Forms.TextBox();
            this.Pass_word = new System.Windows.Forms.TextBox();
            this.Dang_nhap_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(9, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(9, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu:";
            // 
            // User_name
            // 
            this.User_name.Location = new System.Drawing.Point(9, 164);
            this.User_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.User_name.Name = "User_name";
            this.User_name.Size = new System.Drawing.Size(187, 20);
            this.User_name.TabIndex = 1;
            // 
            // Pass_word
            // 
            this.Pass_word.Location = new System.Drawing.Point(9, 228);
            this.Pass_word.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pass_word.Name = "Pass_word";
            this.Pass_word.Size = new System.Drawing.Size(187, 20);
            this.Pass_word.TabIndex = 3;
            this.Pass_word.UseSystemPasswordChar = true;
            // 
            // Dang_nhap_button
            // 
            this.Dang_nhap_button.AutoSize = true;
            this.Dang_nhap_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Dang_nhap_button.FlatAppearance.BorderSize = 0;
            this.Dang_nhap_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dang_nhap_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dang_nhap_button.Location = new System.Drawing.Point(14, 285);
            this.Dang_nhap_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dang_nhap_button.Name = "Dang_nhap_button";
            this.Dang_nhap_button.Size = new System.Drawing.Size(84, 29);
            this.Dang_nhap_button.TabIndex = 4;
            this.Dang_nhap_button.Text = "Đăng nhập";
            this.Dang_nhap_button.UseVisualStyleBackColor = false;
            this.Dang_nhap_button.Click += new System.EventHandler(this.Dang_nhap_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Trang_Chu.Properties.Resources.b50d19ef_edc8_4703_8fdd_274e9a06f4a3_200x200;
            this.pictureBox1.Location = new System.Drawing.Point(14, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.MediumBlue;
            this.linkLabel1.Location = new System.Drawing.Point(104, 253);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(105, 17);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên mật khẩu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Log_in
            // 
            this.AcceptButton = this.Dang_nhap_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trang_Chu.Properties.Resources.pexels_element_digital_1470162;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(499, 383);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Dang_nhap_button);
            this.Controls.Add(this.Pass_word);
            this.Controls.Add(this.User_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Log_in";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox User_name;
        private System.Windows.Forms.TextBox Pass_word;
        private System.Windows.Forms.Button Dang_nhap_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

