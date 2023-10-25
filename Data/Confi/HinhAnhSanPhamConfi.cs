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
    public class HinhAnhSanPhamConfi : IEntityTypeConfiguration<HinhAnhSanPham>
    {
        public void Configure(EntityTypeBuilder<HinhAnhSanPham> builder)
        {
            builder.ToTable("HinhAnh");
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(x => x.SanPham).WithMany(x => x.HinhAnhSanPhams).HasForeignKey(x => x.IdSanPham)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
