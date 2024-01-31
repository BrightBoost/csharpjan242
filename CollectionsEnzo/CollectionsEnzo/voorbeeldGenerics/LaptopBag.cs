using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsEnzo.voorbeeldGenerics
{
    internal class LaptopBag
    {
        public Laptop Laptop { get; set; }

        public void PrintContentBag()
        {
            Console.WriteLine(Laptop.ToString());
        }
    }
}
