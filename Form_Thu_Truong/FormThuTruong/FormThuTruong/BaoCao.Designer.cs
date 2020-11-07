namespace FormThuTruong
{
    partial class BaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ngaythangnamphat = new System.Windows.Forms.Label();
            this.tonglm = new System.Windows.Forms.Label();
            this.llll = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.xh = new System.Windows.Forms.Label();
            this.kh = new System.Windows.Forms.Label();
            this.tt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.circularProgressBar3 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar2 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tongphat = new System.Windows.Forms.Label();
            this.listViewNo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tonglm);
            this.groupBox1.Controls.Add(this.llll);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.xh);
            this.groupBox1.Controls.Add(this.kh);
            this.groupBox1.Controls.Add(this.tt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.circularProgressBar3);
            this.groupBox1.Controls.Add(this.circularProgressBar2);
            this.groupBox1.Controls.Add(this.circularProgressBar1);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 569);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê tình hình mượn sách theo thể loại";
            // 
            // ngaythangnamphat
            // 
            this.ngaythangnamphat.AutoSize = true;
            this.ngaythangnamphat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaythangnamphat.ForeColor = System.Drawing.Color.Black;
            this.ngaythangnamphat.Location = new System.Drawing.Point(549, 26);
            this.ngaythangnamphat.Name = "ngaythangnamphat";
            this.ngaythangnamphat.Size = new System.Drawing.Size(79, 20);
            this.ngaythangnamphat.TabIndex = 16;
            this.ngaythangnamphat.Text = "??/??/??";
            // 
            // tonglm
            // 
            this.tonglm.AutoSize = true;
            this.tonglm.ForeColor = System.Drawing.Color.Black;
            this.tonglm.Location = new System.Drawing.Point(168, 60);
            this.tonglm.Name = "tonglm";
            this.tonglm.Size = new System.Drawing.Size(18, 22);
            this.tonglm.TabIndex = 13;
            this.tonglm.Text = "0";
            // 
            // llll
            // 
            this.llll.AutoSize = true;
            this.llll.ForeColor = System.Drawing.Color.DimGray;
            this.llll.Location = new System.Drawing.Point(21, 60);
            this.llll.Name = "llll";
            this.llll.Size = new System.Drawing.Size(141, 22);
            this.llll.TabIndex = 12;
            this.llll.Text = "Tổng lượt mượn :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(148, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(88, 29);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // xh
            // 
            this.xh.AutoSize = true;
            this.xh.ForeColor = System.Drawing.Color.Black;
            this.xh.Location = new System.Drawing.Point(200, 512);
            this.xh.Name = "xh";
            this.xh.Size = new System.Drawing.Size(18, 22);
            this.xh.TabIndex = 9;
            this.xh.Text = "0";
            // 
            // kh
            // 
            this.kh.AutoSize = true;
            this.kh.ForeColor = System.Drawing.Color.Black;
            this.kh.Location = new System.Drawing.Point(200, 355);
            this.kh.Name = "kh";
            this.kh.Size = new System.Drawing.Size(18, 22);
            this.kh.TabIndex = 8;
            this.kh.Text = "0";
            // 
            // tt
            // 
            this.tt.AutoSize = true;
            this.tt.ForeColor = System.Drawing.Color.Black;
            this.tt.Location = new System.Drawing.Point(200, 191);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(18, 22);
            this.tt.TabIndex = 7;
            this.tt.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượt mượn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượt mượn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượt mượn :";
            // 
            // circularProgressBar3
            // 
            this.circularProgressBar3.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar3.AnimationSpeed = 500;
            this.circularProgressBar3.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar3.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar3.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar3.InnerMargin = 2;
            this.circularProgressBar3.InnerWidth = -1;
            this.circularProgressBar3.Location = new System.Drawing.Point(23, 414);
            this.circularProgressBar3.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar3.Name = "circularProgressBar3";
            this.circularProgressBar3.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar3.OuterMargin = -25;
            this.circularProgressBar3.OuterWidth = 26;
            this.circularProgressBar3.ProgressColor = System.Drawing.Color.Gold;
            this.circularProgressBar3.ProgressWidth = 25;
            this.circularProgressBar3.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar3.Size = new System.Drawing.Size(156, 149);
            this.circularProgressBar3.StartAngle = 270;
            this.circularProgressBar3.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar3.SubscriptMargin = new System.Windows.Forms.Padding(1, -35, 0, 0);
            this.circularProgressBar3.SubscriptText = " 0 %";
            this.circularProgressBar3.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar3.SuperscriptMargin = new System.Windows.Forms.Padding(0, -15, 0, 0);
            this.circularProgressBar3.SuperscriptText = "";
            this.circularProgressBar3.TabIndex = 3;
            this.circularProgressBar3.Text = "Xã hội";
            this.circularProgressBar3.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar3.Value = 68;
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar2.AnimationSpeed = 500;
            this.circularProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar2.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar2.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar2.InnerMargin = 2;
            this.circularProgressBar2.InnerWidth = -1;
            this.circularProgressBar2.Location = new System.Drawing.Point(23, 259);
            this.circularProgressBar2.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar2.OuterMargin = -25;
            this.circularProgressBar2.OuterWidth = 26;
            this.circularProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.circularProgressBar2.ProgressWidth = 25;
            this.circularProgressBar2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar2.Size = new System.Drawing.Size(156, 149);
            this.circularProgressBar2.StartAngle = 270;
            this.circularProgressBar2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar2.SubscriptMargin = new System.Windows.Forms.Padding(-4, -35, -2, 0);
            this.circularProgressBar2.SubscriptText = "0 %";
            this.circularProgressBar2.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar2.SuperscriptMargin = new System.Windows.Forms.Padding(0, -15, 0, 0);
            this.circularProgressBar2.SuperscriptText = "";
            this.circularProgressBar2.TabIndex = 2;
            this.circularProgressBar2.Text = "Khoa học";
            this.circularProgressBar2.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar2.Value = 68;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(23, 104);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.Size = new System.Drawing.Size(156, 149);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(-18, -38, 0, 0);
            this.circularProgressBar1.SubscriptText = "0 %";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(0, -15, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 1;
            this.circularProgressBar1.Text = "Tiểu thuyết";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tongphat);
            this.groupBox2.Controls.Add(this.listViewNo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(379, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê độc giả nợ tiền phạt";
            // 
            // tongphat
            // 
            this.tongphat.AutoSize = true;
            this.tongphat.ForeColor = System.Drawing.Color.Black;
            this.tongphat.Location = new System.Drawing.Point(137, 195);
            this.tongphat.Name = "tongphat";
            this.tongphat.Size = new System.Drawing.Size(18, 22);
            this.tongphat.TabIndex = 15;
            this.tongphat.Text = "0";
            // 
            // listViewNo
            // 
            this.listViewNo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewNo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewNo.FullRowSelect = true;
            this.listViewNo.GridLines = true;
            this.listViewNo.HideSelection = false;
            this.listViewNo.Location = new System.Drawing.Point(22, 29);
            this.listViewNo.Name = "listViewNo";
            this.listViewNo.Size = new System.Drawing.Size(387, 163);
            this.listViewNo.TabIndex = 0;
            this.listViewNo.UseCompatibleStateImageBehavior = false;
            this.listViewNo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên độc giả";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 238;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tiền nợ";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(18, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tổng tiền nợ :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox3.Location = new System.Drawing.Point(379, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 309);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thống kê sách chưa trả";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(387, 271);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "STT";
            this.columnHeader4.Width = 41;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên sách";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày mượn";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số ngày mượn";
            this.columnHeader7.Width = 110;
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.ngaythangnamphat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BaoCao";
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.BaoCao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label xh;
        private System.Windows.Forms.Label kh;
        private System.Windows.Forms.Label tt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CircularProgressBar.CircularProgressBar circularProgressBar3;
        private CircularProgressBar.CircularProgressBar circularProgressBar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label llll;
        private System.Windows.Forms.Label tonglm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ngaythangnamphat;
        private System.Windows.Forms.Label tongphat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listViewNo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}