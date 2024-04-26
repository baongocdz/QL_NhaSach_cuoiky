using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DTO
{
    public  class LoaiTaiKhoan
    {
        public int MaLoai { get; set; }
        public string Loai { get; set; }
        public LoaiTaiKhoan() { }
        public LoaiTaiKhoan(DataRow row)
        {
            MaLoai = (int)row["MALOAI"];
            Loai = (string)row["LOAI"];
        }
    }
}
