using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces
{
    public class Square : IShapes
    {

        public decimal Side;
        public Square(decimal side)
        {
            Side = side;
        }
        public decimal Area()
        {
            return Side * Side;
        }

        public decimal Perimeter()
        {
            return Side * 4; 
        }
    }
}
