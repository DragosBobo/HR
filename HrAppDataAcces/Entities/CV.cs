using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.Entities
{
    internal class CV : BaseFile
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Experience { get; set; }
    }
}
