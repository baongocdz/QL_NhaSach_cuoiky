using QL_NhaSach.DAL;
using QL_NhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaSach.BUS
{
    public class TaiKhoanBUS
    {
        private readonly TaiKhoanDAL _taiKhoanDAL;
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
            return true;
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
    }
}
