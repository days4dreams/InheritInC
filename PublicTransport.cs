using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class PublicTransport : Vehicle
    {
        public string publicTransportOperator = "Local Council";
        public string publicTransportAlert = "\n Beep, Beep \n";
        public int publicTransportCost = 0;
        public bool publicTransportIsAccessible = true;
        //here we declare variables that are shared by the two constructors and the properties, and child classes


        /* start properties */
        public string AlertPublic
        {
            get { return this.publicTransportAlert; }
            set { this.publicTransportAlert = value; }
        }
        //this the declaration of a property, AlertPublic. It allows get and set; the sound can be changed.

        public string OperatorPublic
        {
            get { return this.publicTransportOperator; }
        }
        //this the declaration of a property, OperatorPublic. It has no set function because all systems are council owned.

        public int CostPublic
        {
            get { return this.publicTransportCost; }
            set { this.publicTransportCost = value; }
        }
        //this is a another property, CostPublic     
        /* end properties */


        /* start constructors */
        public PublicTransport(string publicTransportAlert, int publicTransportCost)
        {
            this.publicTransportAlert = publicTransportAlert;
            this.publicTransportCost = publicTransportCost;
        }
        //this is a constructor, for the PublicTransport object. It requires the alert and cost to be input to work.
        /* end constructors */


        /* start functions */
        public int Cost(int publicCost)
        {
            publicTransportCost = publicCost + (publicCost * 2);
            return publicTransportCost;
        }
        //this is a function. when we call it in the program, it converts the cost to cost plus VAT. 
        //See use of void for the distinction of a function

        public void Accessibility(bool isAccessible)
        {
            this.publicTransportIsAccessible = isAccessible;
        }
        //this is a second function, which takes an input, that will determine the PublicTransport.Accessibility to the isAccessible input

        public string Alert()
        {
            return AlertPublic;
        }
        //this is a third function that will present the vehicle's alert back to the screen. 

        public string PublicSummary()
        {
            return "All Aboard!\n This service is operated by: "
                    + this.publicTransportOperator
                    + "\n The cost to travel is: "
                    + this.publicTransportCost
                    + " per person.";
        }

        /* end functions */
    }
}
