namespace QL_NhaSach.GUI
{
    partial class frmDangKy
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
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReMK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.otp = new System.Windows.Forms.Label();
            this.btnOTP = new System.Windows.Forms.Button();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.lblChiNhanh = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxChiNhanh = new System.Windows.Forms.ComboBox();
            this.rdonew = new System.Windows.Forms.RadioButton();
            this.rdoold = new System.Windows.Forms.RadioButton();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "tài khoản";
            this.label1.UseWaitCursor = true;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(259, 56);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(296, 22);
            this.txtTK.TabIndex = 1;
            this.txtTK.UseWaitCursor = true;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(313, 347);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(136, 59);
            this.btnDangKy.TabIndex = 2;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.UseWaitCursor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(259, 84);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(296, 22);
            this.txtMK.TabIndex = 4;
            this.txtMK.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu";
            this.label2.UseWaitCursor = true;
            // 
            // txtReMK
            // 
            this.txtReMK.Location = new System.Drawing.Point(259, 112);
            this.txtReMK.Name = "txtReMK";
            this.txtReMK.Size = new System.Drawing.Size(296, 22);
            this.txtReMK.TabIndex = 6;
            this.txtReMK.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập Lại Mật Khẩu";
            this.label3.UseWaitCursor = true;
            // 
            // btndangnhap
            // 
            this.btndangnhap.Location = new System.Drawing.Point(692, 400);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(96, 38);
            this.btndangnhap.TabIndex = 8;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.UseWaitCursor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // otp
            // 
            this.otp.AutoSize = true;
            this.otp.Location = new System.Drawing.Point(134, 145);
            this.otp.Name = "otp";
            this.otp.Size = new System.Drawing.Size(26, 16);
            this.otp.TabIndex = 9;
            this.otp.Text = "otp";
            this.otp.UseWaitCursor = true;
            // 
            // btnOTP
            // 
            this.btnOTP.Location = new System.Drawing.Point(478, 140);
            this.btnOTP.Name = "btnOTP";
            this.btnOTP.Size = new System.Drawing.Size(87, 33);
            this.btnOTP.TabIndex = 12;
            this.btnOTP.Text = "Lấy Mã";
            this.btnOTP.UseVisualStyleBackColor = true;
            this.btnOTP.UseWaitCursor = true;
            this.btnOTP.Click += new System.EventHandler(this.btnOTP_Click);
            // 
            // txtOTP
            // 
            this.txtOTP.Location = new System.Drawing.Point(259, 142);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(205, 22);
            this.txtOTP.TabIndex = 13;
            this.txtOTP.UseWaitCursor = true;
            // 
            // lblChiNhanh
            // 
            this.lblChiNhanh.AutoSize = true;
            this.lblChiNhanh.Location = new System.Drawing.Point(174, 246);
            this.lblChiNhanh.Name = "lblChiNhanh";
            this.lblChiNhanh.Size = new System.Drawing.Size(68, 16);
            this.lblChiNhanh.TabIndex = 15;
            this.lblChiNhanh.Text = "Chi Nhánh";
            this.lblChiNhanh.UseWaitCursor = true;
            this.lblChiNhanh.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(259, 28);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(296, 22);
            this.txtEmail.TabIndex = 17;
            this.txtEmail.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Email";
            this.label5.UseWaitCursor = true;
            // 
            // cbxChiNhanh
            // 
            this.cbxChiNhanh.FormattingEnabled = true;
            this.cbxChiNhanh.Location = new System.Drawing.Point(256, 243);
            this.cbxChiNhanh.Name = "cbxChiNhanh";
            this.cbxChiNhanh.Size = new System.Drawing.Size(208, 24);
            this.cbxChiNhanh.TabIndex = 14;
            this.cbxChiNhanh.UseWaitCursor = true;
            this.cbxChiNhanh.Visible = false;
            this.cbxChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbxChiNhanh_SelectedIndexChanged);
            // 
            // rdonew
            // 
            this.rdonew.AutoSize = true;
            this.rdonew.Location = new System.Drawing.Point(157, 21);
            this.rdonew.Name = "rdonew";
            this.rdonew.Size = new System.Drawing.Size(114, 20);
            this.rdonew.TabIndex = 26;
            this.rdonew.TabStop = true;
            this.rdonew.Text = "Chi Nhánh Mới";
            this.rdonew.UseVisualStyleBackColor = true;
            this.rdonew.UseWaitCursor = true;
            this.rdonew.CheckedChanged += new System.EventHandler(this.rdoold_CheckedChanged);
            // 
            // rdoold
            // 
            this.rdoold.AutoSize = true;
            this.rdoold.Location = new System.Drawing.Point(6, 21);
            this.rdoold.Name = "rdoold";
            this.rdoold.Size = new System.Drawing.Size(129, 20);
            this.rdoold.TabIndex = 25;
            this.rdoold.TabStop = true;
            this.rdoold.Text = "Đã Có Chi Nhánh";
            this.rdoold.UseVisualStyleBackColor = true;
            this.rdoold.UseWaitCursor = true;
            this.rdoold.CheckedChanged += new System.EventHandler(this.rdonew_CheckedChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(256, 245);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(208, 22);
            this.txtDiaChi.TabIndex = 24;
            this.txtDiaChi.UseWaitCursor = true;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(174, 245);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(49, 16);
            this.lblDiaChi.TabIndex = 23;
            this.lblDiaChi.Text = "Địa Chỉ";
            this.lblDiaChi.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoold);
            this.groupBox1.Controls.Add(this.rdonew);
            this.groupBox1.Location = new System.Drawing.Point(259, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 58);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn ";
            this.groupBox1.UseWaitCursor = true;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(256, 273);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(208, 22);
            this.txtTen.TabIndex = 29;
            this.txtTen.UseWaitCursor = true;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(174, 276);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(31, 16);
            this.lblTen.TabIndex = 28;
            this.lblTen.Text = "Tên";
            this.lblTen.UseWaitCursor = true;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 455);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblChiNhanh);
            this.Controls.Add(this.cbxChiNhanh);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.btnOTP);
            this.Controls.Add(this.otp);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.txtReMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label1);
            this.Name = "frmDangKy";
            this.Text = "frmDangKi";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Label otp;
        private System.Windows.Forms.Button btnOTP;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Label lblChiNhanh;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxChiNhanh;
        private System.Windows.Forms.RadioButton rdonew;
        private System.Windows.Forms.RadioButton rdoold;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblTen;
    }
}