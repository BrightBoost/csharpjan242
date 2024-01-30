using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProject.ShapeExercise
{
    internal abstract class Shape
    {
        public string Color { get; set; }
        public abstract double CalcArea();
        public abstract double CalcCircumference();

    }
}
