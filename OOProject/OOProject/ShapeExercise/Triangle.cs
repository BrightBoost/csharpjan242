using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProject.ShapeExercise
{
    internal class Triangle : Shape, IFoldable
    {
        public override sealed double CalcArea()
        {
            throw new NotImplementedException();
        }

        public override double CalcCircumference()
        {
            throw new NotImplementedException();
        }

        public void Fold()
        {
            throw new NotImplementedException();
        }
    }
}
