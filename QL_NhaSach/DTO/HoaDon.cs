using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DTO
{
    public class HoaDon
    {
        public int MaHoaDon { get; set; }
        public int MaNhanVien { get; set; }
        public DateTime Ngay { get; set; }
        public HoaDon() { }
        public HoaDon(DataRow row)
        {
            MaHoaDon = (int)row["MAHOADON"];
            MaNhanVien = (int)row["MANHANVIEN"];
            Ngay = (DateTime)row["NGAY"];
        }

    }
}
