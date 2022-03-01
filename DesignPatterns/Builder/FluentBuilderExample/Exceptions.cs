using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderExample
{
    public class PizzaOutOfBoundsException : Exception
    {
        public PizzaOutOfBoundsException() : base()
        {
            Console.WriteLine("PizzaOutOfBoundsException: Selected pizza is not a valid option for pizza building.");
        }
    }
}
