using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProject
{
    internal class Car
    {
        private string _color;
        public string Color {
            get => _color;
            set => _color = value.ToLower();
        }
        public int CurrentSpeed { get; set; }

        public int AantalWielen { get; set; }

        public void StartCar()
        {
            Console.WriteLine("Car with color " + Color + " started");
        }

        public (string, int) GetContentTrunk()
        {
            return ("hondje", 2);
        }

        public void IncreaseSpeed(int speedDelta)
        {
            CurrentSpeed += speedDelta; // kort voor: CurrentSpeed = CurrentSpeed + speedDelta;
        }
    }
}
