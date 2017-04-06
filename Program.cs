using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vh = new Inheritance2.Vehicle();
            vh.numberOfWheels = 4;
            //create a new instance of Vehicle using the Vehicle class

            Car davesCar = new Inheritance2.Car();
            davesCar.registrationPlate = "AB01 2ZZ";
            davesCar.hasCruiseControl = true;
            davesCar.numberOfDoors = 3;
            //create a new instance of Car using the Car class
            //changes the negistration plate using the properties get and set methods.

            Airplane airbus767 = new Airplane("BING! This is your Captain speaking", 200);
            //create a new instance of Airplane using the Airplane class

            airbus767.numberofPassengers = 550;
            //changes the passenger number using the properties get and set methods.

            airbus767.Cost(200);
            //we call the function Cost

            Console.WriteLine(airbus767.PublicSummary());
            //call the function PublicSummary into the command WriteLine

            Console.WriteLine(airbus767.AirplaneLand());
            //call the function AirplaneLand into the command WriteLine

            Console.ReadKey();
        }
    }
}
