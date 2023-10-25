using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopMeoSolution.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMeoSolution.Domain.Confi
{
    public class CartConfi : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Cart");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(x => x.SanPham).WithMany(x => x.Carts).HasForeignKey(x => x.IdSanPham).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.UserIdentity).WithMany(x => x.Carts).HasForeignKey(x => x.IdUser).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
