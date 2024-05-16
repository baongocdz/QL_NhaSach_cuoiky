using QL_NhaSach.DAL;
using QL_NhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.BUS
{
    public class NhapSachBUS
    {
        private NhapSachDAL _nhapSachDAL = new NhapSachDAL();
        public bool AddNhapSach(NhapSach data)
        {
            if(data == null)
            {
                return false;
            }
            return _nhapSachDAL.AddNhapSach(data);
        }
        public bool AddChiTietNhap(ChiTietNhap data)
        {
            if(data == null)
            {
                return false;
            }
            return _nhapSachDAL.AddChiTietNhap(data);
        }
    }
}
