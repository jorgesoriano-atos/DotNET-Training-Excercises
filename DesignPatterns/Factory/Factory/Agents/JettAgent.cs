using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Agents
{
    public class JettAgent : IAgent
    {
        private string AgentName;
        public string passiveHability = "Drift.";

        public JettAgent()
        {
            AgentName = "Jett";
        }
        public string GetC()
        {
            return "Cloudburst.";
        }

        public string GetE()
        {
            return "Tailwind.";
        }

        public string GetQ()
        {
            return "Updraft.";
        }

        public string GetX()
        {
            return "Blade Storm.";
        }

        public string GetName()
        {
            return AgentName;
        }
    }
}
