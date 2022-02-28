using AbstractFactoryExample.AbstractFactory.AbstractProducts;
using AbstractFactoryExample.AbstractFactory.ConcreteProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.AbstractFactory.ConcreteFactories
{
    public class ModernFurnitureFactory : IAbstractFurnitureFactory
    {
        public IChair MakeChair()
        {
            return new ModernChair();
        }

        public ITable MakeTable()
        {
            return new ModernTable();
        }
    }
}
