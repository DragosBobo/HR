﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.Entities
{
    public class Role
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string? Description { get; set; }
        public List<Permission>? Permissions { get; set; }

    }
}
