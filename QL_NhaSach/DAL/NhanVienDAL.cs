using QL_NhaSach.BUS;
using QL_NhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DAL
{
    public class NhanVienDAL
    {
        TaiKhoanDAL TaiKhoanDAL = new TaiKhoanDAL();
        public DataTable GetNhanVienByChiNhanh(string username)
        {
            var query = $"select MANHANVIEN, t.MACHINHANH, MACHUCVU, n.TEN, TONGTHOIGIANLAM, NGAYBATDAU from NHANVIEN n, TAIKHOAN t where T.USERNAME = '{username}' and t.MACHINHANH = n.MACHINHANH";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool GetAllNhanVien()
        {
            var query = $"select * from NHANVien WHERE MACHINHANH = {TaiKhoanDAL.GetMaChiNhanh()}";
            var reuslt = DataProvider.Instance.ExecuteQuery(query);
            return reuslt.Rows.Count > 0;
        }
        //public DataTable GetMaNhanVien()
        //{
        //    var query = $"select MANHANVIEN from NHANVIEN WHERE"
        //}
    }
}
