using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExercises.objectsMethodsOOP.VehicleInheritanceHierarchy
{
    public class Car : Vehicle
    {
        public int Seats { get; set; }

        public Car(string make, string model, int year, int seats)
            : base(make, model, year)
        {
            Seats = seats;
        }

        public override string DisplayInfo()
        {
            return $"{base.DisplayInfo()}, Seats: {Seats}";
        }
    }
}
