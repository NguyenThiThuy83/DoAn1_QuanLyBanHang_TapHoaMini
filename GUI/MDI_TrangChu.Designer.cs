namespace GUI
{
    partial class MDI_TrangChu
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
            menuStrip1 = new MenuStrip();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            quảnLýLoạiHàngToolStripMenuItem = new ToolStripMenuItem();
            quảnLýNhàCungCấpToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            quảnLýSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            báoCáoThốngKêToolStripMenuItem = new ToolStripMenuItem();
            quảnTrịHệThốngToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Microsoft Sans Serif", 12F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýToolStripMenuItem, báoCáoThốngKêToolStripMenuItem, quảnTrịHệThốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(964, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýLoạiHàngToolStripMenuItem, quảnLýNhàCungCấpToolStripMenuItem, quảnLýKháchHàngToolStripMenuItem, quảnLýSảnPhẩmToolStripMenuItem });
            quảnLýToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F);
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(221, 29);
            quảnLýToolStripMenuItem.Text = "Quản lý các danh mục";
            // 
            // quảnLýLoạiHàngToolStripMenuItem
            // 
            quảnLýLoạiHàngToolStripMenuItem.Name = "quảnLýLoạiHàngToolStripMenuItem";
            quảnLýLoạiHàngToolStripMenuItem.Size = new Size(289, 30);
            quảnLýLoạiHàngToolStripMenuItem.Text = "Quản lý loại hàng";
            quảnLýLoạiHàngToolStripMenuItem.Click += quảnLýLoạiHàngToolStripMenuItem_Click;
            // 
            // quảnLýNhàCungCấpToolStripMenuItem
            // 
            quảnLýNhàCungCấpToolStripMenuItem.Name = "quảnLýNhàCungCấpToolStripMenuItem";
            quảnLýNhàCungCấpToolStripMenuItem.Size = new Size(289, 30);
            quảnLýNhàCungCấpToolStripMenuItem.Text = "Quản lý nhà cung cấp";
            quảnLýNhàCungCấpToolStripMenuItem.Click += quảnLýNhàCungCấpToolStripMenuItem_Click;
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            quảnLýKháchHàngToolStripMenuItem.Size = new Size(289, 30);
            quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            quảnLýKháchHàngToolStripMenuItem.Click += quảnLýKháchHàngToolStripMenuItem_Click;
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            quảnLýSảnPhẩmToolStripMenuItem.Size = new Size(289, 30);
            quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            quảnLýSảnPhẩmToolStripMenuItem.Click += quảnLýSảnPhẩmToolStripMenuItem_Click;
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            báoCáoThốngKêToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F);
            báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            báoCáoThốngKêToolStripMenuItem.Size = new Size(178, 29);
            báoCáoThốngKêToolStripMenuItem.Text = "Báo cáo thống kê";
            // 
            // quảnTrịHệThốngToolStripMenuItem
            // 
            quảnTrịHệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đổiMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem });
            quảnTrịHệThốngToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F);
            quảnTrịHệThốngToolStripMenuItem.Name = "quảnTrịHệThốngToolStripMenuItem";
            quảnTrịHệThốngToolStripMenuItem.Size = new Size(176, 29);
            quảnTrịHệThốngToolStripMenuItem.Text = "Quản trị hệ thống";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F);
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(212, 30);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F);
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(212, 30);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // MDI_TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 531);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MDI_TrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MDI_TrangChu";
            Load += MDI_TrangChu_Load;
            Resize += MDI_TrangChu_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private ToolStripMenuItem quảnTrịHệThốngToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem quảnLýLoạiHàngToolStripMenuItem;
        private ToolStripMenuItem quảnLýNhàCungCấpToolStripMenuItem;
        private ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
    }
}