using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DTO
{
    public class NhapSach
    {
        public int MaNhap {  get; set; }
        public DateTime NgayNhap { get; set; }
        public int MaChiNhanh { get; set; }
        public int ThanhTien {  get; set; }
        public NhapSach() { }
        public NhapSach(DataRow row)
        {
            MaNhap = (int)row["MANHAP"];
            NgayNhap = (DateTime)row["NGAYNHAP"];
            MaChiNhanh = (int)row["MACHINHANH"];
            ThanhTien = (int)row["THANHTIEN"];
        }
    }
}
