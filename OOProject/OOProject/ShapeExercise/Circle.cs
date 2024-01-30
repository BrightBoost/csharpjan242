using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProject.ShapeExercise
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }
        public override double CalcArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double CalcCircumference()
        {
            return 2 * Radius * Math.PI;
        }
    }
}
