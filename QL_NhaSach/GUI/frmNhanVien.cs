using QL_NhaSach.BUS;
using QL_NhaSach.DAL;
using QL_NhaSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaSach.GUI
{
    public partial class frmNhanVien : Form
    {
        private NhanVien data = new NhanVien();
        
        private readonly NhanVienBUS _nhanVienBUS;
        public frmNhanVien()
        {
            InitializeComponent();
            _nhanVienBUS = new NhanVienBUS();
            TaiKhoanDAL _taiKhoanDAL = new TaiKhoanDAL();

            
            
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        private void LoadData()
        {
            List<NhanVien> nv = _nhanVienBUS.LayTatCaNhanVien();
            dataGridView1.Rows.Clear();
            foreach (var nhanVien in nv)
            {
                dataGridView1.Rows.Add(nhanVien.MANHANVIEN, nhanVien.MACHINHANH, nhanVien.MACHUCVU, nhanVien.TEN, nhanVien.TONGTHOIGIANLAM, nhanVien.NGAYBATDAU);
            }
        }


        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int maNhanVien = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MANHANVIEN"].Value);
                if (_nhanVienBUS.XoaNhanVien(maNhanVien))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            dataGridView1.DataSource = _nhanVienBUS.TimKiemNhanVien(keyword);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.TEN = textBox1.Text;
                // Các thông tin khác của nhân viên cần được thêm vào đây (Mã chi nhánh, mã chức vụ, tổng thời gian làm, ngày bắt đầu)

                if (_nhanVienBUS.ThemNhanVien(nhanVien))
                {
                    MessageBox.Show("Thêm thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

       
    }
}
