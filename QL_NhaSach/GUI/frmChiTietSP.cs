using QL_NhaSach.BUS;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_NhaSach.GUI
{
    public partial class frmChiTietSP : Form
    {
        private readonly ProductBUS _productBUS=new ProductBUS();
        public string ImagePath { get; set; }
        private Product product;
        
        public frmChiTietSP(Product product)
        {
            InitializeComponent();
            this.product = product;
            DisplayProductDetails();
        }

        private void DisplayProductDetails()
        {
            // Hiển thị thông tin sản phẩm trên các điều khiển của form
            txtMaSanPham.Text = product.MAMATHANG.ToString();
            txtTenSanPham.Text = product.TENMATHANG;
            //txtLoaiSanPham.Text = product.LOAISANPHAM;
            txtNhaCungCap.Text = product.NHACUNGCAP;
            txtSoLuong.Text = product.SOLUONG.ToString();
            txtDonGia.Text = product.DONGIA.ToString();
            ImagePath=product.HINHANH.ToString();

        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {

            // Kiểm tra xem tệp ảnh có tồn tại không
            if (!string.IsNullOrEmpty(ImagePath) && System.IO.File.Exists(ImagePath))
            {
                // Tải ảnh từ đường dẫn
                Image image = Image.FromFile(ImagePath);

                // Gán ảnh cho PictureBox
                pictureBox1.Image = image;
            }
            else
            {
                MessageBox.Show("Không thể tìm thấy tệp ảnh.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                MAMATHANG = int.Parse(txtMaSanPham.Text),
                TENMATHANG = txtTenSanPham.Text,
                //LOAISANPHAM = txtLoaiSanPham.Text,
                NHACUNGCAP = txtNhaCungCap.Text,
                SOLUONG = int.Parse(txtSoLuong.Text),
                DONGIA = int.Parse(txtDonGia.Text),
            };
            if (_productBUS.UpdateProduct(product))
            {
                MessageBox.Show("Cập nhật thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();

        }
    }
}

