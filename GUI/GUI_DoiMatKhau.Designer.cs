namespace GUI
{
    partial class GUI_DoiMatKhau
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnDoiMatKhau = new Button();
            btnThoat = new Button();
            chkHien = new CheckBox();
            txtTaiKhoan = new TextBox();
            txtMatKhauCu = new TextBox();
            txtMatKhauMoi = new TextBox();
            txtNhapLaiMatKhau = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(331, 26);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 0;
            label1.Text = "Đổi mật khẩu";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(90, 258);
            label2.Name = "label2";
            label2.Size = new Size(168, 25);
            label2.TabIndex = 1;
            label2.Text = "Nhập lại mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(90, 85);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 2;
            label3.Text = "Tên tài khoản";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(90, 201);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(90, 147);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 4;
            label5.Text = "Mật khẩu cũ";
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.Font = new Font("Microsoft Sans Serif", 12F);
            btnDoiMatKhau.Location = new Point(153, 373);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(177, 47);
            btnDoiMatKhau.TabIndex = 5;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = true;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Microsoft Sans Serif", 12F);
            btnThoat.Location = new Point(476, 373);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(106, 47);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // chkHien
            // 
            chkHien.AutoSize = true;
            chkHien.Font = new Font("Microsoft Sans Serif", 12F);
            chkHien.Location = new Point(317, 302);
            chkHien.Name = "chkHien";
            chkHien.Size = new Size(184, 29);
            chkHien.TabIndex = 7;
            chkHien.Text = "Hiển thị mật khẩu";
            chkHien.UseVisualStyleBackColor = true;
            chkHien.CheckedChanged += chkHien_CheckedChanged;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Font = new Font("Microsoft Sans Serif", 12F);
            txtTaiKhoan.Location = new Point(317, 85);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(298, 30);
            txtTaiKhoan.TabIndex = 8;
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Font = new Font("Microsoft Sans Serif", 12F);
            txtMatKhauCu.Location = new Point(317, 144);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new Size(298, 30);
            txtMatKhauCu.TabIndex = 9;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Font = new Font("Microsoft Sans Serif", 12F);
            txtMatKhauMoi.Location = new Point(317, 196);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(298, 30);
            txtMatKhauMoi.TabIndex = 10;
            // 
            // txtNhapLaiMatKhau
            // 
            txtNhapLaiMatKhau.Font = new Font("Microsoft Sans Serif", 12F);
            txtNhapLaiMatKhau.Location = new Point(317, 248);
            txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            txtNhapLaiMatKhau.Size = new Size(298, 30);
            txtNhapLaiMatKhau.TabIndex = 11;
            // 
            // GUI_DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNhapLaiMatKhau);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(txtMatKhauCu);
            Controls.Add(txtTaiKhoan);
            Controls.Add(chkHien);
            Controls.Add(btnThoat);
            Controls.Add(btnDoiMatKhau);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GUI_DoiMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GUI_DoiMatKhau";
            Load += GUI_DoiMatKhau_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnDoiMatKhau;
        private Button btnThoat;
        private CheckBox chkHien;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhauCu;
        private TextBox txtMatKhauMoi;
        private TextBox txtNhapLaiMatKhau;
    }
}