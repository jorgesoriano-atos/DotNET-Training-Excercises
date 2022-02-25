using Factory.Agents;
using Factory.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory
{
    public class AgentFactory
    {
        public IAgent GetAgent(int agentNumber)
        {
            IAgent returnAgent = null;

            switch (agentNumber)
            {
                case 10:
                    returnAgent = new JettAgent();
                    break;
                case 17:
                    returnAgent = new KayoAgent();
                    break;
                case 7:
                    returnAgent = new SageAgent();
                    break;
                default:
                    CustomException.NonExistentAgent();
                    break;
            }
            return returnAgent;
        }
    }
}
