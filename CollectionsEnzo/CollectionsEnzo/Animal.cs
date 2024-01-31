using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsEnzo
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return Name + " : " + Age;
        }
    }
}
