using AbstractFactoryExample.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.AbstractFactory.ConcreteProducts
{
    public class ModernChair : IChair
    {
        public string GetStyle()
        {
            return Enumerations.FurnitureStyles.Modern.ToString();
        }

        public string HasLegs()
        {
            return "This chair has 3 legs";
        }

        public string SitOn()
        {
            return "You sat on a modern chair";
        }
    }

    public class VictorianChair : IChair
    {
        public string GetStyle()
        {
            return Enumerations.FurnitureStyles.Victorian.ToString();
        }

        public string HasLegs()
        {
            return "This chair has 4 legs";
        }

        public string SitOn()
        {
            return "You sat on a victorian chair";
        }
    }
}
