using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMeoSolution.Domain.Entity
{
    public class RoleIdentity : IdentityRole<Guid>
    {
        public string MoTa { get; set; } = string.Empty;
    }
}
