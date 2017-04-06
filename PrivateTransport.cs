using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    public class PrivateTransport : Vehicle
    {
        public bool sunroof { get; set; }
        public string frontBumper { get; set; }
        public int numberOfDoors { get; set; }
    }
}
