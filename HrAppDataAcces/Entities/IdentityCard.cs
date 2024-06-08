using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.Entities
{
    internal class IdentityCard : BaseFile
    {
        public string CNP { get; set; }
        public string Series { get; set; }
        public string Number {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmitedZone { get; set; }

    }
}
