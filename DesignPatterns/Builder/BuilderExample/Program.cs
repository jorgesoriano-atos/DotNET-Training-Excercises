using BuilderExample.Builder;
using BuilderExample.Builder.ConcreteBuilder;
using BuilderExample.Builder.Director;
using BuilderExample.Builder.Product;
using System.Text.Json;

//1. Instantiate the director
Director director = new Director();

//2. Instantiate the builder
PizzaBuilder pizzaBuilder = new PizzaBuilder();

//Add only 1 pizza
//Instruct the director to build a pizza using the builder and the pizza type.
director.BuildPizza(pizzaBuilder, Enumerations.PizzaTypes.BonelessPizza);

//3. Store newly build pizza that was stored inside the builder
Pizza myBonelessPizza = pizzaBuilder.GetProduct();

//Print single pizza
Console.WriteLine(JsonSerializer.Serialize(myBonelessPizza));


Console.WriteLine("\n/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/\n");

//Add multiple pizzas in a List B)
List<Pizza> pizzaParty = new List<Pizza>();

//Repeat 2 and 3 for each new different pizza.
director.BuildPizza(pizzaBuilder, Enumerations.PizzaTypes.BonelessPizza);
pizzaParty.Add(pizzaBuilder.GetProduct());

director.BuildPizza(pizzaBuilder, Enumerations.PizzaTypes.CheesePizza);
pizzaParty.Add(pizzaBuilder.GetProduct());

director.BuildPizza(pizzaBuilder, Enumerations.PizzaTypes.PepperoniPizza);
pizzaParty.Add(pizzaBuilder.GetProduct());

director.BuildPizza(pizzaBuilder, Enumerations.PizzaTypes.MushroomHamPizza);
pizzaParty.Add(pizzaBuilder.GetProduct());

director.BuildPizza(pizzaBuilder, Enumerations.PizzaTypes.MargheritaPizza);
pizzaParty.Add(pizzaBuilder.GetProduct());

//Print multiple pizzas
foreach (Pizza pizza in pizzaParty)
{
    Console.WriteLine(JsonSerializer.Serialize(pizza));
}


Console.WriteLine("\n/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/\n");

//Test custom exception
director.BuildPizza(pizzaBuilder, Enumerations.PizzaTypes.GhostPizzaThatDoesNotExist);
Pizza testPizza = pizzaBuilder.GetProduct();
Console.WriteLine(JsonSerializer.Serialize(testPizza));
