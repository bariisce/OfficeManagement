﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class CreateRoleDTO
    {
        public string Name { get; set; } = default!;
        public bool IsAdmin { get; set; } = false;
    }
}
