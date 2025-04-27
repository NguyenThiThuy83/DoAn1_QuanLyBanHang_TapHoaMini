namespace GUI
{
    partial class GUI_QLLoaiHang
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
            groupBox2 = new GroupBox();
            btnTimKiem = new Button();
            txtTenLHTimKiem = new TextBox();
            txtMaLHTimKiem = new TextBox();
            label6 = new Label();
            label5 = new Label();
            dgvLoaiHang = new DataGridView();
            txtMoTa = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtMaLH = new TextBox();
            label4 = new Label();
            txtTenLH = new TextBox();
            groupBox1 = new GroupBox();
            btnMoi = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            label1 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiHang).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTenLHTimKiem);
            groupBox2.Controls.Add(txtMaLHTimKiem);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(16, 667);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(902, 83);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 12F);
            btnTimKiem.Location = new Point(740, 40);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(156, 37);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTenLHTimKiem
            // 
            txtTenLHTimKiem.Font = new Font("Microsoft Sans Serif", 12F);
            txtTenLHTimKiem.Location = new Point(495, 40);
            txtTenLHTimKiem.Name = "txtTenLHTimKiem";
            txtTenLHTimKiem.Size = new Size(225, 30);
            txtTenLHTimKiem.TabIndex = 3;
            // 
            // txtMaLHTimKiem
            // 
            txtMaLHTimKiem.Font = new Font("Microsoft Sans Serif", 12F);
            txtMaLHTimKiem.Location = new Point(151, 44);
            txtMaLHTimKiem.Name = "txtMaLHTimKiem";
            txtMaLHTimKiem.Size = new Size(169, 30);
            txtMaLHTimKiem.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(335, 47);
            label6.Name = "label6";
            label6.Size = new Size(131, 25);
            label6.TabIndex = 1;
            label6.Text = "Tên loại hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(10, 47);
            label5.Name = "label5";
            label5.Size = new Size(124, 25);
            label5.TabIndex = 0;
            label5.Text = "Mã loại hàng";
            // 
            // dgvLoaiHang
            // 
            dgvLoaiHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiHang.Location = new Point(12, 268);
            dgvLoaiHang.Name = "dgvLoaiHang";
            dgvLoaiHang.RowHeadersWidth = 51;
            dgvLoaiHang.Size = new Size(896, 274);
            dgvLoaiHang.TabIndex = 9;
            dgvLoaiHang.CellClick += dgvLoaiHang_CellClick;
            // 
            // txtMoTa
            // 
            txtMoTa.Font = new Font("Microsoft Sans Serif", 12F);
            txtMoTa.Location = new Point(146, 104);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(401, 62);
            txtMoTa.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(451, 57);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 2;
            label3.Text = "Tên loại hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(14, 54);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 1;
            label2.Text = "Mã loại hàng";
            // 
            // txtMaLH
            // 
            txtMaLH.Font = new Font("Microsoft Sans Serif", 12F);
            txtMaLH.Location = new Point(146, 54);
            txtMaLH.Name = "txtMaLH";
            txtMaLH.Size = new Size(262, 30);
            txtMaLH.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(14, 122);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 3;
            label4.Text = "Mô tả";
            // 
            // txtTenLH
            // 
            txtTenLH.Font = new Font("Microsoft Sans Serif", 12F);
            txtTenLH.Location = new Point(615, 52);
            txtTenLH.Name = "txtTenLH";
            txtTenLH.Size = new Size(262, 30);
            txtTenLH.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTenLH);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaLH);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(896, 188);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin loại hàng";
            // 
            // btnMoi
            // 
            btnMoi.Font = new Font("Microsoft Sans Serif", 12F);
            btnMoi.Location = new Point(20, 589);
            btnMoi.Name = "btnMoi";
            btnMoi.Size = new Size(94, 39);
            btnMoi.TabIndex = 10;
            btnMoi.Text = "Mới";
            btnMoi.UseVisualStyleBackColor = true;
            btnMoi.Click += btnMoi_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Microsoft Sans Serif", 12F);
            btnThem.Location = new Point(219, 589);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 39);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Microsoft Sans Serif", 12F);
            btnSua.Location = new Point(418, 589);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 39);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Microsoft Sans Serif", 12F);
            btnXoa.Location = new Point(617, 589);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 39);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Microsoft Sans Serif", 12F);
            btnThoat.Location = new Point(816, 589);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 39);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(375, 9);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Loại Hàng";
            // 
            // GUI_QLLoaiHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 763);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnMoi);
            Controls.Add(dgvLoaiHang);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "GUI_QLLoaiHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GUI_QLLoaiHang";
            Load += GUI_QLLoaiHang_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiHang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox2;
        private DataGridView dgvLoaiHang;
        private TextBox txtMoTa;
        private Label label3;
        private Label label2;
        private TextBox txtMaLH;
        private Label label4;
        private TextBox txtTenLH;
        private GroupBox groupBox1;
        private Button btnTimKiem;
        private TextBox txtTenLHTimKiem;
        private TextBox txtMaLHTimKiem;
        private Label label6;
        private Label label5;
        private Button btnMoi;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private Label label1;
    }
}