using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample.Builder.Product
{
    public class Pizza
    {
        public string RecipeName { get; set; }
        public string CrustType { get; set; }
        public bool HasSauce { get; set; }
        public bool HasCheese { get; set; }
        public List<string> Ingredients { get; set; }
        
        public Pizza()
        {
            Ingredients = new List<string>();
        }
    }
}
