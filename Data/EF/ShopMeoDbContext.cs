using Domain.Confi;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EF
{
    public class ShopMeoDbContext : DbContext
    {
        public ShopMeoDbContext(DbContextOptions<ShopMeoDbContext> opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DanhMucConfi());
            modelBuilder.ApplyConfiguration(new QuyenConfi());
            modelBuilder.ApplyConfiguration(new SanPhamConfi());
            modelBuilder.ApplyConfiguration(new SanPhamDanhMucConfi());
            modelBuilder.ApplyConfiguration(new TaiKhoanConfi());     
            modelBuilder.ApplyConfiguration(new UserRolesConfi());
            // base.OnModelCreating(modelBuilder);
        }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
    }
}
