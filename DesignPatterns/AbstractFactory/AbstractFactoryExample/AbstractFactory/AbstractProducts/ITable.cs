using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.AbstractFactory.AbstractProducts
{
    public interface ITable
    {
        public string DineOn();
        public string HasLegs();

        public string GetStyle();
    }
}
