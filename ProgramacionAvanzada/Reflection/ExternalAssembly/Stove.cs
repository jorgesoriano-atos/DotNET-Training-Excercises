using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalAssembly
{
    public class Stove
    {
        private readonly string Brand;
        private readonly string Model;
        private readonly int BurnerQty;
        private readonly string BurnerType;

        public double Height { get; set; }
        public double Width { get; set; }
        public double Breadth { get; set; }
        public bool HasOven { get; set; }
        public bool HasExtractionBell { get; set; }

        public Stove()
        {
            Brand = "Mabe";
            Model = "IO7686SSC0";
            BurnerQty = 4;
            BurnerType = "Induction";
            Height = 85;
            Width = 60;
            Breadth = 60;
            HasOven = true;
            HasExtractionBell = false;
        }

        public string GetBurnerInfo()
        {
            return $"{this.Brand} {this.Model} has {this.BurnerQty} {this.BurnerType} burners.";
        }

        public void Preheat(int temperature)
        {
            if (this.HasOven)
            {
                if (temperature <= 0 || temperature > 450)
                {
                    Console.WriteLine($"{this.Brand} {this.Model}'s oven operating temperatures are between 0 and 450 C.");
                }
                else
                {
                    Console.WriteLine($"{this.Brand} {this.Model} is preheating its oven to {temperature} C.");
                }
            } else
            {
                Console.WriteLine("This stove has no oven.");
            }
        }

        public void Extract()
        {
            if (this.HasExtractionBell)
            {
                Console.WriteLine("Extracting...");
            } else
            {
                Console.WriteLine("This stove has no extraction bell.");
            }
        }

        private void GetDimensions()
        {
            Console.WriteLine($"Private info - Dimensions: {this.Width}x{this.Height}x{this.Breadth}");
        }
    }
}
