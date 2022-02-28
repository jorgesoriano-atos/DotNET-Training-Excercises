using AbstractFactoryExample.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.AbstractFactory.ConcreteProducts
{
    public class ModernTable : ITable
    {
        public string DineOn()
        {
            return "You dine on a modern table.";
        }

        public string GetStyle()
        {
            return Enumerations.FurnitureStyles.Modern.ToString();
        }

        public string HasLegs()
        {
            return "This table has only 1 leg";
        }
    }

    public class VictorianTable : ITable
    {
        public string DineOn()
        {
            return "You dine on a victorian table.";
        }

        public string GetStyle()
        {
            return Enumerations.FurnitureStyles.Victorian.ToString();
        }

        public string HasLegs()
        {
            return "This table has 4 legs";
        }
    }
}
