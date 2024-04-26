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
        public bool Login(String UserName, String Password)
        {
            var query = "EXEC USP_Login @UserName, @Password";
            var result = DataProvider.Instance.ExecuteQuery(query, new object[] { UserName, Password });
            return result.Rows.Count > 0;
        }

    }
}
