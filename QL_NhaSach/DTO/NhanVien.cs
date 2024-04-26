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
        public String Ten {  get; set; }
        public int MaChucVu { get; set; }
        public float TongThoiGianLam {  get; set; }
        public DateTime NgayBatDau { get; set; } 
        public NhanVien() { }
        public NhanVien(DataRow row)
        {
            MaNhanVien = (int)row["MANHANVIEN"];
            MaChiNhanh = (int)row["MACHINHANH"];
            Ten = (String)row["TEN"];
            TongThoiGianLam = (float)row["TONGTHOIGIANLAM"];
            NgayBatDau = (DateTime)row["NGAYBATDAU"];
            MaChucVu = (int)row["MACHUCVU"];
        }
    }
   

}
