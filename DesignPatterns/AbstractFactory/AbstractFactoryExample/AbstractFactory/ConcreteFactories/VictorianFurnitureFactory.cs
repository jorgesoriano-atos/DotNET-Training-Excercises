using AbstractFactoryExample.AbstractFactory.AbstractProducts;
using AbstractFactoryExample.AbstractFactory.ConcreteProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.AbstractFactory.ConcreteFactories
{
    internal class VictorianFurnitureFactory : IAbstractFurnitureFactory
    {
        public IChair MakeChair()
        {
            return new VictorianChair();
        }

        public ITable MakeTable()
        {
            return new VictorianTable();
        }
    }
}
