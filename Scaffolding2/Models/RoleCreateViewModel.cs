﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Scaffolding2.Models
{
    public class RoleCreateViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}
