using FluentBuilderExample.FluentBuilder.IBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderExample.FluentBuilder.Director
{
    public class Director
    {
        public void BuildPizza(IPizzaBuilder pizzaBuilder, Enumerations.PizzaTypes pizzaType)
        {
            
            switch (pizzaType) 
            {
                case Enumerations.PizzaTypes.BonelessPizza:

                    pizzaBuilder.Reset()
                        .SetRecipeName("Boneless Pizza")
                        .AddSauce()
                        .AddCheese()
                        .AddIngredient("Olives")
                        .AddIngredient("Peppers");

                    break;

                case Enumerations.PizzaTypes.CheesePizza:

                    pizzaBuilder.Reset()
                        .SetRecipeName("Cheese Pizza")
                        .AddCrust("Thicc")
                        .AddSauce()
                        .AddCheese();

                    break;

                case Enumerations.PizzaTypes.PepperoniPizza:

                    pizzaBuilder.Reset()
                        .SetRecipeName("Pepperoni Pizza")
                        .AddCrust("Thicc")
                        .AddSauce()
                        .AddCheese()
                        .AddIngredient("Pepperoni");

                    break;

                case Enumerations.PizzaTypes.MushroomHamPizza:

                    pizzaBuilder.Reset()
                        .SetRecipeName("Mushroom and Ham Pizza")
                        .AddCrust("Thin")
                        .AddSauce()
                        .AddCheese()
                        .AddIngredient("Mushrooms")
                        .AddIngredient("Prosciutto");

                    break;

                case Enumerations.PizzaTypes.MargheritaPizza:

                    pizzaBuilder.Reset()
                        .SetRecipeName("Margherita Pizza")
                        .AddCrust("Thin")
                        .AddSauce()
                        .AddCheese()
                        .AddIngredient("Basil");

                    break;

                default:

                    throw new PizzaOutOfBoundsException();
                    
            }
        }
    }
}
