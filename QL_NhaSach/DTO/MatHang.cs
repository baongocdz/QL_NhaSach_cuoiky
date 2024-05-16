using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DTO
{
    public class MatHang
    {
        public int MaMatHang { get; set; }
        public string TenMatHang { get; set; }
        public string TacGia { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public int MaChiNhanh { get; set; }
        public string NhaCungCap { get; set; }
        public MatHang() { }
        public MatHang(DataRow row)
        {
            MaMatHang = (int)row["MAMATHANG"];
            TenMatHang = (string)row["TENMATHANG"];
            TacGia = (String)row["TACGIA"];
            SoLuong = (int)row["SOLUONG"];
            DonGia = (int)row["DONGIA"];
            MaChiNhanh = (int)row["MACHINHANH"];
            NhaCungCap = (string)row["NHACUNGCAP"];
        }
        
    }
}
