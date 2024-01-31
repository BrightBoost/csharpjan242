using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsEnzo.voorbeeldGenerics
{
    internal class ChihuahuaBag
    {
        public Chihuahua Chihuahua { get; set; }

        public void PrintContentBag()
        {
            Console.WriteLine(Chihuahua.ToString());
        }
    }
}
