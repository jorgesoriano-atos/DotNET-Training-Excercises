using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class InvalidRGBInstantiationException : Exception
    {
        public InvalidRGBInstantiationException() : base()
        {
            Console.WriteLine("InvalidRGBInstantiationException: Invalid parameters for RGB instantiation.");
        }
    }
}
