using Domain.Entity;
using Domain.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Confi
{
    public class TaiKhoanConfi : IEntityTypeConfiguration<TaiKhoan>
    {
        public void Configure(EntityTypeBuilder<TaiKhoan> builder)
        {
            builder.ToTable("TaiKhoan");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.DiaChi).HasDefaultValue(200).IsRequired();
            builder.Property(x => x.SoDienThoai).HasDefaultValue(11).IsRequired();
            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.TenNguoiDung).IsUnique();
            builder.Property(x => x.Email).HasDefaultValue(150).IsRequired();
            builder.Property(x => x.MatKhau).HasDefaultValue(150).IsRequired();
            builder.Property(x => x.DiaChi).HasDefaultValue(true);
            builder.Property(x => x.TrangThai).HasDefaultValue(TrangThai.Active).IsRequired();
          
        }
    }
}
