using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsEnzo.voorbeeldGenerics
{
    internal class Bag<T>
    {
        public T content {  get; set; }
        public void PrintContent()
        {
            Console.WriteLine(content.ToString());
        }
    }
}
