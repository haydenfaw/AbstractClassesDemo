using System;
using System.Collections.Generic;
using System.Text;

            /* 
             * DONE -- Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE -- Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONE -- Provide the implementations for the abstract methods
             * DONE -- Only in the Motorcycle class will you override the virtual drive method
            */

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine($"The motorcycle is driving abstractly!");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} that is virtually in drive!");
        }
    }
}
