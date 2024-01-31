using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CollectionsEnzo
{
    internal class LinqVoorbeelden
    {
/*Give animals a name and an age
Create a list of animals
Use LINQ to get the animals older than 5
Order them first by name
Then by age*/

        public static void Voorbeelden()
        {
            var animals = new List<Animal>
            {
                new Animal
                {
                    Name = "Max",
                    Age = 1
                },
                new Animal
                {
                    Name = "Ayla",
                    Age = 7
                },
                new Animal
                {
                    Name = "Whopper",
                    Age = 16
                },
                new Animal
                {
                    Name = "Shiva",
                    Age = 3
                },
                new Animal
                {
                    Name = "Boeddie",
                    Age = 3
                }

            };

            animals.FindAll(a => a.Age >= 5)
                .OrderBy(a => a.Name)
                .ThenBy(a => a.Age)
                .ToList()
                .ForEach(a => Console.WriteLine(a));


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
