using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExercises.switchAndEnums
{
    public class MonthNameToNumber
    {
        enum Month { January = 1, February, March, April, May, June, July, August, September, October, November, December }

        public static void MonthToNumber()
        {
            Console.Write("Enter the name of the month: ");
            string monthName = Console.ReadLine();

            try
            {
                Month month = (Month)Enum.Parse(typeof(Month), monthName, true);
                Console.WriteLine($"Month number: {(int)month}");
                Console.WriteLine($"Month enum: {month}");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid month name!");
            }
        }
    }

}
