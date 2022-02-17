using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAbstract
{
    public abstract class Triangle
    {
        public abstract decimal Area();
        public abstract decimal Perimeter();

        public double GetAreaWithHypotenuse(double sideA, double hypotenuse)
        {
            double sideB = Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(sideA, 2));
            return (sideA * sideB) / 2;
        }
    }

    public class Scalene : Triangle
    {
        public override decimal Area()
        {
            throw new NotImplementedException();
        }

        public override decimal Perimeter()
        {
            throw new NotImplementedException();
        }
    }

    public class Acute : Triangle
    {
        public override decimal Area()
        {
            throw new NotImplementedException();
        }

        public override decimal Perimeter()
        {
            throw new NotImplementedException();
        }
    }
}
