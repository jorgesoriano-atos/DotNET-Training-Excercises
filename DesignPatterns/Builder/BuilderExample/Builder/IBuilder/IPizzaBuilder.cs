using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample.Builder.IBuilder
{
    public interface IPizzaBuilder
    {
        public void Reset();
        public void SetRecipeName(string name);
        public void AddCrust(string crustType);
        public void AddSauce();
        public void AddCheese();
        public void AddIngredient(string ingredientType);
    }
}
