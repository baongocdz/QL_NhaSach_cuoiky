using QL_NhaSach.BUS;
using QL_NhaSach.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaSach.GUI
{
    public partial class frmLichSu : Form
    {
        public static int idHD;
        public int index;
        HoaDonBUS HoaDonBUS = new HoaDonBUS();
        public frmLichSu()
        {
            InitializeComponent();
        }

        private void frmLichSu_Load(object sender, EventArgs e)
        {
            dgvLichSu.DataSource = HoaDonBUS.GetAllHoaDon();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DataTable dt = HoaDonBUS.GetAllHoaDon();
            dgvLichSu.DataSource = dt;
        }
        private void dgvThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection cell = dgvLichSu.SelectedCells;
            if (cell.Count > 0)
            {
                try
                {
                    index = e.RowIndex;
                    DataGridViewRow row = dgvLichSu.Rows[e.RowIndex];
                    idHD = Convert.ToInt32(row.Cells["MAHOADON"].Value);
                }
                catch
                {
                    MessageBox.Show("vui long chon san pham de xoa!");
                }
            }
        }



        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            DataTable dt = HoaDonBUS.GetHoadonByDtp(dtp.Value);
            dgvLichSu.DataSource = dt;
        }

        private void btnChitiet_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                frmChiTietHoaDon frm = new frmChiTietHoaDon();
                frm.Show();
            }
            else MessageBox.Show("vui long chon vao hoa don.");
        }
    }
}
