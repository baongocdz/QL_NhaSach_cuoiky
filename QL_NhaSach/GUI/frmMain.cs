﻿using System;
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
        string connectionstring = @"Data Source=NGOCDZ\SQLEXPRESS02;
                                    Initial Catalog=QL_NhaSach;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
        public int[] dem;
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionstring);
        }

        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        con.Open();
        //        cmd = new SqlCommand("select * from TAIKHOAN", con);
        //        adt = new SqlDataAdapter(cmd);  
        //        adt.Fill(dt);
        //        dataGridView1.DataSource = dt;
        //        con.Close();
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }


        //}

        //private void btnThem_Click_1(object sender, EventArgs e)
        //{
        //    // lmao
        //    try
        //    {
                
        //        int a = int.Parse(txtMASP.Text);
        //        bool b = false;
        //        con.Open();
        //        cmd = new SqlCommand($"DECLARE @A INT = 1; SELECT MASANPHAM, LoaiSanPham,TenSanPham, TacGia,SoLuongCon,DonGia, @A AS SOLUONGMUA FROM dbo.LAY_THONG_TIN_SAN_PHAM({a})", con);
        //        adt = new SqlDataAdapter(cmd);
        //        adt.Fill(dt);
        //        dataGridView1.DataSource = dt;
        //        con.Close();
        //        int IndexOfColum = 6;
        //        foreach (DataGridViewRow row in dataGridView1.Rows)
        //        {
        //            if (!row.IsNewRow && row.Index != -1)
        //            {
        //                object cellValueObject = row.Cells["MASANPHAM"].Value;
        //                foreach (DataGridViewRow row1 in dataGridView1.Rows)
        //                {
        //                    if (!row.IsNewRow && row.Index != row1.Index)
        //                    {
        //                        object cellValueObject1 = row1.Cells["MASANPHAM"].Value;
        //                        if(cellValueObject1 == cellValueObject)
        //                        {
        //                            DataGridViewCell cellToUpdate = dataGridView1.Rows[row.Index].Cells[IndexOfColum];
        //                            //cellToUpdate = dem[row]
        //                        }
        //                    }
                            
        //                }
                        
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    txtMASP.Text = "";

        //}


        private void txtMASP_TextChanged(object sender, EventArgs e)
        {

        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thanhtoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThanhToan frmThanhToan = new frmThanhToan();
            frmThanhToan.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(frmThanhToan);
            frmThanhToan.Show();
        }
    }
}
