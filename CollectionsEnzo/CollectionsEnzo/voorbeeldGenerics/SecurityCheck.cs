using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsEnzo.voorbeeldGenerics
{
    internal class SecurityCheck
    {
        public void CheckLaptopBag(LaptopBag laptopBag)
        {
            laptopBag.PrintContentBag();
        }

        public void CheckChihuahuaBag(ChihuahuaBag chihuahuaBag)
        {
            chihuahuaBag.PrintContentBag();
        }
    }
}
