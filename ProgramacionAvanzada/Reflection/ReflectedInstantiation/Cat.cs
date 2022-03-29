using System;

namespace ReflectedInstantiation
{
    //Sample cat class

    public class Cat
    {
        public string FurColor { get; set; }
        public Cat() 
        {
            FurColor = "";
        }

        public void Meow()
        {
            if (FurColor != "")
            {
                Console.WriteLine($"{this.FurColor} cat says: MEOWWWW!");
            } else
            {
                Console.WriteLine("Cat says: MEOWWWW");
            }
            
        }
    }
}
