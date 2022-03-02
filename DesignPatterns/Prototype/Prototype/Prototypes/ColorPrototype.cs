using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Prototypes
{
    public abstract class ColorPrototype
    {
        public abstract ColorPrototype ShallowClone();
        public abstract ColorPrototype DeepClone();
    }
}
