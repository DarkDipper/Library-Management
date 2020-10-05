namespace BM2
{
    partial class TheDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheDocGia));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.f2NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.f2NgayLap = new System.Windows.Forms.DateTimePicker();
            this.f2Email = new System.Windows.Forms.TextBox();
            this.checkTen = new System.Windows.Forms.ErrorProvider(this.components);
            this.f2Type = new System.Windows.Forms.ComboBox();
            this.Tick = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkDiaChi = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkNguoilap = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkDocGia = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkNgaySinh = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.f2Address = new System.Windows.Forms.TextBox();
            this.f2Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkDN = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkMK = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonSign_up = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.checkTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkNguoilap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkNgaySinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkMK)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // f2NgaySinh
            // 
            resources.ApplyResources(this.f2NgaySinh, "f2NgaySinh");
            this.f2NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.f2NgaySinh.Name = "f2NgaySinh";
            this.f2NgaySinh.Value = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.f2NgaySinh.Leave += new System.EventHandler(this.f2NgaySinh_Leave);
            // 
            // f2NgayLap
            // 
            resources.ApplyResources(this.f2NgayLap, "f2NgayLap");
            this.f2NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.f2NgayLap.Name = "f2NgayLap";
            this.f2NgayLap.Value = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            // 
            // f2Email
            // 
            resources.ApplyResources(this.f2Email, "f2Email");
            this.f2Email.Name = "f2Email";
            this.f2Email.Leave += new System.EventHandler(this.f2Email_Leave);
            // 
            // checkTen
            // 
            this.checkTen.BlinkRate = 0;
            this.checkTen.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.checkTen.ContainerControl = this;
            // 
            // f2Type
            // 
            this.f2Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.f2Type, "f2Type");
            this.f2Type.FormattingEnabled = true;
            this.f2Type.Items.AddRange(new object[] {
            resources.GetString("f2Type.Items"),
            resources.GetString("f2Type.Items1")});
            this.f2Type.Name = "f2Type";
            this.f2Type.Leave += new System.EventHandler(this.f2Type_Leave);
            // 
            // Tick
            // 
            this.Tick.BlinkRate = 0;
            this.Tick.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Tick.ContainerControl = this;
            resources.ApplyResources(this.Tick, "Tick");
            // 
            // checkDiaChi
            // 
            this.checkDiaChi.BlinkRate = 0;
            this.checkDiaChi.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.checkDiaChi.ContainerControl = this;
            // 
            // checkNguoilap
            // 
            this.checkNguoilap.BlinkRate = 0;
            this.checkNguoilap.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.checkNguoilap.ContainerControl = this;
            // 
            // checkDocGia
            // 
            this.checkDocGia.BlinkRate = 0;
            this.checkDocGia.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.checkDocGia.ContainerControl = this;
            // 
            // checkEmail
            // 
            this.checkEmail.BlinkRate = 0;
            this.checkEmail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.checkEmail.ContainerControl = this;
            // 
            // checkNgaySinh
            // 
            this.checkNgaySinh.BlinkRate = 0;
            this.checkNgaySinh.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.checkNgaySinh.ContainerControl = this;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // f2Address
            // 
            resources.ApplyResources(this.f2Address, "f2Address");
            this.f2Address.Name = "f2Address";
            this.f2Address.Leave += new System.EventHandler(this.f2Address_Leave_1);
            // 
            // f2Name
            // 
            resources.ApplyResources(this.f2Name, "f2Name");
            this.f2Name.Name = "f2Name";
            this.f2Name.Leave += new System.EventHandler(this.f2Name_Leave_1);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // checkDN
            // 
            this.checkDN.BlinkRate = 0;
            this.checkDN.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.checkDN.ContainerControl = this;
            // 
            // checkMK
            // 
            this.checkMK.BlinkRate = 0;
            this.checkMK.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.checkMK.ContainerControl = this;
            // 
            // buttonSign_up
            // 
            resources.ApplyResources(this.buttonSign_up, "buttonSign_up");
            this.buttonSign_up.Name = "buttonSign_up";
            this.buttonSign_up.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // TheDocGia
            // 
            this.AcceptButton = this.buttonSign_up;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSign_up);
            this.Controls.Add(this.f2Address);
            this.Controls.Add(this.f2Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.f2Type);
            this.Controls.Add(this.f2Email);
            this.Controls.Add(this.f2NgayLap);
            this.Controls.Add(this.f2NgaySinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TheDocGia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TheDocGia_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDiaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkNguoilap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkNgaySinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkMK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker f2NgaySinh;
        private System.Windows.Forms.DateTimePicker f2NgayLap;
        private System.Windows.Forms.TextBox f2Email;
        private System.Windows.Forms.ErrorProvider checkTen;
        private System.Windows.Forms.ComboBox f2Type;
        private System.Windows.Forms.ErrorProvider Tick;
        private System.Windows.Forms.ErrorProvider checkDiaChi;
        private System.Windows.Forms.ErrorProvider checkNguoilap;
        private System.Windows.Forms.ErrorProvider checkDocGia;
        private System.Windows.Forms.ErrorProvider checkEmail;
        private System.Windows.Forms.ErrorProvider checkNgaySinh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox f2Address;
        private System.Windows.Forms.TextBox f2Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider checkDN;
        private System.Windows.Forms.ErrorProvider checkMK;
        private System.Windows.Forms.Button buttonSign_up;
        private System.Windows.Forms.Button buttonExit;
    }
}

