﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.Entities
{
    public class APPUser
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public Role Role { get; set; }
        //public int? SecondaryRoleId { get; set; }
        //public Role SecondaryRole { get; set; }

    }
}
