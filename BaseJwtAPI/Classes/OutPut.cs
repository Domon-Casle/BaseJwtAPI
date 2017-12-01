using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseJwtAPI.Classes
{
    public class OutPut
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public string UpperName { get; set; } // Proof camelcase is working
    }
}
