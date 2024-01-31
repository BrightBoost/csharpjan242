using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExercises.objectsMethodsOOP
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        // Constructor with all properties
        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        // Constructor with name and age only
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Address = "Unknown";
        }

        // Constructor with name only
        public Person(string name)
        {
            Name = name;
            Age = 0;
            Address = "Unknown";
        }
    }

}
