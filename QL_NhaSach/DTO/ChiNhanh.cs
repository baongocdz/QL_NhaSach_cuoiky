using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DTO
{
    public class ChiNhanh
    {
        public int MachiNhanh {  get; set; }
        public int MaTaiKhoan { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }

        public ChiNhanh() { }

        public ChiNhanh(DataRow row)
        {
            MachiNhanh = (int)row["MACHINHANH"];
            MaTaiKhoan = (int)row["MATAIKHOAN"];
            Ten = row["TEN"].ToString();
            DiaChi = row["DIACHI"].ToString();
        }
    }
    
}
