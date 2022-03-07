using Composite.Component;
using Composite.Composite;
using Composite.Leaf;

IEmployee John = new Employee("John", "IT");
IEmployee Mike = new Employee("Mike", "IT");
IEmployee Jane = new Employee("Jane", "HR");
IEmployee Lars = new Employee("Lars", "HR");
IEmployee Ralf = new Employee("Ralf", "HR");


IEmployee Will = new Manager("Will", "IT")
{ Subordinates = { John, Mike } };
IEmployee Mary = new Manager("Mary", "HR")
{ Subordinates = { Jane, Lars, Ralf } };


IEmployee Jack = new Manager("Jack", "Head")
{ Subordinates = { Will, Mary } };

Jack.GetDetails(0);