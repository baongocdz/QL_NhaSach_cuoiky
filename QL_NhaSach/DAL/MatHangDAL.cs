using QL_NhaSach.DTO;
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
        TaiKhoanDAL _taiKhoanDAL = new TaiKhoanDAL();
        public DataTable GetAllMatHang()
        {
            var query = $"select MAMATHANG, TENMATHANG, SOLUONG, DONGIA from MATHANG where MACHINHANH = '{_taiKhoanDAL.GetMaChiNhanh()}'";
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
        public bool AddMatHang(MatHang data)
        {
            var query = $"insert into MATHANG(MACHINHANH, TENMATHANG, SOLUONG, DONGIA, NHACUNGCAP) values({data.MaChiNhanh}, N'{data.TenMatHang}', {data.SoLuong}, {data.DonGia}, N'{data.NhaCungCap}')";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int GetMaMatHangMax()
        {
            var query = "select MAX(MAMATHANG) from MATHANG";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return Convert.ToInt32(result);
        }
    }
}
