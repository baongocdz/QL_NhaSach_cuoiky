using QL_NhaSach.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaSach
{
    public partial class frmLogin : Form
    {
        private readonly TaiKhoanBUS _taiKhoanBUS;
        public frmLogin()
        {
            InitializeComponent();
            _taiKhoanBUS = new TaiKhoanBUS();   
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!_taiKhoanBUS.Login(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
