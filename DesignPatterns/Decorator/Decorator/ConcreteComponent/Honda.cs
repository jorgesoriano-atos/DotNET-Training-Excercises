using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponent
{
    public sealed class Honda : ICar
    {
        public string Make => "Honda car";

        public double GetPrice()
        {
            return 33000;
        }
    }
}
