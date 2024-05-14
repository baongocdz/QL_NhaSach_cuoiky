using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DAL
{
    public class MatHangDAL
    {
        public DataTable GetAllMatHang()
        {
            var query = "select MAMATHANG, TENMATHANG, SOLUONG, DONGIA from MATHANG";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetMatHangByTen(String Ten)
        {
            var query = $"exec USP_Search @Ten";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { Ten });
        }
        public DataTable GetMatHangByMa(int Ma)
        {
            var query = $"select MAMATHANG, TENMATHANG, SOLUONG, DONGIA from MATHANG where MAMATHANG = '{Ma}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetCotMatHang()
        {
            var query = $"select MAMATHANG, TENMATHANG, SOLUONG, DONGIA from MATHANG where 1 = 0";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool DecreaseSoLuong(int maMH, int SoLuong)
        {
            var query = $"update MATHANG set SOLUONG = SOLUONG - {SoLuong} where MAMATHANG = {maMH}";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
