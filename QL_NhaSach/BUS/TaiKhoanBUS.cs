using QL_NhaSach.DAL;
using QL_NhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaSach.BUS
{
    public class TaiKhoanBUS
    {
        private readonly TaiKhoanDAL _taiKhoanDAL = new TaiKhoanDAL();
        private readonly ChiNhanhBUS chiNhanhBUS = new ChiNhanhBUS();
        public TaiKhoanBUS()
        {
            _taiKhoanDAL = new TaiKhoanDAL();
        }
        public bool Login(String UserName, String Password)
        {
            if(String.IsNullOrEmpty(UserName) || String.IsNullOrEmpty(Password))
            {
                return false;
            }
            return _taiKhoanDAL.Login(UserName, Password);
        }
        public TaiKhoan GetTaiKhoanByUserName(String UserName)
        {
            if(String.IsNullOrEmpty(UserName))
            {
                return null;
            }
            var data = _taiKhoanDAL.GetTaiKhoanByUserName(UserName);
            if(data.Rows.Count > 0)
            {
                return new TaiKhoan((DataRow)data.Rows[0]);
            }
            return null;
        }
        public bool IsEmailValid(string email)
        {
            // Biểu thức chính quy để kiểm tra định dạng email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Kiểm tra chuỗi email có khớp với biểu thức chính quy không
            return Regex.IsMatch(email, pattern);
        }
        public bool CheckRegisWhenAlreadyHaveChiNhanh(string Username, string Password, string RePassword, int MaChiNhanh, string Email)
        {
            if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(RePassword)
                 && !string.IsNullOrEmpty(Email) && MaChiNhanh != null)
            {
                if (_taiKhoanDAL.Regis(Username))
                {
                    if (Password == RePassword)
                    {
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại");
                    return false;
                }
            }
            else MessageBox.Show("vui long nhap du.");
            return false;
        }
        public bool CheckRegisNewChiNhanh(string Username, string Password, string RePassword, string DiaChi, string TenChiNhanh, string Email)
        {
            if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(RePassword)
                && !string.IsNullOrEmpty(DiaChi) && !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(TenChiNhanh))
            {
                if (_taiKhoanDAL.Regis(Username))
                {
                    if (Password == RePassword)
                    {
                        if (chiNhanhBUS.CheckChiNhanh(TenChiNhanh))
                        {
                            return true;
                        }
                        else 
                        {
                            MessageBox.Show("Chi Nhánh Đã Tồn Tại.");
                            return false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Tài Khoản Đã Tồn Tại.");
                    return false;
                }
            }
            return false;
        }
        public bool AddChiNhanh(int ma, string ten, string diachi)
        {
            return _taiKhoanDAL.AddChiNhanh(ma, ten, diachi);
        }
        public bool AddTaiKhoan(string username, string password, int machinhanh, string email)
        {
            return _taiKhoanDAL.AddTaiKhoan(username, password, machinhanh, email);
        }
        public int AddMaChiNhanh() 
        {
            return _taiKhoanDAL.AddMaChiNhanh();
        }
    }
}
