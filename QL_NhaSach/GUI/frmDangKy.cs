using QL_NhaSach.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaSach.GUI
{
    public partial class frmDangKy : Form
    {
        private readonly ChiNhanhBUS _chinhanhBUS = new ChiNhanhBUS();
        private readonly TaiKhoanBUS _taiKhoanBUS = new TaiKhoanBUS();
        private readonly EmailBUS emailBUS = new EmailBUS();
        int MaChiNhanh;
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            dt = _chinhanhBUS.GetAllChiNhanh();
            cbxChiNhanh.DataSource = dt;
            cbxChiNhanh.DisplayMember = dt.Columns[1].ColumnName;
            cbxChiNhanh.ValueMember = dt.Columns[0].ColumnName;
            //txtEmail.Text = cbxChiNhanh.ValueMember;
            check();
            GetOTP();
        }

 

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Close();
        }
        private void check()
        {
            cbxChiNhanh.Visible = false;
            txtDiaChi.Visible = false;
            txtTen.Visible = false;
            lblChiNhanh.Visible= false;
            lblDiaChi.Visible = false;
            lblTen.Visible= false;
            if (rdoold.Checked)
            {
                cbxChiNhanh.Visible = true;
                lblChiNhanh.Visible = true;
            }
            else if(rdonew.Checked)
            {
                txtDiaChi.Visible = true;   
                txtTen.Visible = true;
                lblDiaChi.Visible = true;
                lblTen.Visible = true;
            }
        }

        private void cbxChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = cbxChiNhanh.SelectedItem as DataRowView;

            if (selectedRow != null)
            {
                string ma = selectedRow.Row[0].ToString();

                // Đặt địa chỉ email vào TextBox
                MaChiNhanh = int.Parse(ma);
            }
        }
        private void rdonew_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }

        private void rdoold_CheckedChanged(object sender, EventArgs e)
        {
            check();

        }

        private void btnOTP_Click(object sender, EventArgs e)
        {
            if (rdoold.Checked)
            {
                bool a = _taiKhoanBUS.CheckRegisWhenAlreadyHaveChiNhanh(txtTK.Text, txtMK.Text, txtReMK.Text, MaChiNhanh, txtEmail.Text);
                if (a)
                {
                    if (_taiKhoanBUS.IsEmailValid(txtEmail.Text))
                    {
                        emailBUS.SendEmail(txtEmail.Text, maotp);

                    }
                    else MessageBox.Show("Email Không Đúng Định Dạng.");
                }
            }
            else if (rdonew.Checked)
            {
                bool b = _taiKhoanBUS.CheckRegisNewChiNhanh(txtTK.Text, txtMK.Text, txtReMK.Text, txtDiaChi.Text, txtTen.Text, txtEmail.Text);
                if (b)
                {
                    if (_taiKhoanBUS.IsEmailValid(txtEmail.Text))
                    {
                        emailBUS.SendEmail(txtEmail.Text, maotp);

                    }
                    else MessageBox.Show("email không đúng định dạng.");
                }
            }
            else MessageBox.Show("chon vao thong tin chi nhanh");
        }
        private int maotp;

        public void GetOTP()
        {
            Random random = new Random();
            int number = random.Next(100000, 1000000); // Sinh số ngẫu nhiên từ 100000 đến 999999 (bao gồm)
            maotp = number; 
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(txtOTP.Text == maotp.ToString())
            {
                if(rdonew.Checked)
                {
                    _taiKhoanBUS.AddChiNhanh(_taiKhoanBUS.AddMaChiNhanh(), txtTen.Text, txtDiaChi.Text);
                    _taiKhoanBUS.AddTaiKhoan(txtTK.Text, txtMK.Text, _taiKhoanBUS.AddMaChiNhanh()-1, txtEmail.Text);
                    MessageBox.Show("tao tai khoan thanh cong.");
                    this.Hide();
                    frmDangKy frm = new frmDangKy();
                    frm.Show();
                }
                else if(rdoold.Checked) { }
                {
                    _taiKhoanBUS.AddTaiKhoan(txtTK.Text, txtMK.Text, MaChiNhanh, txtEmail.Text);
                    MessageBox.Show("tao tai khoan thanh cong.");
                    this.Hide();
                    frmDangKy frm = new frmDangKy();
                    frm.Show();
                }
            }
            else MessageBox.Show("Ma OTP khong chinh xac.");
        }
        //private void btnOTP_Click(object sender, EventArgs e)
        //{
        //    ma = random.Next(100000, 1000000);
        //    var fromAddress = new MailAddress("nguyentien.atp@gmai.com");
        //    var toAddress = new MailAddress(txtEmail.ToString());
        //    ControlStyles String frompass = "qqpq goxc qyul tyf";
        //    const String subject = "OTP code";
        //    String body = otp.ToString();
        //    var smtp = new SmtpClient
        //    {
        //        Host = "smtp.gmail.com";
        //        Port = 587,
        //        EnableSsl = true,
        //        DeliveryMethod = SmtpDeliveryMethod.Network,
        //        UseDefaultCredentials = false,
        //        Credentials = new NetworkCredential(fromAddress.Address, frompass),
        //        Timeout = 200000
        //    };
        //    using (var message = new MailMessage(fromAddress, toAddress))
        //    {
        //        Subject = subject,
        //        Body = body
        //    })           
        //}
    }
}
