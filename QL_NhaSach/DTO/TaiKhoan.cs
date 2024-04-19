using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DTO
{
    public class TaiKhoan
    {
        public int MATAIKHOAN { get; set; }
        public int MALOAI { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public DateTime NGAYTAO { get; set; }
        public int MACHINHANH { get; set; }
    }
}
