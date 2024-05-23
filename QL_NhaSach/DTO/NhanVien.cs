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
        public int MANHANVIEN { get; set; }
        public int MACHINHANH { get; set; }
        public int MACHUCVU { get; set; }
        public string TEN { get; set; }
        public int TONGTHOIGIANLAM { get; set; }
        public DateTime NGAYBATDAU { get; set; }

        public NhanVien(DataRow row)
        {
            MANHANVIEN = (int)row["MANHANVIEN"];
            MACHINHANH = (int)row["MACHINHANH"];
            MACHUCVU = (int)row["MACHUCVU"];
            TEN = row["TEN"].ToString();
            TONGTHOIGIANLAM = Convert.ToInt32(row["TONGTHOIGIANLAM"]);
            NGAYBATDAU = Convert.ToDateTime(row["NGAYBATDAU"]);
        }

        public NhanVien() { }
    }
}
