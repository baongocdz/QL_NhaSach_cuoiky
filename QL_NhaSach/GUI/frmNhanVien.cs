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
        private void LoadData()
        {
            List<NhanVien> nv = _nhanVienBUS.LayTatCaNhanVien();
            dataGridView1.Rows.Clear();
            foreach (var nhanVien in nv)
            {
                dataGridView1.Rows.Add(nhanVien.MaNhanVien, nhanVien.MaChiNhanh, nhanVien.MaChucVu, nhanVien.Ten, nhanVien.TongThoiGianLam, nhanVien.NgayBatDau);
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


        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.Ten = textBox1.Text;
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

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            dataGridView1.DataSource = _nhanVienBUS.TimKiemNhanVien(keyword);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
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

        private void btnXem_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                NhanVien nv = new NhanVien
                {
                    MaNhanVien = Convert.ToInt32(selectedRow.Cells[0].Value),
                    MaChiNhanh = Convert.ToInt32(selectedRow.Cells[1].Value),
                    MaChucVu = Convert.ToInt32(selectedRow.Cells[2].Value),
                    Ten = selectedRow.Cells[3].Value.ToString(),
                    TongThoiGianLam = Convert.ToInt32(selectedRow.Cells[4].Value),
                    NgayBatDau = (DateTime)selectedRow.Cells[5].Value,
                    Anh = selectedRow.Cells[6].Value.ToString(),
                };
                frmChiTietNhanVien frm = new frmChiTietNhanVien(nv);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm trước khi xem chi tiết.");
            }
        }
    }
}
