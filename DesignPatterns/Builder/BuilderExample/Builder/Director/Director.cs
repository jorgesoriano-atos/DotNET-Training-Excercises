using BuilderExample.Builder.IBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample.Builder.Director
{
    public class Director
    {
        public void BuildPizza(IPizzaBuilder pizzaBuilder, Enumerations.PizzaTypes pizzaType)
        {
            
            switch (pizzaType) 
            {
                case Enumerations.PizzaTypes.BonelessPizza:

                    pizzaBuilder.Reset();
                    pizzaBuilder.SetRecipeName("Boneless Pizza");
                    pizzaBuilder.AddSauce();
                    pizzaBuilder.AddCheese();
                    pizzaBuilder.AddIngredient("Olives");
                    pizzaBuilder.AddIngredient("Peppers");

                    break;

                case Enumerations.PizzaTypes.CheesePizza:

                    pizzaBuilder.Reset();
                    pizzaBuilder.SetRecipeName("Cheese Pizza");
                    pizzaBuilder.AddCrust("Thicc");
                    pizzaBuilder.AddSauce();
                    pizzaBuilder.AddCheese();

                    break;

                case Enumerations.PizzaTypes.PepperoniPizza:

                    pizzaBuilder.Reset();
                    pizzaBuilder.SetRecipeName("Pepperoni Pizza");
                    pizzaBuilder.AddCrust("Thicc");
                    pizzaBuilder.AddSauce();
                    pizzaBuilder.AddCheese();
                    pizzaBuilder.AddIngredient("Pepperoni");

                    break;

                case Enumerations.PizzaTypes.MushroomHamPizza:

                    pizzaBuilder.Reset();
                    pizzaBuilder.SetRecipeName("Mushroom and Ham Pizza");
                    pizzaBuilder.AddCrust("Thin");
                    pizzaBuilder.AddSauce();
                    pizzaBuilder.AddCheese();
                    pizzaBuilder.AddIngredient("Mushrooms");
                    pizzaBuilder.AddIngredient("Prosciutto");

                    break;

                case Enumerations.PizzaTypes.MargheritaPizza:

                    pizzaBuilder.Reset();
                    pizzaBuilder.SetRecipeName("Margherita Pizza");
                    pizzaBuilder.AddCrust("Thin");
                    pizzaBuilder.AddSauce();
                    pizzaBuilder.AddCheese();
                    pizzaBuilder.AddIngredient("Basil");

                    break;

                default:

                    throw new PizzaOutOfBoundsException();
                    
            }
        }
    }
}
