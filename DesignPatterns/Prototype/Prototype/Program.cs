
using Prototype.ConcretePrototype;
using Prototype.Prototypes;
using System.Collections.Generic;

//Instantitation of Original color and making a shallow copy of it.
Console.WriteLine("Instantiation of original color and shallow cloning.");
Color OriginalRed = new Color("Red", new int[] { 255, 0, 0 });
Color ShallowRed = (Color)OriginalRed.ShallowClone();

Console.WriteLine(OriginalRed.ToString());
Console.WriteLine(ShallowRed.ToString());

//Altering shallow copy values.
Console.WriteLine("Altering values of shallow copy in turn alters original referencial values such as RGB values.");
ShallowRed.Name = "Shallow Copied Red";
ShallowRed.RGB.Green = 30;
ShallowRed.RGB.Blue = 30;

Console.WriteLine(OriginalRed.ToString());
Console.WriteLine(ShallowRed.ToString());


//Instantitation of Original color and making a deep copy of it.
Console.WriteLine("Instantiation of original color and deep cloning.");
Color OriginalGreen = new Color("Green", new int[] { 0, 255, 0 });
Color DeepGreen = OriginalGreen.DeepClone() as Color;

Console.WriteLine(OriginalRed.ToString());
Console.WriteLine(DeepGreen.ToString());

//Altering Deep copy values.
Console.WriteLine("Altering values of shallow copy in turn alters original referencial values such as RGB values.");
DeepGreen.Name = "Shallow Copied Red";
DeepGreen.RGB.Green = 30;
DeepGreen.RGB.Blue = 30;

Console.WriteLine(OriginalGreen.ToString());
Console.WriteLine(DeepGreen.ToString());