using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMeoSolution.Domain.Entity
{
    public class SanPhamDanhMuc
    {
        public int IdSanPham { get; set; }
        public SanPham SanPham { get; set; }
        public int IdDanhMuc { get; set; }
        public DanhMuc DanhMuc { get; set; }
    }
}
