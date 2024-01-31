namespace CollectionsEnzo
{
    internal class Program
    {
        static void Main(string[] args)
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