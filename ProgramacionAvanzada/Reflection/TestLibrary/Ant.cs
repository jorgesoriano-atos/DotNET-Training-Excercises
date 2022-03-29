using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class Ant
    {
        private Secret AntSecret;
        public static string _QueenName => "Dalia";
        public string Name { get; set; }
        public string Species { get; set; }

        public string Role { get; set; }

        public Ant()
        {
            Name = "James";
            Species = "Leafcutting";
            Role = "worker";
            AntSecret = new Secret();
        }

        public override string ToString()
        {
            return $"{this.Name} is a {this.Species} {this.Role} ant.";
        }

        public void DoSomething()
        {
            Console.WriteLine($"{this.Name} is working...");
        }
    }
}
