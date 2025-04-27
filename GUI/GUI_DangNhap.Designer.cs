namespace GUI
{
    partial class GUI_DangNhap
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
            groupBox1 = new GroupBox();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            btnThoat = new Button();
            btnDangNhap = new Button();
            chkHien = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTaiKhoan);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnDangNhap);
            groupBox1.Controls.Add(chkHien);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(161, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 321);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đăng nhập";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Microsoft Sans Serif", 12F);
            txtMatKhau.ForeColor = Color.Black;
            txtMatKhau.Location = new Point(206, 102);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(261, 30);
            txtMatKhau.TabIndex = 6;
            txtMatKhau.Validating += txtMatKhau_Validating;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Font = new Font("Microsoft Sans Serif", 12F);
            txtTaiKhoan.ForeColor = Color.Black;
            txtTaiKhoan.Location = new Point(206, 44);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(261, 30);
            txtTaiKhoan.TabIndex = 5;
            txtTaiKhoan.Validating += txtTaiKhoan_Validating;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Microsoft Sans Serif", 12F);
            btnThoat.ForeColor = Color.Black;
            btnThoat.Location = new Point(320, 266);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(190, 49);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Microsoft Sans Serif", 12F);
            btnDangNhap.ForeColor = Color.Black;
            btnDangNhap.Location = new Point(6, 266);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(190, 49);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // chkHien
            // 
            chkHien.AutoSize = true;
            chkHien.Font = new Font("Microsoft Sans Serif", 12F);
            chkHien.ForeColor = Color.Black;
            chkHien.Location = new Point(206, 148);
            chkHien.Name = "chkHien";
            chkHien.Size = new Size(184, 29);
            chkHien.TabIndex = 2;
            chkHien.Text = "Hiển thị mật khẩu";
            chkHien.UseVisualStyleBackColor = true;
            chkHien.CheckedChanged += chkHien_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(54, 109);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(54, 51);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(145, 32);
            label3.Name = "label3";
            label3.Size = new Size(536, 25);
            label3.TabIndex = 2;
            label3.Text = "Đăng nhập hệ thống quản lý cửa hàng tạp hóa mini BA";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // GUI_DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "GUI_DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GUI_DangNhap";
            Load += GUI_DangNhap_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private GroupBox groupBox1;
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private Button btnThoat;
        private Button btnDangNhap;
        private CheckBox chkHien;
        private Label label2;
        private Label label1;
        private Label label3;
        private ErrorProvider errorProvider1;
    }
}