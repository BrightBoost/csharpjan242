using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExercises.challenges
{
    public class CalculatingWithTime {
        public static void CalcWithTime()
        {
            Console.Write("Enter the time (HH.MM): ");
            double inputTime = Convert.ToDouble(Console.ReadLine());
            int hours = (int)inputTime;
            int minutes = (int)((inputTime - hours) * 100);

            Console.Write("Enter the number of minutes to add: ");
            int minutesToAdd = Convert.ToInt32(Console.ReadLine());

            minutes += minutesToAdd;
            hours += minutes / 60;
            minutes %= 60;
            hours %= 24;

            double resultTime = hours + minutes / 100.0;
            Console.WriteLine($"New time: {resultTime:00.00}");
        }
    }
}
