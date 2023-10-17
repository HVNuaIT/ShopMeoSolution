using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class TaiKhoan
    {
        public int Id { get; set; }
        public string TenNguoiDung { get; set; } = string.Empty;
        public string DiaChi { get; set; } = string.Empty;
        public string SoDienThoai { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string MatKhau { get; set; } = string.Empty;
        public TrangThai TrangThai { get; set; }
        public virtual ICollection<UserRoles>? UserRoles { get; set; }
    }
}
