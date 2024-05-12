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
        public DataTable AddHoaDon(int id, int thanhtien)
        {
            var query = $"insert into HOADON(MANHANVIEN, THANHTIEN) values({id}, {thanhtien})";
            return DataProvider.Instance.ExecuteQuery(query) ;
        }
        public DataTable AddChiTietHoaDon(int idHD, int idMH, int SoLuong, int DonGia) 
        {
            var query = $"insert into CHITIETHOADON(MAHOADON, MAMATHANG, SOLUONG, DONGIA) values('{idHD}', '{idMH}', '{SoLuong}', '{DonGia}')";
            return DataProvider.Instance.ExecuteQuery (query) ;
        }
        public int GetMaHD()
        {
            var query = "SELECT MAX(MAHOADON) AS MaxInvoiceID FROM HOADON";
            object result = DataProvider.Instance.ExecuteQuery(query);
            int maxInvoiceID = Convert.ToInt32(result);
            return maxInvoiceID + 1;
        }
    }
}
