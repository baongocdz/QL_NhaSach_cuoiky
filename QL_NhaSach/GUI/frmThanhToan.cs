using QL_NhaSach.BUS;
using QL_NhaSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaSach.GUI
{
    public partial class frmThanhToan : Form
    {
        List<MatHang> LIST;
        private readonly MatHangBUS _matHangBUS = new MatHangBUS();
        private readonly NhanVienBUS _nhanVienBUS = new NhanVienBUS();  
        private readonly HoaDonBUS _hoaDonBUS = new HoaDonBUS();


        private int idMH;
        private string tenMH;
        private int soluongMH;
        private int dongiaMH;
        private int sum;
        private int index;
        private int maNV;
        DataTable data = new DataTable();

        public frmThanhToan()
        {
            InitializeComponent();
            //this.dgvThanhToan.CellClick += btnThem_Click;
        }
        private void DinhDang()
        {
            dgvMatHang.ReadOnly = true;
            dgvMatHang.Columns[0].HeaderText = "Mã Mặt Hàng";
            dgvMatHang.Columns[0].Width = 70;
            dgvMatHang.Columns[1].HeaderText = "Tên Mặt Hàng";
            dgvMatHang.Columns[1].Width = 70;
            dgvMatHang.Columns[2].HeaderText = "Số Lượng";
            dgvMatHang.Columns[2].Width = 50;
            dgvMatHang.Columns[3].HeaderText = "Đơn Giá";
            dgvMatHang.Columns[3].Width = 50;
        }
        private void DinhDang2()
        {
            dgvThanhToan.ReadOnly = true;
            dgvThanhToan.Columns[0].HeaderText = "Mã Mặt Hàng";
            dgvThanhToan.Columns[0].Width = 70;
            dgvThanhToan.Columns[1].HeaderText = "Tên Mặt Hàng";
            dgvThanhToan.Columns[1].Width = 70;
            dgvThanhToan.Columns[2].HeaderText = "Số Lượng";
            dgvThanhToan.Columns[2].Width = 50;
            dgvThanhToan.Columns[3].HeaderText = "Đơn Giá";
            dgvThanhToan.Columns[3].Width = 50;
        }
        public DataTable GetDatatable()
        {
            
            data.Columns.Add("MAMATHANG", typeof(int));
            data.Columns.Add("TENMATHANG", typeof(string));
            data.Columns.Add("SOLUONG", typeof(int));
            data.Columns.Add("DONGIA", typeof(int));
            data.PrimaryKey = new DataColumn[] { data.Columns["MAMATHANG"] }; // them khoa chinh de dung duoc foundrow
            return data;
        }
        public void AddDatatable(DataTable data, int Id, string Ten, int SoLuong, int DonGia)
        {
            bool check = false;
            foreach (DataRow row in data.Rows)
            {
                if ((int)row["MAMATHANG"] == Id)
                {
                    if((int)row["SOLUONG"] < SoLuong)
                    {
                        row["SOLUONG"] = (int)row["SOLUONG"] + 1;
                        check = true;
                        break;
                    }
;                   check = true;
                    MessageBox.Show("Hết Hàng.");

                }
            }
            if (check == false)
            {
                DataRow newrow = data.NewRow();
                if (SoLuong > 0)
                {
                    newrow["MAMATHANG"] = Id;
                    newrow["TENMATHANG"] = Ten;
                    newrow["SOLUONG"] = 1;
                    newrow["DONGIA"] = DonGia;
                    data.Rows.Add(newrow);
                }
                else MessageBox.Show("Hết Hàng.");


            }


            //DataRow foundRow = data.Rows.Find(Id);

            //if (foundRow != null)
            //{
            //    // Mặt hàng đã tồn tại, cập nhật số lượng
            //    foundRow["SOLUONG"] = (int)foundRow["SOLUONG"] + 1;
            //}
            //else
            //{
            //    // Mặt hàng chưa tồn tại, thêm dòng mới
            //    DataRow newRow = data.NewRow();
            //    newRow["MaMATHANG"] = Id;
            //    newRow["TENMATHANG"] = tenMH;
            //    newRow["SOLUONG"] = 1;
            //    newRow["DONGIA"] = dongiaMH;
            //    data.Rows.Add(newRow);
            //}
        }
        public void DeleteRow()
        {
            bool check = false;
            foreach(DataRow row in data.Rows)
            {
                if ((int)row["SOLUONG"] > 1)
                {
                    row["SOLUONG"] = (int)row["SOLUONG"] - 1; check = true; break;
                }
            }
            if(!check)
            {
                try
                {
                    data.Rows.RemoveAt(index);
                }
                catch
                {
                    MessageBox.Show("vui long chon dong de xoa");
                }
            }
        }
        private void loadData()
        {
            var data1 = _matHangBUS.GetAllMatHang();
            dgvMatHang.DataSource = data1;
            DinhDang();
            GetDatatable();
        }
        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            loadData();
            DataTable dt = new DataTable();
            dt = GetNhanVien();
            cbxNhanVien.DataSource = dt;
            cbxNhanVien.DisplayMember = dt.Columns[3].ColumnName;
            cbxNhanVien.ValueMember = dt.Columns[0].ColumnName;
            if (cbxNhanVien.SelectedItem != null)
            {
                String maNVstr = cbxNhanVien.SelectedValue.ToString();
                int.TryParse(maNVstr, out maNV);
            }
            else
            {
                MessageBox.Show("Không có nhân viên nào được chọn.");
            }
        }
        public DataTable GetNhanVien()
        {
            return _nhanVienBUS.GetNhanVienByChiNhanh();
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            var lmao = _matHangBUS.GetAllMatHang();
            dgvMatHang.DataSource = lmao;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var lmao = _matHangBUS.GetMatHangByTen(txtTimKiem.Text);
            dgvMatHang.DataSource = lmao;
            DinhDang();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            AddDatatable(data, idMH, tenMH, soluongMH, dongiaMH);
            dgvThanhToan.DataSource = data;
            DinhDang2();
            int t = tinhtien();
            txtTinhTien.Text = t.ToString();
        }

        public int tinhtien()
        {
            int sum = 0;
            foreach (DataRow row in data.Rows)
            {
                sum += (int)row["SOLUONG"] * (int)row["DONGIA"];
            }
            return sum;
        }

        private void dgvMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection cell = dgvMatHang.SelectedCells;
            if (cell.Count > 0)
            {
                try
                {
                    index = e.RowIndex;
                    DataGridViewRow row = dgvMatHang.Rows[e.RowIndex];
                    if (row.Cells["MAMATHANG"].Value != null && row.Cells["TENMATHANG"].Value != null &&
                        row.Cells["SOLUONG"].Value != null && row.Cells["DONGIA"].Value != null)
                    {
                        idMH = Convert.ToInt32(row.Cells["MAMATHANG"].Value);
                        tenMH = row.Cells["TENMATHANG"].Value.ToString();
                        soluongMH = Convert.ToInt32(row.Cells["SOLUONG"].Value);
                        dongiaMH = Convert.ToInt32(row.Cells["DONGIA"].Value);
                    }
                }
                catch
                {
                    MessageBox.Show("vui long chon san pham de them!");
                }
            }            
        }

        private void dgvThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection cell = dgvThanhToan.SelectedCells;
            if (cell.Count > 0)
            {
                try
                {
                    index = e.RowIndex;
                    DataGridViewRow row = dgvThanhToan.Rows[e.RowIndex];
                    if (row.Cells["MAMATHANG"].Value != null && row.Cells["TENMATHANG"].Value != null &&
                        row.Cells["SOLUONG"].Value != null && row.Cells["DONGIA"].Value != null)
                    {
                        idMH = Convert.ToInt32(row.Cells["MAMATHANG"].Value);
                        tenMH = row.Cells["TENMATHANG"].Value.ToString();
                        soluongMH = Convert.ToInt32(row.Cells["SOLUONG"].Value);
                        dongiaMH = Convert.ToInt32(row.Cells["DONGIA"].Value);
                    }
                }
                catch
                {
                    MessageBox.Show("vui long chon san pham de xoa!");
                }
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DeleteRow();
            dgvThanhToan.DataSource = data;
            int t = tinhtien();
            txtTinhTien.Text = t.ToString();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon hoadon = new HoaDon()
                {
                    ThanhTien = tinhtien(),
                    MaNhanVien = maNV,
                };
                _hoaDonBUS.AddHoaDon(hoadon);
                foreach (DataRow row in data.Rows)
                {
                    ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon()
                    {
                        MaMatHang = (int)row["MAMATHANG"],
                        SoLuong = (int)row["SOLUONG"],
                        DonGia = (int)row["DONGIA"],
                    };
                    _hoaDonBUS.AddChiTietHoaDon(chiTietHoaDon);
                    _matHangBUS.DecreaseSoLuong(chiTietHoaDon.MaMatHang, chiTietHoaDon.SoLuong);
                }
                data.Clear();
                dgvThanhToan.DataSource = null;
                var data1 = _matHangBUS.GetAllMatHang();
                dgvMatHang.DataSource = data1;
                DinhDang();
                MessageBox.Show("Thanh Toán Thành Công.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thanh Toán Không Thành Công." + ex);
            }


        }


    }
}
