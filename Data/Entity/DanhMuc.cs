using Domain.Enum;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{

    public class DanhMuc
    {
        public int Id { get; set; }
        public string TenDanhMuc { get; set; } = string.Empty;
        public TrangThai TrangThai { get; set; }
        public List<SanPham>? SanPhams { get; set; }  
       // public List<SanPhamDanhMuc> SanPhamDanhMuc { get; set; }
    }
}
