using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaces
{
    public class RightRectangle : IShapes
    {

        readonly decimal Width;
        readonly decimal Height;
        readonly decimal Hypotenuse;

        public RightRectangle(decimal width, decimal height)
        {
            Width = width;
            Height = height;
            Hypotenuse = GetHypotenuse(width, height);
        }

        static decimal GetHypotenuse(decimal width, decimal height)
        {
            return (decimal)Math.Sqrt((double) (width * width) + (double) (height * height));
        }
        public decimal Area()
        {
            return (Width * Height) / 2;
        }

        public decimal Perimeter()
        {
            return Width + Height + Hypotenuse;
        }
    }
}
