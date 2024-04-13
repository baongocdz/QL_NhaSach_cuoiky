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
        private string[] usernames = { "Phú Lương", "Bảo Ngọc", "Thảo Ngân" };
        private string[] passwords = { "1234", "2444", "1334" };
        private int loginAttempts = 0;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            //con.Open();
            //cmd = new SqlCommand($"DECLARE @A INT = 1; SELECT MASANPHAM, LoaiSanPham,TenSanPham, TacGia,SoLuongCon,DonGia, @A AS SOLUONGMUA FROM dbo.LAY_THONG_TIN_SAN_PHAM({a})", con);
            //adt = new SqlDataAdapter(cmd);
            //adt.Fill(dt);
            
            //con.Close();

            bool isValid = CheckCredentials(enteredUsername, enteredPassword);

            if (isValid)
            {
                MessageBox.Show("Bạn đã đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            else
            {
                loginAttempts++;
                if (loginAttempts >= 3)
                {
                    MessageBox.Show("Bạn đã nhập sai quá 3 lần. Chương trình sẽ thoát.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool CheckCredentials(string username, string password)
        {
            bool isAuthenticated = false;
            string connectionstring = @"Data Source=NGOCDZ\SQLEXPRESS02;
                                    Initial Catalog=QL_NhaSach;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM TAIKHOAN WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            isAuthenticated = true; 
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return isAuthenticated;
        }

        private void btnRetry_Click_1(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            loginAttempts = 0;
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
