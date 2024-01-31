using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExercises.variables
{
    public class TemperatureConverter
    {
        public static void ConvertTemperature()
        {
            double celsius = 0.0;
            double fahrenheit = 0.0;

            Console.Write("Enter temperature in Celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius} Celsius is {fahrenheit} Fahrenheit");

            Console.Write("Enter temperature in Fahrenheit: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit} Fahrenheit is {celsius} Celsius");
        }
    }

}
