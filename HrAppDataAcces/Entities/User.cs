using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }

        private string Password { get; set; }
        public int Id_AppUser { get; set; }
        public APPUser APPUser { get; set; }

    }
}
