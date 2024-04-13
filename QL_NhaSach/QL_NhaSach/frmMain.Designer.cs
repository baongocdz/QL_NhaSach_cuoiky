namespace QL_NhaSach
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMASP = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(763, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSum
            // 
            this.btnSum.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btnSum.Location = new System.Drawing.Point(820, 351);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(95, 37);
            this.btnSum.TabIndex = 2;
            this.btnSum.Text = "Tổng";
            this.btnSum.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "thu ngân";
            // 
            // txtMASP
            // 
            this.txtMASP.Location = new System.Drawing.Point(820, 97);
            this.txtMASP.Name = "txtMASP";
            this.txtMASP.Size = new System.Drawing.Size(249, 26);
            this.txtMASP.TabIndex = 4;
            this.txtMASP.TextChanged += new System.EventHandler(this.txtMASP_TextChanged);
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(933, 356);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(249, 26);
            this.txtSum.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(820, 129);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 34);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 666);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtMASP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMASP;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Button btnThem;
    }
}

