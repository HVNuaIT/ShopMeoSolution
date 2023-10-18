using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{

    public class SanPham
    {

        public int Id { get; set; }
        public string TenSanPham { get; set; } = string.Empty;
        public int SoLuong { get; set; }
        public double Gia { get; set; }
        public string Hinh { get; set; } = string.Empty;
        public byte[]? File { get; set; }
        public string MoTa { get; set; } = string.Empty;
        public TrangThai TrangThai { get; set; }
        public int IdDanhMuc { get; set; }
        public DanhMuc ?DanhMuc { get; set;}
        public List<Cart>? Carts { get; set; }
        

    }
}
