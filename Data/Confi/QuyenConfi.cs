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
    public class QuyenConfi : IEntityTypeConfiguration<Quyen>
    {
        public void Configure(EntityTypeBuilder<Quyen> builder)
        {
            builder.ToTable("Role");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.TenQuyen).HasDefaultValue(10).IsRequired();
           


        }
    }
}
