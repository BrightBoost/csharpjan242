using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExercises.variables
{
    public class CarInformation
    {
        public static void Info()
        {
            string make = "Toyota";
            string model = "Camry";
            int year = 2020;
            string color = "Red";
            int mileage = 15000; // in miles

            Console.WriteLine("Car Information:");
            Console.WriteLine($"Make: {make}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Mileage: {mileage} miles");
        }
    }

}
