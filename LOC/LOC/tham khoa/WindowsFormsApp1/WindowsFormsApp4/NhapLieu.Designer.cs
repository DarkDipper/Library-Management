namespace WindowsFormsApp4
{
    partial class NhapLieu
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
            this.text_dong = new System.Windows.Forms.TextBox();
            this.button_khoitao = new System.Windows.Forms.Button();
            this.text_cot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số dòng";
            // 
            // text_dong
            // 
            this.text_dong.Location = new System.Drawing.Point(66, 24);
            this.text_dong.Name = "text_dong";
            this.text_dong.Size = new System.Drawing.Size(107, 20);
            this.text_dong.TabIndex = 1;
            // 
            // button_khoitao
            // 
            this.button_khoitao.Location = new System.Drawing.Point(179, 16);
            this.button_khoitao.Name = "button_khoitao";
            this.button_khoitao.Size = new System.Drawing.Size(103, 55);
            this.button_khoitao.TabIndex = 2;
            this.button_khoitao.Text = "Khởi tạo form";
            this.button_khoitao.UseVisualStyleBackColor = true;
            this.button_khoitao.Click += new System.EventHandler(this.button_khoitao_Click);
            // 
            // text_cot
            // 
            this.text_cot.Location = new System.Drawing.Point(66, 51);
            this.text_cot.Name = "text_cot";
            this.text_cot.Size = new System.Drawing.Size(107, 20);
            this.text_cot.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số cột";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 83);
            this.Controls.Add(this.text_cot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_khoitao);
            this.Controls.Add(this.text_dong);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "                                Nhập liệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_dong;
        private System.Windows.Forms.Button button_khoitao;
        private System.Windows.Forms.TextBox text_cot;
        private System.Windows.Forms.Label label2;
    }
}

