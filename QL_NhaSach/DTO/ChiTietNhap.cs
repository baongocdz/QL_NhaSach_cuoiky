using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DTO
{
    public class ChiTietNhap
    {
        public int MaChiTietNhap { get; set; }
        public int MaNhap { get; set; }
        public string TenMatHang { get; set; }
        public string NhaCungCap { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }

        public ChiTietNhap() { }
        public ChiTietNhap(DataRow row) 
        {
            MaChiTietNhap = (int)row["MACHITIETNHAP"];
            MaNhap = (int)row["MANHAP"];
            TenMatHang = (string)row["TENMATHANG"];
            NhaCungCap = (string)row["NHACUNGCAP"];
            DonGia = (int)row["DONGIA"];
            SoLuong = (int)row["SOLUONG"];

        }

    }
}
