using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Entities.Concrete.Authentication
{
    public class AppRole: IdentityRole<int>
    {
        public DateTime CreatedTime { get; set; }
    }
}
