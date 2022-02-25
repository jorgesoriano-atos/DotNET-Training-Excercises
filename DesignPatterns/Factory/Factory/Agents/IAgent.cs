using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Agents
{
    public interface IAgent
    {
        string GetQ();
        string GetE();
        string GetC();
        string GetX();
        string GetName();
    }
}
