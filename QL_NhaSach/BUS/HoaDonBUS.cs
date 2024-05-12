using QL_NhaSach.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.BUS
{
    public class HoaDonBUS
    {
        private readonly HoaDonDAL _hoaDonDAL = new HoaDonDAL(); 
        public int GetMaHD()
        {
            return _hoaDonDAL.GetMaHD(); //ngoc
        }
    }
}
