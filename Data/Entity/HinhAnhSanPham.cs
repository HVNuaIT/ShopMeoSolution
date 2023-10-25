using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMeoSolution.Domain.Entity
{
    public class HinhAnhSanPham
    {
        public int Id { get; set; }
        public int IdSanPham { get; set; }
        public DateTime NgayTao { get; set; }
        public SanPham? SanPham { get; set; }
        public string DuongDanImg { get; set; }
        public long KichThuc { get; set; }


    }
}
