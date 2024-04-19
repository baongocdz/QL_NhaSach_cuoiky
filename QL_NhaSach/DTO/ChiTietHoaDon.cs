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
        public int MACHITIETHOADON { get; set; }
        public int MAHOADON { get; set; }
        public int MAMATHANG { get; set; }

        public int SOLUONG { get; set; }
        public float THANHTIEN { get; set; }
        public ChiTietHoaDon() { }
        public ChiTietHoaDon(DataRow row)
        {
            MACHITIETHOADON = (int)row["MACHITIETHOADON"];
            MAHOADON = (int)row["MAHOADON"];
            MAMATHANG = (int)row["MAMATHANG"];
            //SOLUONG = 
        }
    }
}
