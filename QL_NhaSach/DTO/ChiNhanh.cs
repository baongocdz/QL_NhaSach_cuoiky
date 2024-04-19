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
        public int MACHINHANH {  get; set; }
        public int MATAIKHOAN { get; set; }
        public string TEN { get; set; }
        public string DIACHI { get; set; }
        public int MAKHO { get; set; }
        public ChiNhanh() { }

        public ChiNhanh(DataRow row)
        {
            MACHINHANH = (int)row["MACHINHANH"];
            MATAIKHOAN = (int)row["MATAIKHOAN"];
            TEN = row["TEN"].ToString();
            DIACHI = row["DIACHI"].ToString();
            MAKHO = (int)row["MAKHO"];
        }
    }
    
}
