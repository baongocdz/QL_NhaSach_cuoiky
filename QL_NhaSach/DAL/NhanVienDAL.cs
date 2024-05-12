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
        public DataTable GetNhanVienByChiNhanh(string username)
        {
            var query = $"select MANHANVIEN, t.MACHINHANH, MACHUCVU, n.TEN, TONGTHOIGIANLAM, NGAYBATDAU from NHANVIEN n, TAIKHOAN t where T.USERNAME = '{username}' and t.MACHINHANH = n.MACHINHANH";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        //public DataTable GetMaNhanVien()
        //{
        //    var query = $"select MANHANVIEN from NHANVIEN WHERE"
        //}
    }
}
