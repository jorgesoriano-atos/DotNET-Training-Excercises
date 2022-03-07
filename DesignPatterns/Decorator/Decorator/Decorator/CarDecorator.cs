using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public abstract class CarDecorator
    {
        private ICar Car;
        public CarDecorator(ICar car)
        {
            Car = car;
        }

        public string Make { get { return Car.Make; } }

        public double GetPrice()
        {
            return Car.GetPrice();
        }

        public abstract double GetDiscountedPrice();
    }
}
