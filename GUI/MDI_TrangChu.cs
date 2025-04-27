using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MDI_TrangChu : Form
    {
        public MDI_TrangChu()
        {
            InitializeComponent();
        }

        private void MDI_TrangChu_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"C:\Users\Thinkpad T480s\Documents\Zalo Received Files\Quản lý cửa hàng tạp hóa mini BA\Quản lý cửa hàng tạp hóa mini BA\DoAn1_QuanLyBanHang_TapHoaMini\GUI\Assets\taphoabg.jpg");
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_DoiMatKhau a = new GUI_DoiMatKhau();
            a.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            GUI_DangNhap a = new GUI_DangNhap();
            a.ShowDialog();
        }

        private void quảnLýLoạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_QLLoaiHang a = new GUI_QLLoaiHang();
            a.ShowDialog();
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_QLNhaCungCap a = new GUI_QLNhaCungCap();
            a.ShowDialog();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_QLKhachHang a = new GUI_QLKhachHang();
            a.ShowDialog();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_QLSanPham a = new GUI_QLSanPham();
            a.ShowDialog();
        }

        private void MDI_TrangChu_Resize(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.None;
            this.BackgroundImage = Image.FromFile(@"C:\Users\Thinkpad T480s\Documents\Zalo Received Files\Quản lý cửa hàng tạp hóa mini BA\Quản lý cửa hàng tạp hóa mini BA\DoAn1_QuanLyBanHang_TapHoaMini\GUI\Assets\taphoabg.jpg");
            // Lấy kích thước hiện tại của Form
            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;

            // Vẽ lại hình ảnh để phù hợp với kích thước Form
            Bitmap bitmap = new Bitmap(this.BackgroundImage, width, height);
            this.BackgroundImage = bitmap;
        }
    }
}
