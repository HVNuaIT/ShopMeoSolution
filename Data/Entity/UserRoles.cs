using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class UserRoles
    {
       
        public int UserId { get; set; }
        public TaiKhoan TaiKhoan { get; set; }
        public int IdRole { get; set; }
        public Quyen Quyen { get; set; }
    }
}
