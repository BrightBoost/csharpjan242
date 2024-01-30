using System.Security.Cryptography.X509Certificates;

namespace ExampleAppJan24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string nameOfParticipant; // declare
            nameOfParticipant = "Martijn"; // initialise
            string name2 = "Marc"; // declare and initialise

            int numberOfStudents = 5;
            long bigNumberOfStudents = 1322342342342349999;
            double avgNrOfStudents = 4.7;
            float avgNrOfStudetns2 = 3.4f; // kleiner dan double
            decimal moneyValue = 3.4m;
            bool isFun = true;
            char character = 'a';

            Console.WriteLine("Wat is je naam? ");
            string name = Console.ReadLine();
            Console.WriteLine("Wat is je leeftijd? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De naam is zoveel chars: " + name.Length);
            double result = 4.0 / 5.0;

            Console.WriteLine(name + " " + age + " " + result);

            string voorbeeld = null; //prima
            //int x = null; //compileert niet
            int? x2 = null; //compileert wel, nu is het een nullable

            bool zelfde = age == 25;
            Console.WriteLine(zelfde);

            int nummer = 78;
            if (nummer > 0)
            {
                Console.WriteLine("Nummer is groter dan 0.");
            }
            else if (nummer % 2 != 0)
            {
                Console.WriteLine("Nummer is oneven.");
            }
            else if (nummer == 78)
            {
                Console.WriteLine("Nr is 78");
            }
            else
            {
                Console.WriteLine("Nummer is niet groter dan 0 en even.");

            }

            //Bijvoorbeeld toegangsprijs museum
            //Gebruik readline om een leeftijd te krijgen
            //Bepaal de toegangsprijs (WriteLine result)
            //- als jonger dan 3 dan gratis
            //- als tussen 3 en 18 dan 10,-
            //- als ouder dan 18 dan 15,-
            
            int leeftijd = Convert.ToInt32(Console.ReadLine());
            int prijs;
            if(leeftijd < 3 && leeftijd >= 0)
            {
                prijs = 0;
            }
            else if(leeftijd < 0)
            {
                throw new ArgumentException("Leeftijd moet groter zijn dan 0.");
            }
            else if(leeftijd < 18)
            {
                prijs = 10;
            }
            else
            {
                prijs = 15;
            }
            Console.WriteLine("Toegang is " + prijs);

            int x, y = 0; // 2 variabelen gedeclareerd, 1 variabele geinitialiseerd

            WeekDay vandaag = WeekDay.MAANDAG;
            Console.WriteLine(vandaag); */

            /*VerkeerslichtStatus kleur = VerkeerslichtStatus.GROEN;
            bool dichtbij = false;

            if(VerkeerslichtStatus.GROEN == kleur)
            {
                Console.WriteLine("Gewoon normaal doorrijden.");
            }
            else if(VerkeerslichtStatus.ORANJE == kleur && dichtbij)
            {
                Console.WriteLine("Gewoon normaal doorrijden.");
            }
            else if (VerkeerslichtStatus.ORANJE == kleur && !dichtbij)
            {
                Console.WriteLine("Remmen.");
            }
            else if (VerkeerslichtStatus.ROOD == kleur && dichtbij)
            {
                Console.WriteLine("Stoppen.");
            }
            else if (VerkeerslichtStatus.ROOD == kleur && !dichtbij)
            {
                Console.WriteLine("Voorbereiden op stoppen.");
            }
            else
            {
                Console.WriteLine("Doe voorzichtig. Succes.");
            }

            string inputKleur = Console.ReadLine();

            VerkeerslichtStatus gekozenKleur;

            switch(inputKleur.ToLower())
            {
                case "rood":
                    gekozenKleur = VerkeerslichtStatus.ROOD;
                    break;
                case "oranje":
                    gekozenKleur = VerkeerslichtStatus.ORANJE;
                    break;
                case "groen":
                    gekozenKleur = VerkeerslichtStatus.GROEN;
                    break;
                default:
                    gekozenKleur = VerkeerslichtStatus.DEFECT;
                    break;
            }

            switch(gekozenKleur)
            {
                case VerkeerslichtStatus.GROEN:
                    string message = dichtbij ? "rijden" : "rijden"; // ternary statement
                    Console.WriteLine(message);
                    break;
                case VerkeerslichtStatus.ORANJE:
                    Console.WriteLine("Voorzichtig");
                    break;
                case VerkeerslichtStatus.ROOD:
                    Console.WriteLine("Stoppen");
                    break;
                default:
                    Console.WriteLine("Voorzichtig doen.");
                    break;
            }

            int x = 78;
            switch (x)
            {
                case 5:
                    Console.WriteLine("is 5");
                    break;
                case 6:
                    Console.WriteLine("is 6");
                    break;
            }

            if(x == 5)
            {
                Console.WriteLine("is 5");
            } 
            else if(x == 6)
            {
                Console.WriteLine("is 6");
            }*/

            

            MonkeyPrint(10);
            Console.WriteLine(GetNr());

        }

        public static int GetNr()
        {
            return 67;
        }

        public static void ExampleBreak()
        {
            while(true)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if(x == GetNr())
                {
                    break;
                }
            }

            // ik heb een sterke voorkeur voor
            /*bool found = false;
            while (!found)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == GetNr())
                {
                    found = true;
                }
            }*/
        }

        public static void MonkeyPrint(int keer)
        {
            for (int i = keer; i > 0; i--)
            {
                Console.WriteLine(i + " Little monkey" + ((i > 1) ? "s" : "") + " jumping on a bed," + ((i > 1) ? "one" : "he") + " jumped up and bumped his head, Mom called the Doctor and the doctor said........'no more monkeys jumping on a bed'.");
            }
        }

        public static void ExplainLoops()
        {
            int teller = 0;
            while (teller < 20)
            {
                Console.WriteLine(teller);
                teller++;
            }

            int x;
            do
            {
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x);
            } while (x > 300);

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}