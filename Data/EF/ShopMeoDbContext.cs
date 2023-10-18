using Domain.Confi;
using Domain.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EF
{
    public class ShopMeoDbContext : IdentityDbContext<UserIdentity,RoleIdentity,Guid>
    {
        public ShopMeoDbContext(DbContextOptions<ShopMeoDbContext> opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DanhMucConfi());
            modelBuilder.ApplyConfiguration(new QuyenConfi());
            modelBuilder.ApplyConfiguration(new SanPhamConfi());
            modelBuilder.ApplyConfiguration(new SanPhamDanhMucConfi());
            modelBuilder.ApplyConfiguration(new TaiKhoanConfi());
            modelBuilder.ApplyConfiguration(new CartConfi());
            modelBuilder.ApplyConfiguration(new OrderConfi());
            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("UserClaimIdentity");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("UserRolesIdentity").HasKey(x=>new {x.UserId ,x.RoleId});
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLoginIdentity").HasKey(x=>x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaimIdentity");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("UserTokenIdentity").HasKey(x=>x.UserId);
            // base.OnModelCreating(modelBuilder);
        }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Cart> Carts {  get; set; }
        
    }
}
