using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.Entities
{
    internal class Firma
    {
        public string CUI { get; set; }
        public string FirmaID { get; set; }
        public string FirmaName { get; set; }
        public string FirmaDescription { get; set; }
        public string FirmaType { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
