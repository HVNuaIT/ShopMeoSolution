using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class UserIdentity : IdentityUser<Guid>
    {
        public DateTime? Date { get; set; }
        public List<Cart>?Carts { get; set; }
        public List<Order>? Orders { get; set; }
    }
}
