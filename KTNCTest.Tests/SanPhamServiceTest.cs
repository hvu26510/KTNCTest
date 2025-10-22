using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTNCTest.Tests
{
    [TestFixture]
    public class SanPhamServiceTest
    {
        SanPhamService t = null;

        [SetUp]
        public void Setup() => t = new SanPhamService();

        //Phan vung gia: Gia <=0; 0< Gia < 10; Gia >10
        // Test Ma ton tai

        [Test]
        public void Sua_Fail_GiaAm()
        {
            var sp = new SanPham()
            {
                Ma = "Ma01",
                Gia = -100,
                Ten = "San pham 1",
                SoLuong = 10,
                DanhMuc = "Hang hoa",
                namBaoHanh = 2026
            };
            Assert.IsFalse(t.Sua(sp));
        }

        [Test]
        public void Sua_ThanhCong_Gia11()
        {
            var sp = new SanPham()
            {
                Ma = "Ma01",
                Gia = 11,
                Ten = "San pham 1",
                SoLuong = 10,
                DanhMuc = "Hang hoa",
                namBaoHanh = 2026
            };
            Assert.IsTrue(t.Sua(sp));
            var after = t.GetByMa("Ma01");
            Assert.That(after.Gia, Is.EqualTo(11));
        }

        [Test]
        public void Sua_TC_Gia0()
        {
            var sp = new SanPham()
            {
                Ma = "Ma01",
                Gia = 0,
                Ten = "San pham 1",
                SoLuong = 10,
                DanhMuc = "Hang hoa",
                namBaoHanh = 2026
            };
            Assert.IsTrue(t.Sua(sp));
            var after = t.GetByMa("Ma01");
            Assert.That(after.Gia, Is.EqualTo(0));
        }

    }
}
