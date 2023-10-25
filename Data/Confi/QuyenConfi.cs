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
    public class QuyenConfi : IEntityTypeConfiguration<RoleIdentity>
    {
        public void Configure(EntityTypeBuilder<RoleIdentity> builder)
        {
            builder.ToTable("Role");
            builder.Property(x => x.MoTa).HasMaxLength(200).IsRequired();
        }
    }
}
