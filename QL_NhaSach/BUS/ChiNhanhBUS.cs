using QL_NhaSach.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.BUS
{
    public class ChiNhanhBUS
    {
        ChiNhanhDAL _chiNhanhDAL = new ChiNhanhDAL();
        public DataTable GetAllChiNhanh()
        {
            return _chiNhanhDAL.GetAllChiNhanh();
        }

    }
}
