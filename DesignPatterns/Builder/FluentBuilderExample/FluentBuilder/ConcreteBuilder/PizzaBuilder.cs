using FluentBuilderExample.FluentBuilder.IBuilder;
using FluentBuilderExample.FluentBuilder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderExample.FluentBuilder.ConcreteBuilder
{
    public class PizzaBuilder : IPizzaBuilder
    {
        Pizza PizzaPie;

        public IPizzaBuilder SetRecipeName(string name)
        {
            PizzaPie.RecipeName = name;
            return this;
        }
        public PizzaBuilder()
        {
            this.Reset();
        }

        public IPizzaBuilder Reset()
        {
            PizzaPie = new Pizza();
            return this;
        }
        public IPizzaBuilder AddCheese()
        {
            PizzaPie.HasCheese = true;
            return this;
        }

        public IPizzaBuilder AddCrust(string crustType)
        {
            PizzaPie.CrustType = crustType;
            return this;
        }

        public IPizzaBuilder AddSauce()
        {
            PizzaPie.HasSauce = true; 
            return this;
        }

        public IPizzaBuilder AddIngredient(string ingredientType)
        {
            PizzaPie.Ingredients.Add(ingredientType);
            return this;
        }

        public Pizza GetProduct() 
        {
            return PizzaPie;
        }
    }
}
