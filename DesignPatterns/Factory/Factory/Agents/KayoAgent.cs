using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Agents
{
    internal class KayoAgent : IAgent
    {
        public string AgentName { get; set; }

        public KayoAgent()
        {
            AgentName = "Kay/O";
        }

        public string GetC()
        {
            return "Fragment.";
        }

        public string GetE()
        {
            return "ZERO/point.";
        }

        public string GetQ()
        {
            return "Flash Drive.";
        }

        public string GetX()
        {
            return "NULL/cmd.";
        }

        public string GetName()
        {
            return AgentName;
        }
    }
}
