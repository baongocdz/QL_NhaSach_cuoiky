using QL_NhaSach.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.BUS
{
    public class NhanVienBUS
    {
        private readonly NhanVienDAL _nhanVienDAL = new NhanVienDAL();
        public DataTable GetNhanVienByChiNhanh()
        {
            return _nhanVienDAL.GetNhanVienByChiNhanh(frmLogin.username);
        }
    }
}
