using ShopMeoSolution.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMeoSolution.Domain.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public Guid IdUser { get; set; }
        public string TenNguoiNhan { get; set; } = string.Empty;
        public string DiaChiNhan { get; set; } = string.Empty;
        public string SDTNhan { get; set; } = string.Empty;
        public TrangThaiOrder TrangThaiOrder { get; set; }
        public UserIdentity? UserIdentity { get; set; }
        public string EmailNhan { get; set; } = string.Empty;
        public DateTime NgayOrder { get; set; }
    }
}
