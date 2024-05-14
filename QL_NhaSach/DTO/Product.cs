using System;
using System.Data;
using System.Collections.Generic;

namespace QL_NhaSach.DTO
{
    public class Product
    {
        public int MAMATHANG { get; set; }
        public int MACHINHANH { get; set; }
        public string TENMATHANG { get; set; }
        public int SOLUONG { get; set; }
        public int DONGIA { get; set; }
        public string NHACUNGCAP { get; set; }
        //public string LOAISANPHAM { get; set; }
        public string HINHANH { get; set; }
       

        public Product(DataRow row)
        {
            MAMATHANG = (int)row["MAMATHANG"];
            MACHINHANH = (int)row["MACHINHANH"];
            TENMATHANG = row["TENMATHANG"].ToString();
            SOLUONG = Convert.ToInt32(row["SOLUONG"]);
            DONGIA = Convert.ToInt32(row["DONGIA"]);
            NHACUNGCAP = row["NHACUNGCAP"].ToString();
            //LOAISANPHAM = row["LOAISANPHAM"].ToString();
            HINHANH = row["HINHANH"].ToString();
        }


        public Product() { }

       
    }
}
