using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public int DepartmentType { get; set; }
        public string Name { get; set; }
        public int UnitId { get; set; }
    }
}
