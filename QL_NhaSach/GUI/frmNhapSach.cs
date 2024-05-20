using QL_NhaSach.BUS;
using QL_NhaSach.DAL;
using QL_NhaSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace QL_NhaSach.GUI
{
    public partial class frmNhapSach : Form
    {
        private NhapSachBUS _nhapsachBUS = new NhapSachBUS();
        private HoaDonBUS _hoadonBUS = new HoaDonBUS();
        private TaiKhoanDAL _taiKhoanDAL = new TaiKhoanDAL();   
        private MatHangBUS _matHangBUS = new MatHangBUS();
        private NhanVienBUS _nhanvienBUS = new NhanVienBUS();
        private DataTable data = new DataTable();
        private int index;
        private int idMH; 
        private string nhaCC; 
        private string tenMH; 
        private int soluongMH;
        private int dongiaMH; 
        //private DateTime NgayNhap;
        public frmNhapSach()
        {
            InitializeComponent();
        }
        private void frmNhapSach_Load(object sender, EventArgs e)
        {
            dtpNgayNhap.Value = DateTime.Now;
            txtNhaCungCap.Text = "Fahasa";
            GetDatatable();

        }
        public DataTable GetDatatable()
        {

            data.Columns.Add("TENMATHANG", typeof(string));
            data.Columns.Add("NHACUNGCAP", typeof(string));
            data.Columns.Add("SOLUONG", typeof(int));
            data.Columns.Add("DONGIA", typeof(int));
            data.PrimaryKey = new DataColumn[] { data.Columns["TENMATHANG"] }; // them khoa chinh de dung duoc foundrow
            return data;
        }
        private void DinhDang()
        {
            DataGridViewColumn TENMATHANG = dgvNhapSach1.Columns[0];
            DataGridViewColumn NHACUNGCAP = dgvNhapSach1.Columns[1];
            DataGridViewColumn DONGIA = dgvNhapSach1.Columns[2];
            DataGridViewColumn SOLUONG = dgvNhapSach1.Columns[3];

            dgvNhapSach1.ReadOnly = true;
            dgvNhapSach1.Columns[0].HeaderText = "Tên Mặt Hàng";
            dgvNhapSach1.Columns[0].Width = 150;
            dgvNhapSach1.Columns[1].HeaderText = "Nhà Cung Cấp";
            dgvNhapSach1.Columns[1].Width = 150;
            dgvNhapSach1.Columns[2].HeaderText = "Số Lượng";
            dgvNhapSach1.Columns[2].Width = 80;
            dgvNhapSach1.Columns[3].HeaderText = "Đơn Giá";
            dgvNhapSach1.Columns[3].Width = 80;

            TENMATHANG.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NHACUNGCAP.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DONGIA.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SOLUONG.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void dgvNhapSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection cell = dgvNhapSach1.SelectedCells;
            if (cell.Count > 0)
            {
                try
                {
                    index = e.RowIndex;
                    DataGridViewRow row = dgvNhapSach1.Rows[e.RowIndex];
                    if (row.Cells["TENMATHANG"].Value != null &&
                        row.Cells["SOLUONG"].Value != null && row.Cells["DONGIA"].Value != null && row.Cells["NHACUNGCAP"].Value != null)
                    {
                        txtTen.Text = row.Cells["TENMATHANG"].Value.ToString();
                        txtNhaCungCap.Text = row.Cells["NHACUNGCAP"].Value.ToString();
                        txtSoLuong.Text = row.Cells["SOLUONG"].Value.ToString();
                        txtDonGia.Text = row.Cells["DONGIA"].Value.ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("vui long chon vao dong san pham");
                }
            }
        }
        private void AddData(DataTable data, string nhaCC, string tenMH, int SoLuong, int dongiaMH)
        {
            bool check = false;
            foreach (DataRow row in data.Rows)
            {
                if (row["TENMATHANG"].ToString() == tenMH)
                {
                    row["SOLUONG"] = SoLuong;
                    row["NHACUNGCAP"] = nhaCC;
                    row["DONGIA"] = dongiaMH;

                    check = true;
                    break;
                }
            }
            if (check == false)
            {
                DataRow newrow = data.NewRow();
                newrow["NHACUNGCAP"] = nhaCC;
                newrow["TENMATHANG"] = tenMH;
                newrow["SOLUONG"] = SoLuong;
                newrow["DONGIA"] = dongiaMH;
                data.Rows.Add(newrow);
            }

        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                if(!string.IsNullOrEmpty(txtNhaCungCap.Text) && !string.IsNullOrEmpty(txtTen.Text) && !string.IsNullOrEmpty(txtSoLuong.Text) && !string.IsNullOrEmpty(txtDonGia.Text))
                {
                    nhaCC = txtNhaCungCap.Text;
                    tenMH = txtTen.Text;
                    dongiaMH = Convert.ToInt32(txtDonGia.Text);
                    soluongMH = Convert.ToInt32(txtSoLuong.Text);
                    //ChiTietNhap chiTietNhap = new ChiTietNhap()
                    //{
                    //    TenMatHang = tenMH,
                    //    NhaCungCap = nhaCC,
                    //    DonGia = dongiaMH,
                    //    SoLuong = soluongMH,
                    //};
                    AddData(data, nhaCC, tenMH, soluongMH, dongiaMH);
                    dgvNhapSach1.DataSource = data;
                    DinhDang();
                    txtTen.Focus();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin");
                }
                txtThanhTien.Text = TinhTien().ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không Thể Thêm " + ex.Message);
            }
        }
        private int TinhTien()
        {
            int sum = 0;
            foreach(DataRow row in data.Rows)
            {
                sum += (int)row["SOLUONG"] * (int)row["DONGIA"];
            }
            return sum;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                data.Rows.RemoveAt(index);
            }
            catch 
            {
                MessageBox.Show("Vui Lòng Chọn dòng để xóa.");
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Xác Nhận", "Thông Báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if(data.Rows.Count > 0)
                    {
                        NhapSach nhapSach = new NhapSach()
                        {
                            NgayNhap = dtpNgayNhap.Value,
                            MaChiNhanh = _taiKhoanDAL.GetMaChiNhanh(),
                            ThanhTien = TinhTien()
                        };
                        HoaDon hoadon = new HoaDon()
                        {
                            ThanhTien = TinhTien(),
                            MaNhanVien = 0,
                            MaChiNhanh = _taiKhoanDAL.GetMaChiNhanh()
                        };
                        _hoadonBUS.AddHoaDon(hoadon);
                        _nhapsachBUS.AddNhapSach(nhapSach);
                        foreach (DataRow row in data.Rows)
                        {
                            ChiTietNhap chiTietNhap = new ChiTietNhap()
                            {
                                TenMatHang = (string)row["TENMATHANG"],
                                NhaCungCap = (string)row["NHACUNGCAP"],
                                SoLuong = (int)row["SOLUONG"],
                                DonGia = (int)row["DONGIA"]
                            };
                            MatHang matHang = new MatHang()
                            {
                                MaChiNhanh = _taiKhoanDAL.GetMaChiNhanh(),
                                TenMatHang = (string)row["TENMATHANG"],
                                NhaCungCap = (string)row["NHACUNGCAP"],
                                SoLuong = (int)row["SOLUONG"],
                                DonGia = (int)row["DONGIA"]
                            };
                            _nhapsachBUS.AddChiTietNhap(chiTietNhap);
                            _matHangBUS.AddMatHang(matHang);
                            ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon()
                            {
                                MaMatHang = _matHangBUS.GetMaMatHangMax(),
                                SoLuong = (int)row["SOLUONG"],
                                DonGia = (int)row["DONGIA"],
                            };
                            _hoadonBUS.AddChiTietHoaDon(chiTietHoaDon);
                            _matHangBUS.DecreaseSoLuong(chiTietHoaDon.MaMatHang, chiTietHoaDon.SoLuong);
                        }
                        MessageBox.Show("Nhập Thành Công.");
                    }
                    else MessageBox.Show("Vui Lòng Thêm Vào Các Mặt Hàng.");
                    //SELECT* FROM MATHANG -> check code
                    //SELECT* FROM HOADON
                    //SELECT* FROM CHITIETHOADON
                    //SELECT* FROM CHITIETNHAP
                    //SELECT* FROM NHAPSACH
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nhập Không Thành Công." + ex);
            }
        }
    }
}
