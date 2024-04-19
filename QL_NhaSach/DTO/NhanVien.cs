using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DTO
{
    public class NhanVien
    {
        public int MANHANVIEN {  get; set; }    
        public int MATAIKHOAN { get; set; }
        public int MACHINHANH { get; set; }
        public String TEN {  get; set; }
        public string VITRI { get; set; }
        public float TONGTHOIGIANLAM {  get; set; }
        public DateTime NGAYBATDAU { get; set; }
    }
}
