using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample.AbstractFactory.AbstractProducts
{
    public interface IChair
    {
        public string SitOn();
        public string HasLegs();
        public string GetStyle();
    }
}
