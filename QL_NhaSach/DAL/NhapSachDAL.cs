using QL_NhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.DAL
{
    public class NhapSachDAL
    {
        public bool AddNhapSach(NhapSach data)
        {
            var query = $"insert into NHAPSACH(NGAYNHAP, MACHINHANH, THANHTIEN) values ('{data.NgayNhap}', {data.MaChiNhanh}, {data.ThanhTien})";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool AddChiTietNhap(ChiTietNhap data)
        {
            var query = $"insert into CHITIETNHAP(MACHITIETNHAP, MANHAP,TENMATHANG, NHACUNGCAP, DONGIA, SOLUONG) " +
                $"values({GetMaNhap()}, {GetMaNhap()}, N'{data.TenMatHang}', N'{data.NhaCungCap}', {data.DonGia}, {data.SoLuong})";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int GetMaNhap()
        {
            var query = "select MAX(MANHAP) from NHAPSACH";
            object result = DataProvider.Instance.ExecuteScalar(query);
            int kq = Convert.ToInt32(result);
            return kq;  
        }
    }
}
