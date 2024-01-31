using CollectionsEnzo.voorbeeldGenerics;

namespace CollectionsEnzo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LezenEnSchrijven.SchrijfVoorbeeld();


        }

        static void PopulateCustomerAddresses(Customer customer)
        {
            customer.Addresses.Add(new Address()
            {
                StreetName = "Hart van Brabantlaan",
                City = "Tilburg",
                PostalCode = "5049aa",
                HouseNumber = "12-14"
            });

            customer.Addresses.Add(new Address()
            {
                StreetName = "Maliebaan",
                City = "Utrecht",
                PostalCode = "3851CZ",
                HouseNumber = "108"
            });
        }

        static void MyFirstList()
        {
            var list = new List<int> { 6, 1, 2, 3, 4, 5, 7 };

            foreach (int item in list)
            {
                Console.WriteLine(item.ToString());
            }

            // item weggooien
            list.RemoveAt(6);
            list.Remove(6);



        }

        static void GenericsExplained()
        {
            Laptop laptop = new Laptop();
            laptop.Brand = "Lenovo";
            laptop.Model = "Iets met pad";
            Bag<Laptop> laptopBag = new Bag<Laptop>();
            laptopBag.content = laptop;
            laptopBag.PrintContent();

            Chihuahua chihuahua = new Chihuahua();
            chihuahua.Name = "Coco";
            Bag<Chihuahua> chihuahuaBag = new Bag<Chihuahua>();
            chihuahuaBag.content = chihuahua;
            chihuahuaBag.PrintContent();
        }

        static void ArrayOpdracht()
        {
            OpdrachtArray opdrachtArray = new OpdrachtArray();
            opdrachtArray.Opdracht();
        }
        static void VoorbeeldArrayStuff()
        {
            VoorbeeldArray voorbeeldArray = new VoorbeeldArray();
            voorbeeldArray.Ints = new int[12];
            voorbeeldArray.Ints[0] = 56;
            Console.WriteLine(voorbeeldArray.Ints[0]);

            string[] namen = { "Marc", "Niek", "Martijn", "Eelco", "Thomas" };
            Console.WriteLine(namen[3]);
            Console.WriteLine("--------");

            for (int i = 0; i < namen.Length; i++)
            {
                Console.WriteLine(namen[i]);
            }
            Console.WriteLine("--------");
            //Array.Sort(namen, new Vergelijkerd());
            Array.Sort(namen, (x, y) => x.Length - y.Length);

            foreach (string naam in namen)
            {
                Console.WriteLine(naam);
            }
        }
    }
}