using AbstractFactoryExample.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.AbstractFactory
{
    public interface IAbstractFurnitureFactory
    {
        public IChair MakeChair();
        public ITable MakeTable();
    }
}
