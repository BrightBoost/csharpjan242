using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsEnzo
{
    internal class LezenEnSchrijven
    {
        public static void LeesVoorbeeld()
        {
            string filePath = @".\Voorbeeld.txt";
            if(File.Exists(filePath))
            {
                using(StreamReader sr = new StreamReader(filePath))
                {
                    Console.WriteLine("joehoe");
                    while(!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            } 
            else
            {
                Console.WriteLine("Sorry, bestaat niet: " + filePath);
            }
        }

        public static void SchrijfVoorbeeld()
        {
            string filePath = @".\Voorbeeld.txt";
            if (File.Exists(filePath))
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine("Hoi!");
                }
            }
            else
            {
                Console.WriteLine("Sorry, bestaat niet: " + filePath);
            }
        }
    }
}
