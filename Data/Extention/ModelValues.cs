using Microsoft.EntityFrameworkCore;
using ShopMeoSolution.Domain.Entity;
using ShopMeoSolution.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMeoSolution.Domain.Extention
{
    public static class ModelValues
    {
        public static void Seed(this ModelBuilder modelValues)
        {
            modelValues.Entity<DanhMuc>().HasData(
                new DanhMuc() { Id = 1, TenDanhMuc = "Meo Itali", TrangThai = TrangThai.Active, });
            modelValues.Entity<SanPham>().HasData(new SanPham()
            {
                Id = 1,
                TenSanPham = "Meo 1 ",
                SoLuong = 120,
                MoTa = "Dep va giong hiem",
                IdDanhMuc = 1,
                TrangThai = TrangThai.Active,
                Gia = 200000,

            });
        }
    }
}
