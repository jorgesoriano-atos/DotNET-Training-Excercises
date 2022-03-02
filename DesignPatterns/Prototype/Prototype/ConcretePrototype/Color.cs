using Prototype.Prototypes;
using System.Text.Json;
using System.Text.Json.Serialization;
using Prototype;
//using Newtonsoft.Json;

namespace Prototype.ConcretePrototype
{
    public class Color : ColorPrototype
    {
        public string Name { get; set; }
        public RGB RGB { get; set; }

        public Color(string name, int[] rgbValues)
        {

            Name = name;
            RGB = new RGB(rgbValues[0], rgbValues[1], rgbValues[2]);

        }
        public override ColorPrototype DeepClone()
        {
            /*string JSONString = JsonConvert.SerializeObject(this);
            return (ColorPrototype)JsonConvert.DeserializeObject<Color>(JSONString);*/
            string JSONString = JsonSerializer.Serialize(this);
            Console.WriteLine(JSONString);
            Color colorTest = JsonSerializer.Deserialize<Color>(JSONString);
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
