using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProject
{
    public class Person
    {
        
        public string Name { get; set; }
        public string HairColor { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }

        public Person(string name) : this(name, name + "@example.com")
        {
        }

        public Person(string name, string email) 
        {
            Name = name;
            Email = email;
        }

        public virtual void IntroduceYourself()
        {
            Console.WriteLine("Hi, I'm " + Name);
        }

        public void DyeHair(string color)
        {
            HairColor = color;
        }

        public string GetHairColor()
        {
            return HairColor;
        }

    }
}
