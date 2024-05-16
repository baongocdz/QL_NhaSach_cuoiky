using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DAL
{
    public class TaiKhoanDAL
    {

        public TaiKhoanDAL() { }    
        public DataTable GetTaiKhoan()
        {
            var query = "select * from TAIKHOAN";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetTaiKhoanByUserName(String UserName)
        {
            var query = "exec USP_GetTKbyUserName @UserName";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { UserName });
        }
        public int GetMaChiNhanh()
        {
            var query = $"select MACHINHANH from TAIKHOAN where USERNAME = '{frmLogin.username}'";
            object result = DataProvider.Instance.ExecuteScalar(query);

            return Convert.ToInt32(result);
        }
        public bool Login(String UserName, String Password)
        {
            var query = $"select * from TAIKHOAN where LOWER(USERNAME) = LOWER('{UserName}') and PASSWORD = LOWER('{Password}')";
            var result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool Regis(String UserName)
        {
            var query = $"select * from TAIKHOAN where LOWER(USERNAME) = LOWER('{UserName}')";
            var result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count < 0;
        }

        //public bool regis(String UserName, String Password, String RePassword)
        //{
        //    var query
        //}

    }
}
