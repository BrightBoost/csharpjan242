namespace OOProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoExerciseCar();
            User user = new User("Eelco", "Eelco123"); 
            user.Name = "TestUser";
            Person person = new Person("Niek");
            person.Name = "TestPerson";
            PersonPrinter(person);
            PersonPrinter(user);
            PersonPrinter(new Admin());
            user.IntroduceYourself();
            person.IntroduceYourself();
        }

        static void PersonPrinter(Person person)
        {
            Console.WriteLine(person.Name);
        }

        static void DoExerciseCar()
        {
            ExerciseCar car = new ExerciseCar("pink", 120);
            car.Start(100);
            Console.WriteLine(car.IsRunning);
            car.IncreaseSpeed(25);
            Console.WriteLine(car.CurrentSpeed);
        }
        static void CarStuff()
        {
            Car car = new Car();
            car.AantalWielen = 4;
            car.Color = "Black";
            Console.WriteLine(car.Color);
            Console.WriteLine("--------");
            Car car2 = new Car();
            car2.AantalWielen = 5;
            car2.Color = "Red";
            Console.WriteLine(car2.Color);
            car.StartCar();
            (string inhoud, int aantal) = car.GetContentTrunk();
            Console.WriteLine(inhoud);
            Console.WriteLine(car.GetContentTrunk());
            car2.IncreaseSpeed(30);
            Console.WriteLine(car2.CurrentSpeed);
            car2.IncreaseSpeed(30);
            Console.WriteLine(car2.CurrentSpeed);
        }
    }
}