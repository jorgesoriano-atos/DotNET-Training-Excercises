using Factory.Agents;
using Factory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a Factory object
            AgentFactory agentFactory = new AgentFactory();
            //Create a list of IAgent
            List<IAgent> party = new List<IAgent>();

            //Add agents to list through Factory's GetAgent()
            party.Add(agentFactory.GetAgent(10)); //Jett
            party.Add(agentFactory.GetAgent(17)); //Kay/O
            party.Add(agentFactory.GetAgent(7));  //Sage
            party.Add(agentFactory.GetAgent(10)); //Jett (again)

            //If we want to access to a subclass property we need to cast like this < ((Type) Object).property >
            //Console.WriteLine(((JettAgent)agentFactory.GetAgent(10)).passiveHability); //Will Output "Drift."

            //Use foreach to print agent and it's abilities
            foreach (IAgent agent in party)
            {
                Console.WriteLine($"\n - {agent.GetName()}: ");
                Console.WriteLine($"\nAgent's Q: {agent.GetQ()}" +
                    $"\nAgent's E: {agent.GetE()}" +
                    $"\nAgent's C: {agent.GetC()}" +
                    $"\nAgent's X: {agent.GetX()}" +
                    $"\n-----------------------------");

            }

        }
    }
}
