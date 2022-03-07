using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponent
{
    public sealed class Volkswagen : ICar
    {
        public string Make => "Volkswagen car";

        public double GetPrice()
        {
            return 26000;
        }
    }
}
