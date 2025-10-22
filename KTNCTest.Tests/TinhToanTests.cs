using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTNCTest.Tests
{
    [TestFixture]
    internal class TinhToanTests
    {
        TinhToan t = null;

        [SetUp]
        public void Setup() => t = new TinhToan();
        // Phân vùng <0; 0-10; >10

        [Test] // cận biên -1, âm - lẻ
        public void Am_Le() => Assert.IsFalse(t.LaSoChan(-1));

        [Test] // biên 0, 0 - chẵn
        public void So0_Chan() => Assert.IsTrue(t.LaSoChan(0));
        [Test] // biên 10, chẵn
        public void Duong10_Chan() => Assert.IsTrue(t.LaSoChan(10));
        [Test] // cận biên 1,  lẻ
        public void Duong_Le() => Assert.IsFalse(t.LaSoChan(1));
        [Test] // 11, >10 - chan
        public void So11_le() => Assert.IsFalse(t.LaSoChan(11));


    }
}
