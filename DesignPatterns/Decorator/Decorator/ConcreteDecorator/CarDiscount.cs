using Decorator.Component;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteDecorator
{
    public class CarDiscount : CarDecorator
    {
        public CarDiscount(ICar car) : base(car)
        {
        }

        public override double GetDiscountedPrice()
        {
            return 0.8 * base.GetPrice();
        }
    }
}
