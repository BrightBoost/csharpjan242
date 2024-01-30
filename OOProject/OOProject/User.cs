using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProject
{
    internal class User : Person
    {
        public User(string name, string userName) : base(name) 
        { 
            UserName = userName;
        }
        public string UserName { get; set; }

        public override void IntroduceYourself()
        {
            Console.WriteLine("Hi, I'm user " + UserName);
        }
    }
}
