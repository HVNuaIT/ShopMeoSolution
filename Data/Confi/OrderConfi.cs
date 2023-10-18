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
    public class OrderConfi : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();
            builder.HasOne(x=>x.UserIdentity).WithMany(x=>x.Orders).HasForeignKey(x=>x.IdUser).OnDelete(DeleteBehavior.Restrict);
            builder.Property(x=>x.TrangThaiOrder).HasDefaultValue(TrangThaiOrder.Pending).IsRequired();
            builder.Property(x => x.DiaChiNhan).HasMaxLength(200).IsRequired();
            builder.Property(x => x.SDTNhan).HasMaxLength(10).IsRequired();
            builder.Property(x => x.TenNguoiNhan).HasMaxLength(100).IsRequired();
            builder.Property(x => x.EmailNhan).HasMaxLength(50).IsRequired().IsUnicode(false);
            builder.Property(x => x.NgayOrder).HasDefaultValue(DateTime.Now);

        }
    }
}
