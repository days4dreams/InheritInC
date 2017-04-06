using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Airplane : PublicTransport
    {
        public Airplane(string publicTransportAlert, int publicTransportCost) : base (publicTransportAlert, publicTransportCost)
        { }
        //instruct that Airplane is child of PublicTransport class, use contructor with same inputs

        public string AirplaneAnnouncement = "Fasten Your Seatbelts!";
        //create a string to describe airplane-only action. Cannot be used by other publicTransport objects

        public string AirplaneLand()
        {
            return publicTransportAlert + " we're in for a bumpy ride. " + AirplaneAnnouncement;
        }
        //create a function to return the airplane Action string to screen
    }
}
