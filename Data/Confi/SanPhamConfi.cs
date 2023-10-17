using Domain.Entity;
using Domain.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Confi
{
    public class SanPhamConfi : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.ToTable("SanPham");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.DanhMuc).WithMany(x => x.SanPhams).HasForeignKey(x => x.IdDanhMuc).OnDelete(DeleteBehavior.Restrict);
            builder.Property(x => x.TenSanPham).HasMaxLength(100).IsRequired();
            builder.Property(x => x.MoTa).IsRequired();
            builder.Property(x => x.SoLuong).IsRequired();
            builder.Property(x => x.Hinh).IsRequired();
            builder.Property(x => x.TrangThai).HasDefaultValue(TrangThai.Active).IsRequired();
            builder.Property(x => x.File).IsUnicode(true);


        }
    }
}
