using Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Leaf
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public Employee(string name, string department)
        {
            Name = name;
            Department = department;
        }

        public void GetDetails(int indentationLevel)
        {
            Console.WriteLine(string.Format("L {0}> Employee Name: {1}, Department: {2}", new String('-', indentationLevel), this.Name.ToString(), this.Department ));
        }
    }
}
