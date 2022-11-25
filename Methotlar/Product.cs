using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Methotlar
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public double  UnitPrice { get; set; }

        public string UnitIsStock { get; set; }
    }
}
