using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DTO
{
    public class DoanhThu
    {
        public int MaDoanhThu { get; set; }
        public int MaChiNhanh { get; set; }
        public DateTime NgayThang { get; set; }
        public DoanhThu() { }
        public DoanhThu(DataRow row) 
        {
            MaDoanhThu = (int)row["MADOANHTHU"];
            MaChiNhanh = (int)row["MACHINHANH"];
            NgayThang = (DateTime)row["NGAYTHANG"];
        }
    }
}
