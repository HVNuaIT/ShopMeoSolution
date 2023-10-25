using Microsoft.AspNetCore.Http;
using ShopMeoSolution.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMeoSolution.ViewModel.Catalog.SanPham.Admin
{
    public class CreateProduct
    {
        public string TenSanPham { get; set; } = string.Empty;
        public int SoLuong { get; set; }
        public double Gia { get; set; }
        public string MoTa { get; set; } = string.Empty;
        public TrangThai TrangThai { get; set; }
        public int IdDanhMuc { get; set; }
        public IFormFile ? HinhAnh { get; set; }
    }
}
