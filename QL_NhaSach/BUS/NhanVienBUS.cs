using QL_NhaSach.DAL;
using QL_NhaSach.DTO;
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
        private readonly NhanVienDAL _nhanVienDAL;

        public NhanVienBUS()
        {
            _nhanVienDAL = new NhanVienDAL();
        }
       
        public DataTable GetNhanVienByChiNhanh()
        {
            return _nhanVienDAL.GetNhanVienByChiNhanh(frmLogin.username);
        }
        
        public List<NhanVien> LayTatCaNhanVien()
        {
            var danhSachNhanVien = new List<NhanVien>();
            var dataTable = _nhanVienDAL.LayTatCaNhanVien();
            foreach (DataRow row in dataTable.Rows)
            {
                danhSachNhanVien.Add(new NhanVien(row));
            }
            return danhSachNhanVien;
        }

        public List<NhanVien> TimKiemNhanVien(string keyword)
        {
            List<NhanVien> danhSachNhanVien = new List<NhanVien>();
            var dataTable = _nhanVienDAL.TimKiemNhanVien(keyword);
            foreach (DataRow row in dataTable.Rows)
            {
                NhanVien nhanVien = new NhanVien(row);
                danhSachNhanVien.Add(nhanVien);
            }
            return danhSachNhanVien;
        }

        public bool XoaNhanVien(int maNhanVien)
        {
            return _nhanVienDAL.XoaNhanVien(maNhanVien);
        }

        public bool ThemNhanVien(NhanVien data)
        {
            if (data == null)
            {
                return false;
            }
            return _nhanVienDAL.ThemNhanVien(data);
        }
    }
}
