using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scalene scaleneTriangle = new Scalene();
            Acute acuteTriangle = new Acute();

            //scaleneTriangle.Area();
            //acuteTriangle.Perimeter();

            Console.WriteLine(scaleneTriangle.GetAreaWithHypotenuse(3, 7));
        }
    }
}
