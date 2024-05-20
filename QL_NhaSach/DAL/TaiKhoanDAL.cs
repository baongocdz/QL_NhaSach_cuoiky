using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            return result.Rows.Count == 0;
        }
        public bool AddChiNhanh(int ma, string ten, string diachi)
        {
            var query = $"insert into CHINHANH(MACHINHANH, TEN, DIACHI) values({ma}, '{ten}', '{diachi}')";
            var result = DataProvider.Instance.ExecuteNonQuery(query)
;           return result > 0;
        }

        public bool AddTaiKhoan(string username, string password, int machinhanh, string email)
        {
            var query = $"insert into TAIKHOAN(USERNAME, PASSWORD, MACHINHANH, EMAIL) values(N'{username}', N'{password}', {machinhanh}, N'{email}')";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int AddMaChiNhanh()
        {
            var query = "select max(MACHINHANH) from CHINHANH";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return Convert.ToInt32(result) + 1;
        }
    }
}
