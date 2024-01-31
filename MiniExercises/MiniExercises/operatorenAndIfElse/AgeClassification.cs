using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExercises.operatorenAndIfElse
{
    public class AgeClassification
    {
        public static void ClassifyAge()
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age <= 12)
            {
                Console.WriteLine("You are a child.");
            }
            else if (age > 12 && age <= 19)
            {
                Console.WriteLine("You are a teenager.");
            }
            else if (age > 19 && age <= 60)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior.");
            }
        }
    }

}
