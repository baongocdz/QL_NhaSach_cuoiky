using QL_NhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QL_NhaSach.DAL
{
    public class ProductDAL
    {
        TaiKhoanDAL _taiKhoanDAL = new TaiKhoanDAL();
        public DataTable GetAllProducts()
        {
            var query = $"SELECT * FROM [QL_NhaSach].[dbo].[MATHANG] where MACHINHANH = {_taiKhoanDAL.GetMaChiNhanh()} ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchProducts(string keyword)
        {
            string query = "SELECT * FROM [QL_NhaSach].[dbo].[MATHANG] WHERE TENMATHANG LIKE @Keyword";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { "%" + keyword + "%" });
        }

        public bool DeleteProduct(int maMatHang)
        {
            var query = $"DELETE FROM [QL_NhaSach].[dbo].[MATHANG] WHERE MAMATHANG = {maMatHang}";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateProduct (Product data)
        {
            var query = $"UPDATE [QL_NhaSach].[dbo].[MATHANG] SET MACHINHANH = {data.MACHINHANH}, TENMATHANG = N'{data.TENMATHANG}', " +
                        $"SOLUONG = {data.SOLUONG}, DONGIA = {data.DONGIA}, NHACUNGCAP = N'{data.NHACUNGCAP}'" +
                        $"WHERE MAMATHANG = {data.MAMATHANG}";

            var result = DataProvider.Instance.ExecuteNonQuery(query);  
            return result > 0;
        }



    }
}
