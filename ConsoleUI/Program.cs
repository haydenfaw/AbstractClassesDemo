using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles
            //DONE -- Create a list of Vehicle called vehicles
            var listOfVehicles = new List<Vehicle>();

            /*
             *DONE -- Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             *DONE -- - new it up as one of each derived class
             *DONE -- Set the properties with object initializer syntax
             */

            Car mustang = new Car()
            {
                Year = 2021,
                Make = "Ford",
                Model = "Mustang",
                HasTrunk = false,
            };
            Motorcycle harley = new Motorcycle()
            {
                Year = 2007,
                Make = "Harley-Davidson",
                Model = "Sporster",
                HasSideCart = true,
            };
            Vehicle civic = new Car()
            {
                Year = 2003,
                Make = "Honda",
                Model = "Civic",
                HasTrunk = true,
            };
            Vehicle ducati = new Motorcycle()
            {
                Year = 2022,
                Make = "Ducati",
                Model = "Monster",
                HasSideCart = false,
            };

            /*
             *DONE -- Add the 4 vehicles to the list
             *DONE -- Using a foreach loop iterate over each of the properties
             */
            listOfVehicles.Add(mustang);
            listOfVehicles.Add(harley);
            listOfVehicles.Add(civic);
            listOfVehicles.Add(ducati);

            foreach (var vehicle in listOfVehicles)
            {
                Console.WriteLine($"Make: {vehicle.Make} Model: {vehicle.Model} Year: {vehicle.Year}");
                //vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine($"---------------------------------------");
            }

            //DONE -- Call each of the drive methods for one car and one motorcycle
            Console.WriteLine($"Display of different vehicle / Drive Method pairs:");
            mustang.DriveAbstract();
            civic.DriveVirtual();
            harley.DriveAbstract();
            ducati.DriveVirtual();
            #endregion
            Console.ReadLine();
        }
    }
}
