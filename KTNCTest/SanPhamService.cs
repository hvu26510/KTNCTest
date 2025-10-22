using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTNCTest
{
    public class SanPhamService
    {
        private List<SanPham> sanPhamList = new();

        public SanPhamService()
        {
            sanPhamList.Add(new SanPham() { Ma = "Ma01", Gia = 100, Ten = "San pham 1", SoLuong = 10, DanhMuc="Hang hoa", namBaoHanh = 2026 }); 
        }

        public SanPham? GetByMa(string ma) => sanPhamList.FirstOrDefault(sp=> sp.Ma == ma);

        public bool Sua(SanPham sanPham)
        {
            if (sanPham == null || string.IsNullOrWhiteSpace(sanPham.Ma)) return false;

            var exists = sanPhamList.FirstOrDefault(x => x.Ma == sanPham.Ma);
            if (exists == null) return false;

            if (sanPham.Gia < 0) return false;

            exists.Ten = sanPham.Ten;
            exists.namBaoHanh = sanPham.namBaoHanh;
            exists.Gia = sanPham.Gia;
            exists.DanhMuc = sanPham.DanhMuc;
            exists.SoLuong = sanPham.SoLuong;

            return true;
        }

    }
}
