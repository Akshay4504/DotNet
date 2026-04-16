using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.builder
{
    internal class Car
    {
        public string Engine { get; set; }
        public string Colour { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfSeats { get; set; }

        public void Display()
        {
            Console.WriteLine($"\n--- Car Details---");
            Console.WriteLine($"Engine:{Engine}");
            Console.WriteLine($"Colour:{Colour}");
            Console.WriteLine($"NumberOfWheels:{NumberOfWheels}");
            Console.WriteLine($"NumberOfSeats:{NumberOfSeats}");
        }
    }
}
