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
    public class UserRolesConfi : IEntityTypeConfiguration<UserRoles>
    {
        public void Configure(EntityTypeBuilder<UserRoles> builder)
        {
            builder.ToTable("UserRoles");
            builder.HasKey(x => new { x.UserId, x.IdRole });
            builder.HasOne(x => x.TaiKhoan).WithMany(x => x.UserRoles).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Restrict);
          
            builder.HasOne(x=>x.Quyen).WithMany(x=>x.UserRoles).HasForeignKey(x=>x.IdRole).OnDelete(DeleteBehavior.Restrict);
     
        }
    }
}
