using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.Entities
{
    internal class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CNP { get; set; }
        public IdentityCard IdentityCard { get; set; }
        public List<CV> CVs { get; set; }
    }
}
