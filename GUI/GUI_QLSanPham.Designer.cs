namespace GUI
{
    partial class GUI_QLSanPham
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
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            label2 = new Label();
            label3 = new Label();
            btnTimKiem = new Button();
            txtTenSPTimKiem = new TextBox();
            txtMaSP = new TextBox();
            btnXoa = new Button();
            label7 = new Label();
            txtTenSP = new TextBox();
            btnThoat = new Button();
            txtDonGiaNhap = new TextBox();
            label5 = new Label();
            btnSua = new Button();
            btnThem = new Button();
            btnMoi = new Button();
            groupBox1 = new GroupBox();
            txtMoTa = new TextBox();
            label11 = new Label();
            txtSoLuong = new TextBox();
            label10 = new Label();
            txtDonGiaBan = new TextBox();
            label8 = new Label();
            label4 = new Label();
            cboLoaiHang = new ComboBox();
            label9 = new Label();
            btnChonAnh = new Button();
            picAnhSP = new PictureBox();
            txtMaSPTimKiem = new TextBox();
            label6 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvSanPham = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhSP).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.Location = new Point(14, 45);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 1;
            label2.Text = "Mã SP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.Location = new Point(14, 99);
            label3.Name = "label3";
            label3.Size = new Size(102, 18);
            label3.TabIndex = 2;
            label3.Text = "Tên sản phẩm";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 12F);
            btnTimKiem.Location = new Point(923, 33);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(141, 37);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTenSPTimKiem
            // 
            txtTenSPTimKiem.Font = new Font("Microsoft Sans Serif", 12F);
            txtTenSPTimKiem.Location = new Point(512, 40);
            txtTenSPTimKiem.Name = "txtTenSPTimKiem";
            txtTenSPTimKiem.Size = new Size(371, 30);
            txtTenSPTimKiem.TabIndex = 3;
            // 
            // txtMaSP
            // 
            txtMaSP.Font = new Font("Microsoft Sans Serif", 9F);
            txtMaSP.Location = new Point(146, 39);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(305, 24);
            txtMaSP.TabIndex = 4;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Microsoft Sans Serif", 12F);
            btnXoa.Location = new Point(668, 609);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 39);
            btnXoa.TabIndex = 40;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F);
            label7.Location = new Point(477, 48);
            label7.Name = "label7";
            label7.Size = new Size(95, 18);
            label7.TabIndex = 7;
            label7.Text = "Đơn giá nhập";
            // 
            // txtTenSP
            // 
            txtTenSP.Font = new Font("Microsoft Sans Serif", 9F);
            txtTenSP.Location = new Point(146, 93);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(305, 24);
            txtTenSP.TabIndex = 6;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Microsoft Sans Serif", 12F);
            btnThoat.Location = new Point(867, 609);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 39);
            btnThoat.TabIndex = 41;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtDonGiaNhap
            // 
            txtDonGiaNhap.Font = new Font("Microsoft Sans Serif", 9F);
            txtDonGiaNhap.Location = new Point(603, 42);
            txtDonGiaNhap.Name = "txtDonGiaNhap";
            txtDonGiaNhap.Size = new Size(262, 24);
            txtDonGiaNhap.TabIndex = 8;
            txtDonGiaNhap.KeyPress += txtDonGiaNhap_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(10, 47);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 0;
            label5.Text = "Mã SP";
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Microsoft Sans Serif", 12F);
            btnSua.Location = new Point(469, 609);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 39);
            btnSua.TabIndex = 39;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Microsoft Sans Serif", 12F);
            btnThem.Location = new Point(270, 609);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 39);
            btnThem.TabIndex = 38;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnMoi
            // 
            btnMoi.Font = new Font("Microsoft Sans Serif", 12F);
            btnMoi.Location = new Point(71, 609);
            btnMoi.Name = "btnMoi";
            btnMoi.Size = new Size(94, 39);
            btnMoi.TabIndex = 37;
            btnMoi.Text = "Mới";
            btnMoi.UseVisualStyleBackColor = true;
            btnMoi.Click += btnMoi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtDonGiaBan);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboLoaiHang);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnChonAnh);
            groupBox1.Controls.Add(picAnhSP);
            groupBox1.Controls.Add(txtDonGiaNhap);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTenSP);
            groupBox1.Controls.Add(txtMaSP);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1086, 268);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(143, 203);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(722, 59);
            txtMoTa.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 207);
            label11.Name = "label11";
            label11.Size = new Size(46, 18);
            label11.TabIndex = 20;
            label11.Text = "Mô tả";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Microsoft Sans Serif", 9F);
            txtSoLuong.Location = new Point(603, 151);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(262, 24);
            txtSoLuong.TabIndex = 19;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F);
            label10.Location = new Point(477, 154);
            label10.Name = "label10";
            label10.Size = new Size(67, 18);
            label10.TabIndex = 18;
            label10.Text = "Số lượng";
            // 
            // txtDonGiaBan
            // 
            txtDonGiaBan.Font = new Font("Microsoft Sans Serif", 9F);
            txtDonGiaBan.Location = new Point(603, 99);
            txtDonGiaBan.Name = "txtDonGiaBan";
            txtDonGiaBan.Size = new Size(262, 24);
            txtDonGiaBan.TabIndex = 17;
            txtDonGiaBan.KeyPress += txtDonGiaBan_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F);
            label8.Location = new Point(477, 102);
            label8.Name = "label8";
            label8.Size = new Size(87, 18);
            label8.TabIndex = 16;
            label8.Text = "Đơn giá bán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 151);
            label4.Name = "label4";
            label4.Size = new Size(72, 18);
            label4.TabIndex = 15;
            label4.Text = "Loại hàng";
            // 
            // cboLoaiHang
            // 
            cboLoaiHang.FormattingEnabled = true;
            cboLoaiHang.Location = new Point(146, 143);
            cboLoaiHang.Name = "cboLoaiHang";
            cboLoaiHang.Size = new Size(305, 26);
            cboLoaiHang.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(925, 225);
            label9.Name = "label9";
            label9.Size = new Size(33, 18);
            label9.TabIndex = 13;
            label9.Text = "Ảnh";
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(971, 220);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(94, 29);
            btnChonAnh.TabIndex = 12;
            btnChonAnh.Text = "Chọn";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // picAnhSP
            // 
            picAnhSP.Location = new Point(923, 39);
            picAnhSP.Name = "picAnhSP";
            picAnhSP.Size = new Size(142, 163);
            picAnhSP.TabIndex = 11;
            picAnhSP.TabStop = false;
            // 
            // txtMaSPTimKiem
            // 
            txtMaSPTimKiem.Font = new Font("Microsoft Sans Serif", 12F);
            txtMaSPTimKiem.Location = new Point(151, 44);
            txtMaSPTimKiem.Name = "txtMaSPTimKiem";
            txtMaSPTimKiem.Size = new Size(169, 30);
            txtMaSPTimKiem.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(335, 47);
            label6.Name = "label6";
            label6.Size = new Size(138, 25);
            label6.TabIndex = 1;
            label6.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(352, -84);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 33;
            label1.Text = "Quản Lý Loại Hàng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTenSPTimKiem);
            groupBox2.Controls.Add(txtMaSPTimKiem);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 680);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1086, 83);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(12, 298);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.Size = new Size(1086, 274);
            dgvSanPham.TabIndex = 36;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // GUI_QLSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 794);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnMoi);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(dgvSanPham);
            Name = "GUI_QLSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GUI_QLSanPham";
            Load += GUI_QLSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhSP).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnSua;
        private Button btnThem;
        private Button btnMoi;
        private GroupBox groupBox1;
        private TextBox txtDonGiaNhap;
        private Label label7;
        private TextBox txtTenSP;
        private TextBox txtMaSP;
        private Label label2;
        private Label label3;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnTimKiem;
        private TextBox txtTenSPTimKiem;
        private TextBox txtMaSPTimKiem;
        private Label label6;
        private Label label5;
        private DataGridView dgvSanPham;
        private Label label9;
        private Button btnChonAnh;
        private PictureBox picAnhSP;
        private Label label4;
        private ComboBox cboLoaiHang;
        private TextBox txtMoTa;
        private Label label11;
        private TextBox txtSoLuong;
        private Label label10;
        private TextBox txtDonGiaBan;
        private Label label8;
    }
}