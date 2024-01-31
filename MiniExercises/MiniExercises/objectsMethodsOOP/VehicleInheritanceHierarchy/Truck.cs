using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExercises.objectsMethodsOOP.VehicleInheritanceHierarchy
{
    public class Truck : Vehicle
    {
        public int TowingCapacity { get; set; }

        public Truck(string make, string model, int year, int towingCapacity)
            : base(make, model, year)
        {
            TowingCapacity = towingCapacity;
        }

        public override string DisplayInfo()
        {
            return $"{base.DisplayInfo()}, Towing Capacity: {TowingCapacity}";
        }
    }
}
