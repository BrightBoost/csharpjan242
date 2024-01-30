namespace OOProject
{
    internal class Program
    {
        static void Main(string[] args)
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