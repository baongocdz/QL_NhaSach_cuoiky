using QL_NhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DAL
{
    public class HoaDonDAL
    {
        public bool AddHoaDon(HoaDon hoaDon)
        {
            var query = $"insert into HOADON(MANHANVIEN, THANHTIEN) values({hoaDon.MaNhanVien}, {hoaDon.ThanhTien})";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool AddChiTietHoaDon(ChiTietHoaDon CThoadon) 
        {
            var query = $"insert into CHITIETHOADON(MACHITIETHOADON, MAHOADON, MAMATHANG, SOLUONG,DONGIA) values({GetMaHD()}, {GetMaHD()}, {CThoadon.MaMatHang}, {CThoadon.SoLuong}, {CThoadon.DonGia})";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int GetMaHD()
        {
            var query = "SELECT MAX(MAHOADON) AS MaxInvoiceID FROM HOADON";
            object result = DataProvider.Instance.ExecuteScalar(query);
            int maxInvoiceID = Convert.ToInt32(result);
            return maxInvoiceID;
        }
    }
}
