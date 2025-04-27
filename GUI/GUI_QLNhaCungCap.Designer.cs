namespace GUI
{
    partial class GUI_QLNhaCungCap
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
            btnThoat = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnMoi = new Button();
            groupBox1 = new GroupBox();
            txtSoDienThoai = new TextBox();
            label7 = new Label();
            txtTenNCC = new TextBox();
            label4 = new Label();
            txtMaNCC = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtDiaChi = new TextBox();
            dgvNhaCungCap = new DataGridView();
            btnTimKiem = new Button();
            txtTenNCCTimKiem = new TextBox();
            txtMaNCCTimKiem = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnXoa = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Microsoft Sans Serif", 12F);
            btnThoat.Location = new Point(832, 553);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 39);
            btnThoat.TabIndex = 23;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Microsoft Sans Serif", 12F);
            btnSua.Location = new Point(434, 553);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 39);
            btnSua.TabIndex = 21;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Microsoft Sans Serif", 12F);
            btnThem.Location = new Point(235, 553);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 39);
            btnThem.TabIndex = 20;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnMoi
            // 
            btnMoi.Font = new Font("Microsoft Sans Serif", 12F);
            btnMoi.Location = new Point(36, 553);
            btnMoi.Name = "btnMoi";
            btnMoi.Size = new Size(94, 39);
            btnMoi.TabIndex = 19;
            btnMoi.Text = "Mới";
            btnMoi.UseVisualStyleBackColor = true;
            btnMoi.Click += btnMoi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSoDienThoai);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTenNCC);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaNCC);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(28, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(896, 188);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Microsoft Sans Serif", 12F);
            txtSoDienThoai.Location = new Point(615, 136);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(262, 30);
            txtSoDienThoai.TabIndex = 8;
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
            // txtTenNCC
            // 
            txtTenNCC.Font = new Font("Microsoft Sans Serif", 12F);
            txtTenNCC.Location = new Point(615, 52);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(262, 30);
            txtTenNCC.TabIndex = 6;
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
            // txtMaNCC
            // 
            txtMaNCC.Font = new Font("Microsoft Sans Serif", 12F);
            txtMaNCC.Location = new Point(146, 54);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(262, 30);
            txtMaNCC.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(14, 54);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 1;
            label2.Text = "Mã NCC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(451, 57);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 2;
            label3.Text = "Tên NCC";
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
            // dgvNhaCungCap
            // 
            dgvNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaCungCap.Location = new Point(28, 232);
            dgvNhaCungCap.Name = "dgvNhaCungCap";
            dgvNhaCungCap.RowHeadersWidth = 51;
            dgvNhaCungCap.Size = new Size(896, 274);
            dgvNhaCungCap.TabIndex = 18;
            dgvNhaCungCap.CellClick += dgvNhaCungCap_CellClick;
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
            // txtTenNCCTimKiem
            // 
            txtTenNCCTimKiem.Font = new Font("Microsoft Sans Serif", 12F);
            txtTenNCCTimKiem.Location = new Point(495, 40);
            txtTenNCCTimKiem.Name = "txtTenNCCTimKiem";
            txtTenNCCTimKiem.Size = new Size(225, 30);
            txtTenNCCTimKiem.TabIndex = 3;
            // 
            // txtMaNCCTimKiem
            // 
            txtMaNCCTimKiem.Font = new Font("Microsoft Sans Serif", 12F);
            txtMaNCCTimKiem.Location = new Point(151, 44);
            txtMaNCCTimKiem.Name = "txtMaNCCTimKiem";
            txtMaNCCTimKiem.Size = new Size(169, 30);
            txtMaNCCTimKiem.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(335, 47);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 1;
            label6.Text = "Tên NCC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(10, 47);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 0;
            label5.Text = "Mã NCC";
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Microsoft Sans Serif", 12F);
            btnXoa.Location = new Point(633, 553);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 39);
            btnXoa.TabIndex = 22;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTenNCCTimKiem);
            groupBox2.Controls.Add(txtMaNCCTimKiem);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(32, 631);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(902, 83);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(310, -145);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 15;
            label1.Text = "Quản Lý Loại Hàng";
            // 
            // GUI_QLNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 721);
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnMoi);
            Controls.Add(groupBox1);
            Controls.Add(dgvNhaCungCap);
            Controls.Add(btnXoa);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Name = "GUI_QLNhaCungCap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GUI_QLNhaCungCap";
            Load += GUI_QLNhaCungCap_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private Button btnSua;
        private Button btnThem;
        private Button btnMoi;
        private GroupBox groupBox1;
        private TextBox txtTenNCC;
        private Label label4;
        private TextBox txtMaNCC;
        private Label label2;
        private Label label3;
        private TextBox txtDiaChi;
        private DataGridView dgvNhaCungCap;
        private Button btnTimKiem;
        private TextBox txtTenNCCTimKiem;
        private TextBox txtMaNCCTimKiem;
        private Label label6;
        private Label label5;
        private Button btnXoa;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox txtSoDienThoai;
        private Label label7;
    }
}