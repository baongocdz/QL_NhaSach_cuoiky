using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DTO
{
    public class TaiKhoan
    {
        public int MaTaiKhoan { get; set; }
        public int MaLoai { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Ten {  get; set; }    
        public DateTime NgayTao { get; set; }
        public int MaChiNhanh { get; set; }
        public TaiKhoan() { }
        public TaiKhoan(DataRow row)
        {
            MaTaiKhoan = (int)row["MATAIKHOAN"];
            MaLoai = (int)row["MALOAI"];
            Username = (string)row["USERNAME"];
            Password = (String)row["PASSWORD"];
            NgayTao = (DateTime)row["NGAYTAO"];
            MaChiNhanh = (int)row["MACHINHANH"];
            Ten = (string)row["TEN"];
        }
    }
}
