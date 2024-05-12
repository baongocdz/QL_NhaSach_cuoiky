using QL_NhaSach.DAL;
using QL_NhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.BUS
{
    public class MatHangBUS
    {
        private readonly MatHangDAL _matHangDAL;
        public MatHangBUS()
        {
            _matHangDAL = new MatHangDAL();
        }

        public DataTable GetAllMatHang()
        {
            DataTable data = new DataTable();
            data = _matHangDAL.GetAllMatHang();
            return data;
        }
        public DataTable GetMatHangByTen(String Ten)
        {
            DataTable data = new DataTable();
            data = _matHangDAL.GetMatHangByTen(Ten);
            return data;
        }
        public DataTable GetMatHangByMa(int id)
        {
            DataTable data = new DataTable();
            data = _matHangDAL.GetMatHangByMa(id);
            return data;
        }
        public DataTable GetCotMatHang()
        {
            DataTable data = new DataTable();
            data = _matHangDAL.GetCotMatHang();
            return data;
        }

    }
}
