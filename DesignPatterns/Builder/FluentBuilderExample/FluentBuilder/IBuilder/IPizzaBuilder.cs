using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderExample.FluentBuilder.IBuilder
{
    public interface IPizzaBuilder
    {
        public IPizzaBuilder Reset();
        public IPizzaBuilder SetRecipeName(string name);
        public IPizzaBuilder AddCrust(string crustType);
        public IPizzaBuilder AddSauce();
        public IPizzaBuilder AddCheese();
        public IPizzaBuilder AddIngredient(string ingredientType);
    }
}
