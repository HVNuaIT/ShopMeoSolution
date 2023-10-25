using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopMeoSolution.Domain.Entity;
using ShopMeoSolution.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMeoSolution.Domain.Confi
{
    public class DanhMucConfi : IEntityTypeConfiguration<DanhMuc>
    {
        public void Configure(EntityTypeBuilder<DanhMuc> builder)
        {
            builder.ToTable("DanhMuc");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.TenDanhMuc).HasMaxLength(60).IsRequired();
            builder.Property(x => x.TrangThai).HasDefaultValue(TrangThai.Active).IsRequired();
            // builder.HasMany(x=>x.SanPhams).WithOne(x=>x.DanhMuc).HasForeignKey(x=>x.IdDanhMuc).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
