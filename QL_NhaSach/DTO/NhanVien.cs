using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DTO
{
    public class NhanVien
    {
        public int MaNhanVien {  get; set; }    
        public int MaChiNhanh { get; set; }
        public string Ten {  get; set; }
        public int MaChucVu { get; set; }
        public int TongThoiGianLam {  get; set; }
        public DateTime NgayBatDau { get; set; } 

        public string Anh {  get; set; }
        public NhanVien() { }
        public NhanVien(DataRow row)
        {
            MaNhanVien = (int)row["MANHANVIEN"];
            MaChiNhanh = (int)row["MACHINHANH"];
            Ten = (string)row["TEN"];
            TongThoiGianLam = Convert.ToInt32(row["TONGTHOIGIANLAM"]);
            NgayBatDau = (DateTime)row["NGAYBATDAU"];
            MaChucVu = (int)row["MACHUCVU"];
            Anh = (string)row["ANH"];
        }
    }
   

}
