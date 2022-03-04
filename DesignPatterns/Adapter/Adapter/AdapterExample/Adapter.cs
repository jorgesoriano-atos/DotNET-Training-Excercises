using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAdapter.AdapteeExample;
using MyAdapter.TargetExample;

namespace MyAdapter.AdapterExample
{
    // The Adapter makes the Adaptee's interface compatible with the Target's
    // interface.
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }
        public string GetRequest()
        {
            return $"This is '{this._adaptee.GetSpecificRequest()}'";
        }
    }
}


