using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Bus : PublicTransport
    {
        public Bus(string publicTransportAlert, int publicTransportCost) : base (publicTransportAlert, publicTransportCost)
        { }
        //instruct that Bus is child of PublicTransport class, use contructor with same inputs

        public string busBell = "The Bus Is Stopping";
        //create a string to describe bus-only action. Cannot be used by other publicTransport objects

        public string BusLane()
        {
            return publicTransportAlert + " get out of the way " + busBell;
        }
        //create a function to return the busBell Action string to screen
    }
}
