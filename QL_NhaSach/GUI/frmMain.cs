using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QL_NhaSach.GUI;

namespace QL_NhaSach
{
    public partial class frmMain : Form
    {


        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private Form CurrentFormChild;
        //private void OpenChildForm(Form ChildrenForm)
        //{
        //    if (CurrentFormChild != null)
        //    {
        //        CurrentFormChild.Close();
        //    }
        //    CurrentFormChild = ChildrenForm;
        //    ChildrenForm.TopLevel = false;
        //    ChildrenForm.FormBorderStyle = FormBorderStyle.None;
        //    ChildrenForm.Dock = DockStyle.Fill;
        //    panelMain.Controls.Add(ChildrenForm);
        //    panelMain.Tag = ChildrenForm;
        //    ChildrenForm.BringToFront();
        //    ChildrenForm.Show();
        //}
        private Panel panel_Body;
        private Dictionary<Type, Form> openedForms = new Dictionary<Type, Form>();
        public frmMain()
        {
            InitializeComponent();
            this.panel_Body = panelMain;

        }


        public void openChildForm(Form childForm)
        {
            if (!openedForms.ContainsKey(childForm.GetType()))
            {
                openedForms.Add(childForm.GetType(), childForm);
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panel_Body.Controls.Add(childForm);
            }

            foreach (var form in openedForms.Values)
            {
                form.Hide();
            }

            openedForms[childForm.GetType()].BringToFront();
            openedForms[childForm.GetType()].Show();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThanhToan());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void btnNhapSach_Click(object sender, EventArgs e)
        {
            lblText.Text = "Nhập Sách";

            openChildForm(new frmNhapSach());       
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            lblText.Text = "Nhân Viên";
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {

        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            lblText.Text = "Doanh Thu";

        }

        private void btnMatHang_Click(object sender, EventArgs e)
        {
            lblText.Text = "Sản Phẩm";
            openChildForm(new frmSanPham());
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            this.panel_Body = panelMain;

        }
    }
}
