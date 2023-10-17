using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Quyen
    {
        public int Id { get; set; }
        public string TenQuyen { get; set; } = string.Empty;
        public virtual ICollection<UserRoles>? UserRoles { get; set; }

    }
}
