using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using DAL;
using BLL;
using DTO;

namespace TestProject1
{
    [TestFixture]
    public class UnitTestLoaiHang
    {
        private Mock<DAL_LoaiHang> mockDal;
        private BLL_LoaiHang bllLoaiHang;

        [SetUp]
        public void Setup()
        {
            // Tạo mock object cho DAL_LoaiHang
            mockDal = new Mock<DAL_LoaiHang>();
            // Tạo BLL_LoaiHang với mock DAL
            bllLoaiHang = new BLL_LoaiHang(mockDal.Object);
        }

        [Test]
        public void ThemLoaiHang_ReturnsTrue_WhenThemThanhCong()
        {
            // Arrange
            var loaiHang = new DTO_LoaiHang("LH01", "Loại 1", "Mô tả loại 1");
            mockDal.Setup(dal => dal.ThemLoaiHang(loaiHang)).Returns(true);

            // Act
            var result = bllLoaiHang.ThemLoaiHang(loaiHang);

            // Assert
            Assert.IsTrue(result);
            mockDal.Verify(dal => dal.ThemLoaiHang(loaiHang), Times.Once);
        }
    }
}
