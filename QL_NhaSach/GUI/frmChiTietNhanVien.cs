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
    public partial class frmChiTietNhanVien : Form
    {
        TaiKhoanDAL TaiKhoanDAL = new TaiKhoanDAL();
        private NhanVien nv;
        public string ImagePath { get; set; }

        public frmChiTietNhanVien(NhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;
            //DisplayNVDetails();
        }
        //private void DisplayNVDetails()
        //{
        //    txtTen.Text = nv.Ten;
        //    txtChiNhanh.Text = TaiKhoanDAL.GetChiNhanh();
        //    txtSoGioLam.Text = nv.TongThoiGianLam.ToString();
        //    txtNgayBatDau.Text = nv.NgayBatDau.ToString();
        //    txtLinkAnh.Text = nv.Anh;
        //    ImagePath = nv.Anh;
        //}

        private void frmChiTietNhanVien_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ImagePath) && System.IO.File.Exists(ImagePath))
            {
                // Tải ảnh từ đường dẫn
                Image image = Image.FromFile(ImagePath);

                // Gán ảnh cho PictureBox
                //pictureBox1.Image = image;
            }
            else
            {
                MessageBox.Show("Không thể tìm thấy tệp ảnh.");
            }
        }
    }
}
