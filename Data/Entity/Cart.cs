using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Cart
    {
        public int Id { get; set; }
        public int IdSanPham { get; set; } 
        public int SoLuong { get;set; }
        public double Gia { get;set; }
        public DateTime NgayTao { get;set; }
        public SanPham SanPham { get; set; }
        public Guid IdUser { get; set; }
        public UserIdentity UserIdentity { get; set; }
    }
}
