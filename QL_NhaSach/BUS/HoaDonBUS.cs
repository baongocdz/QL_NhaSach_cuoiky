﻿using QL_NhaSach.DAL;
using QL_NhaSach.DTO;
using QL_NhaSach.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.BUS
{
    public class HoaDonBUS
    {
        private readonly HoaDonDAL _hoaDonDAL = new HoaDonDAL();
        public bool AddChiTietHoaDon(ChiTietHoaDon CThoadon)
        {
            if(CThoadon == null)
            {
                return false;
            }
            return _hoaDonDAL.AddChiTietHoaDon(CThoadon);
        }
        public bool AddHoaDon(HoaDon hoadon)
        {
            if (hoadon == null)
            {
                return false;
            }
            return _hoaDonDAL.AddHoaDon(hoadon);
        }
        public DataTable GetAllHoaDon()
        {
            return _hoaDonDAL.GetAllHoaDon();
        }
        public DataTable GetHoadonByDtp(DateTime data)
        {
            return _hoaDonDAL.GetHoadonByDtp(data);
        }
        public DataTable GetChiTietHoaDonByMaHD()
        {
            return _hoaDonDAL.GetChiTietHoaDonByMaHD();
        }
    }
}
