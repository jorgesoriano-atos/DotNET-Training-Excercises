using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Agents
{
    internal class SageAgent : IAgent
    {
        public string AgentName { get; set; }

        public SageAgent()
        {
            AgentName = "Sage";
        }

        public string GetQ()
        {
            return "Slow Orb.";
        }

        public string GetE()
        {
            return "Healing Orb.";
        }

        public string GetC()
        {
            return "Barrier Orb.";
        }

        public string GetX()
        {
            return "Resurrection.";
        }

        public string GetName()
        {
            return AgentName;
        }
    }
}
