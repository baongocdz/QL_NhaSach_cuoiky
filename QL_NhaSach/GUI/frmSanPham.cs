using QL_NhaSach.BUS;
using QL_NhaSach.DAL;
using QL_NhaSach.DTO;
using QL_NhaSach.GUI;
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
    partial class frmSanPham : Form
    {
        private readonly ProductBUS _productBUS;
        private ProductDAL data=new ProductDAL();
        private TaiKhoanDAL _taiKhoanDAL = new TaiKhoanDAL();

        public frmSanPham()
        {
            InitializeComponent();
            _productBUS = new ProductBUS();
            TaiKhoanDAL _taiKhoanDAL = new TaiKhoanDAL();    
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // Load danh sách sản phẩm khi form được load
            LoadProductList();
            int ma = _taiKhoanDAL.GetMaChiNhanh();
        }

        private void LoadProductList()
        {
            List<Product> productList = _productBUS.GetAllProducts();
            dataGridView1.Rows.Clear();
            foreach (var product in productList)
            {
                dataGridView1.Rows.Add(product.MAMATHANG, product.TENMATHANG, product.NHACUNGCAP, product.SOLUONG, product.DONGIA,product.HINHANH);
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            // Tìm kiếm sản phẩm theo từ khóa nhập vào từ ô txtTimKiem
            string keyword = txtTimKiem.Text.Trim();
            List<Product> productList = _productBUS.SearchProducts(keyword);
            dataGridView1.Rows.Clear();
            foreach (var product in productList)
            {
                dataGridView1.Rows.Add(product.MAMATHANG, product.TENMATHANG, product.NHACUNGCAP, product.SOLUONG, product.DONGIA,product.HINHANH);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int maMatHang = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Column2"].Value);
                bool result = _productBUS.DeleteProduct(maMatHang);
                if (result)
                {
                    MessageBox.Show("Xóa sản phẩm thành công.");
                    LoadProductList();
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm không thành công.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.");
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

            // Kiểm tra xem có hàng nào được chọn trong DataGridView không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Tạo một đối tượng Product từ dữ liệu hàng được chọn
                Product selectedProduct = new Product
                {

                    TENMATHANG = selectedRow.Cells[1].Value.ToString(),
                    MAMATHANG = Convert.ToInt32(selectedRow.Cells[0].Value),
                    DONGIA = Convert.ToInt32(selectedRow.Cells[4].Value),
                    SOLUONG = Convert.ToInt32(selectedRow.Cells[3].Value),
                    //LOAISANPHAM = selectedRow.Cells[2].Value.ToString(),
                    NHACUNGCAP = selectedRow.Cells[2].Value.ToString(),
                    HINHANH = selectedRow.Cells[5].Value.ToString(),
                    
                    
                };

                // Hiển thị form ProductDetails với thông tin sản phẩm được chọn
                frmChiTietSP productDetailsForm = new frmChiTietSP(selectedProduct);
                productDetailsForm.Show();
                
                



            }
            else
            {
                // Thông báo cho người dùng rằng họ cần chọn một sản phẩm trước khi xem chi tiết
                MessageBox.Show("Vui lòng chọn một sản phẩm trước khi xem chi tiết.");
            }

           
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }
    }
}
