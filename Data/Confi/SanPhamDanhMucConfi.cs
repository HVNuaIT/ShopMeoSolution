using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Confi
{
    public class SanPhamDanhMucConfi : IEntityTypeConfiguration<SanPhamDanhMuc>
    {
        public void Configure(EntityTypeBuilder<SanPhamDanhMuc> builder)
        {
            builder.ToTable("SanPhamDanhMuc");
            builder.HasKey(x => new { x.IdSanPham, x.IdDanhMuc });
          //  builder.HasOne(x => x.SanPham).WithMany(x=>x.SanPhamDanhMuc).HasForeignKey(x=>x.IdSanPham).OnDelete(DeleteBehavior.Restrict);
           // builder.HasOne(x => x.DanhMuc).WithMany(x => x.SanPhamDanhMuc).HasForeignKey(x => x.IdDanhMuc).OnDelete(DeleteBehavior.Restrict);
            
        }
    }
}
