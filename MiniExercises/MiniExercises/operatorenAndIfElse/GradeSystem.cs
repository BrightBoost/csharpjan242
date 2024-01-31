using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExercises.operatorenAndIfElse
{
    public class GradeSystem
    {
        public static void GradeConverter()
        {
            Console.Write("Enter your score: ");
            int score = Convert.ToInt32(Console.ReadLine());
            char grade;

            if (score >= 90)
            {
                grade = 'A';
            }
            else if (score >= 80)
            {
                grade = 'B';
            }
            else if (score >= 70)
            {
                grade = 'C';
            }
            else if (score >= 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }

            Console.WriteLine($"Your grade is: {grade}");
        }
    }

}
