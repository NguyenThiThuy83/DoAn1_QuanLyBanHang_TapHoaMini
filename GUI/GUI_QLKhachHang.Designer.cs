namespace GUI
{
    partial class GUI_QLKhachHang
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
            btnXoa = new Button();
            label1 = new Label();
            txtMaKHTimKiem = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtSoDienThoai = new TextBox();
            label7 = new Label();
            txtTenKH = new TextBox();
            label4 = new Label();
            txtMaKH = new TextBox();
            btnTimKiem = new Button();
            txtTenKHTimKiem = new TextBox();
            dgvKhachHang = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            btnSua = new Button();
            btnThem = new Button();
            btnMoi = new Button();
            groupBox1 = new GroupBox();
            txtGmail = new TextBox();
            label8 = new Label();
            txtDiaChi = new TextBox();
            groupBox2 = new GroupBox();
            btnThoat = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Microsoft Sans Serif", 12F);
            btnXoa.Location = new Point(620, 586);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 39);
            btnXoa.TabIndex = 31;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(297, -150);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 24;
            label1.Text = "Quản Lý Loại Hàng";
            // 
            // txtMaKHTimKiem
            // 
            txtMaKHTimKiem.Font = new Font("Microsoft Sans Serif", 12F);
            txtMaKHTimKiem.Location = new Point(151, 44);
            txtMaKHTimKiem.Name = "txtMaKHTimKiem";
            txtMaKHTimKiem.Size = new Size(169, 30);
            txtMaKHTimKiem.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(335, 47);
            label6.Name = "label6";
            label6.Size = new Size(154, 25);
            label6.TabIndex = 1;
            label6.Text = "Tên khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(10, 47);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 0;
            label5.Text = "Mã KH";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Microsoft Sans Serif", 12F);
            txtSoDienThoai.Location = new Point(615, 136);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(262, 30);
            txtSoDienThoai.TabIndex = 8;
            txtSoDienThoai.KeyPress += txtSoDienThoai_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(451, 141);
            label7.Name = "label7";
            label7.Size = new Size(126, 25);
            label7.TabIndex = 7;
            label7.Text = "Số điện thoại";
            // 
            // txtTenKH
            // 
            txtTenKH.Font = new Font("Microsoft Sans Serif", 12F);
            txtTenKH.Location = new Point(615, 52);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(262, 30);
            txtTenKH.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(14, 122);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ";
            // 
            // txtMaKH
            // 
            txtMaKH.Font = new Font("Microsoft Sans Serif", 12F);
            txtMaKH.Location = new Point(146, 54);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(262, 30);
            txtMaKH.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Microsoft Sans Serif", 12F);
            btnTimKiem.Location = new Point(755, 40);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(141, 37);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTenKHTimKiem
            // 
            txtTenKHTimKiem.Font = new Font("Microsoft Sans Serif", 12F);
            txtTenKHTimKiem.Location = new Point(512, 40);
            txtTenKHTimKiem.Name = "txtTenKHTimKiem";
            txtTenKHTimKiem.Size = new Size(225, 30);
            txtTenKHTimKiem.TabIndex = 3;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(15, 265);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(896, 274);
            dgvKhachHang.TabIndex = 27;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(14, 54);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 1;
            label2.Text = "Mã KH";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(451, 57);
            label3.Name = "label3";
            label3.Size = new Size(154, 25);
            label3.TabIndex = 2;
            label3.Text = "Tên khách hàng";
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Microsoft Sans Serif", 12F);
            btnSua.Location = new Point(421, 586);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 39);
            btnSua.TabIndex = 30;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Microsoft Sans Serif", 12F);
            btnThem.Location = new Point(222, 586);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 39);
            btnThem.TabIndex = 29;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnMoi
            // 
            btnMoi.Font = new Font("Microsoft Sans Serif", 12F);
            btnMoi.Location = new Point(23, 586);
            btnMoi.Name = "btnMoi";
            btnMoi.Size = new Size(94, 39);
            btnMoi.TabIndex = 28;
            btnMoi.Text = "Mới";
            btnMoi.UseVisualStyleBackColor = true;
            btnMoi.Click += btnMoi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGmail);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtSoDienThoai);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTenKH);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(15, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(896, 240);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtGmail
            // 
            txtGmail.Font = new Font("Microsoft Sans Serif", 12F);
            txtGmail.Location = new Point(146, 193);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(445, 30);
            txtGmail.TabIndex = 10;
            txtGmail.Leave += txtGmail_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(9, 198);
            label8.Name = "label8";
            label8.Size = new Size(62, 25);
            label8.TabIndex = 9;
            label8.Text = "Gmail";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Microsoft Sans Serif", 12F);
            txtDiaChi.Location = new Point(146, 104);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(262, 62);
            txtDiaChi.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTenKHTimKiem);
            groupBox2.Controls.Add(txtMaKHTimKiem);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(19, 664);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(902, 83);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Microsoft Sans Serif", 12F);
            btnThoat.Location = new Point(819, 586);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 39);
            btnThoat.TabIndex = 32;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // GUI_QLKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 753);
            Controls.Add(btnXoa);
            Controls.Add(label1);
            Controls.Add(dgvKhachHang);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnMoi);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(btnThoat);
            Name = "GUI_QLKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GUI_QLKhachHang";
            Load += GUI_KhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnXoa;
        private Label label1;
        private TextBox txtMaKHTimKiem;
        private Label label6;
        private Label label5;
        private TextBox txtSoDienThoai;
        private Label label7;
        private TextBox txtTenKH;
        private Label label4;
        private TextBox txtMaKH;
        private Button btnTimKiem;
        private TextBox txtTenKHTimKiem;
        private DataGridView dgvKhachHang;
        private Label label2;
        private Label label3;
        private Button btnSua;
        private Button btnThem;
        private Button btnMoi;
        private GroupBox groupBox1;
        private TextBox txtDiaChi;
        private GroupBox groupBox2;
        private Button btnThoat;
        private TextBox txtGmail;
        private Label label8;
        private ErrorProvider errorProvider1;
    }
}