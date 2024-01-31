using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExercises.objectsMethodsOOP.SchoolManagementSystem
{
    public class Student : Person
    {
        public string StudentID { get; set; }

        public Student(string name, int age, string studentID)
            : base(name, age)
        {
            StudentID = studentID;
        }
    }



}
