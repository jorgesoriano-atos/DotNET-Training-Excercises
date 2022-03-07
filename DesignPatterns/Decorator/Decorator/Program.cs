using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;
using Decorator.Decorator;

//Instantiate new Concrete Component
ICar car1 = new Honda();
//Instantiate new Concrete Decorator, passing our Concrete Component as argument.
CarDecorator decorator = new CarDiscount(car1);

Console.WriteLine(String.Format("MAKE: {0}. " +
    "\nPRICE: ${1} USD." +
    "\nDISCOUNTEDPRICE: ${2} USD.",
    decorator.Make, decorator.GetPrice().ToString(), decorator.GetDiscountedPrice().ToString()));

Console.ReadLine();