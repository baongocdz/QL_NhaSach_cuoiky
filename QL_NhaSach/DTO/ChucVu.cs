using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DTO
{
    public class ChucVu
    {
        public int MaChucVu {  get; set; }
        public string TenChucVu { get; set; }
        public float LuongTheoGio { get; set; }
        public ChucVu() { }
        public ChucVu(DataRow row) 
        {
            MaChucVu = (int)row["MACHUCVU"];
            TenChucVu = (String)row["TENCHUCVU"];
            LuongTheoGio = (int)row["LUONGTHEOGIO"];
        }
    }
    

}
