using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsEnzo
{
    internal class LinqVoorbeelden
    {
        public static void Voorbeelden()
        {
            var list = new List<int> { 6, 1, 2, 3, 4, 5, 7 };

            list.ForEach(getal => Console.WriteLine(getal));
            Console.WriteLine("-----");
            list.FindAll(getal => getal % 2 == 0)
                .ForEach(getal => Console.WriteLine(getal));
            Console.WriteLine("-----");
            list.Where(getal => getal % 2 != 0)
                .Select(getal => getal = getal + 10)
                .ToList()
                .ForEach(getal => Console.WriteLine(getal));
            Console.WriteLine("-----");
            List<Address> addresses = new List<Address>();

            addresses.Add(new Address()
            {
                StreetName = "Hart van Brabantlaan",
                City = "Tilburg",
                PostalCode = "5049aa",
                HouseNumber = "12-14"
            });

            addresses.Add(new Address()
            {
                StreetName = "Maliebaan",
                City = "Utrecht",
                PostalCode = "3851CZ",
                HouseNumber = "108"
            });

            addresses.Add(new Address()
            {
                StreetName = "Grotiuslaan",
                City = "Nijmegen",
                PostalCode = "6nogwat",
                HouseNumber = "54"
            });

            addresses.Where(a => a.StreetName.StartsWith("H"))
                .ToList()
                .ForEach(a => Console.WriteLine(a.City));
        }
    }
}
