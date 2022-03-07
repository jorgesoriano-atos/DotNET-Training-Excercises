using Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Composite
{
    public class Manager : IEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public List<IEmployee> Subordinates;

        public Manager(string name, string department)
        {
            Name = name;
            Department = department;
            Subordinates = new List<IEmployee>();
        }

        public void GetDetails(int indentationLevel)
        {
            Console.WriteLine(string.Format("C {0}> Employee Name: {1}, Department: {2}\n", new String('-', indentationLevel), this.Name.ToString(), this.Department));

            foreach(var employee in Subordinates)
            {
                employee.GetDetails(indentationLevel + 1);
            }
            Console.WriteLine("\n");
        }
    }
}
