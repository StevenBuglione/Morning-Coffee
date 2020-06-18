using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Morning_Coffee_Backend.Models
{
    public class Role : IdentityRole<int>
    {
        public virtual ICollection<UserRole> UserRoles { get; set; }

    }
}
