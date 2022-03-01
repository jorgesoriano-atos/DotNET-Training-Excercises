using BuilderExample.Builder.IBuilder;
using BuilderExample.Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample.Builder.ConcreteBuilder
{
    public class PizzaBuilder : IPizzaBuilder
    {
        Pizza PizzaPie;

        public void SetRecipeName(string name)
        {
            PizzaPie.RecipeName = name;
        }
        public PizzaBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            PizzaPie = new Pizza();
        }
        public void AddCheese()
        {
            PizzaPie.HasCheese = true;
        }

        public void AddCrust(string crustType)
        {
            PizzaPie.CrustType = crustType;
        }

        public void AddSauce()
        {
            PizzaPie.HasSauce = true;
        }

        public void AddIngredient(string ingredientType)
        {
            PizzaPie.Ingredients.Add(ingredientType);
        }

        public Pizza GetProduct() 
        {
            return PizzaPie;
        }
    }
}
