using QL_NhaSach.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DAL
{
    public class NhanVienDAL
    {
        TaiKhoanDAL _taiKhoanDAL = new TaiKhoanDAL();
        public DataTable GetNhanVienByChiNhanh(string username)
        {
            var query = $"select MANHANVIEN, t.MACHINHANH, MACHUCVU, n.TEN, TONGTHOIGIANLAM, NGAYBATDAU from NHANVIEN n, TAIKHOAN t where T.USERNAME = '{username}' and t.MACHINHANH = n.MACHINHANH";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable LayTatCaNhanVien()
        {
            var query = $"SELECT * FROM [QL_NhaSach].[dbo].[NHANVIEN] where MACHINHANH = {_taiKhoanDAL.GetMaChiNhanh()} ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable TimKiemNhanVien(string keyword)
        {
            string query = "SELECT * FROM [QL_NhaSach].[dbo].[NHANVIEN] WHERE TEN LIKE @Keyword";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { "%" + keyword + "%" });
        }

        public bool XoaNhanVien(int maNhanVien)
        {
            var query = $"DELETE FROM [QL_NhaSach].[dbo].[NHANVIEN] WHERE MANHANVIEN = {maNhanVien}";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool ThemNhanVien(NhanVien data)
        {
            var query = $"INSERT INTO [QL_NhaSach].[dbo].[NHANVIEN] (MACHINHANH, MACHUCVU, TEN, TONGTHOIGIANLAM, NGAYBATDAU) " +
                        $"VALUES ({data.MACHINHANH}, {data.MACHUCVU}, N'{data.TEN}', {data.TONGTHOIGIANLAM}, '{data.NGAYBATDAU.ToString("yyyy-MM-dd")}')";

            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
