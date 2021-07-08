using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scaffolding2.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Street { get; set; }
        public int HomeNumber { get; set; }

    }
}
