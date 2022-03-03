using Prototype.Prototypes;
using System.Text.Json;

namespace Prototype.ConcretePrototype
{
    public class Color : ColorPrototype
    {
        public string Name { get; set; }
        public RGB RGB { get; set; }

        public Color() { }
        public Color(string name, int[] rgbValues)
        {

            Name = name;
            RGB = new RGB(rgbValues[0], rgbValues[1], rgbValues[2]);

        }
        public override ColorPrototype DeepClone()
        {
            string JSONString = JsonSerializer.Serialize(this);
            return (ColorPrototype)JsonSerializer.Deserialize<Color>(JSONString);
        }

        public override ColorPrototype ShallowClone()
        {
            return (ColorPrototype)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{this.Name}: ({this.RGB.Red}, {this.RGB.Green}, {this.RGB.Blue})";
        }
    }
}
