using QL_NhaSach.BUS;
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
    public partial class frmChiTietHoaDon : Form
    {
        HoaDonBUS HoaDonBUS = new HoaDonBUS();  
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = HoaDonBUS.GetChiTietHoaDonByMaHD();
        }
    }
}
