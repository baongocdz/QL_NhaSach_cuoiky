using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DTO
{
    public class ChiTietHoaDon
    {
        //public int MaChiTietHoaDon { get; set; }
        public int MaHoaDon { get; set; }
        public int MaMatHang { get; set; }

        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public ChiTietHoaDon() { }
        public ChiTietHoaDon(DataRow row)
        {
            //MaChiTietHoaDon = (int)row["MACHITIETHOADON"];
            MaHoaDon = (int)row["MAHOADON"];
            MaMatHang = (int)row["MAMATHANG"];
            SoLuong = (int)row["SOLUONG"];
            DonGia = (int)row["DONGIA"];
        }
    }
}
