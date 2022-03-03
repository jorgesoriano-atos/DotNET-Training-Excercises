using Prototype.ConcretePrototype;


//Instantitation of Original color and making a shallow copy of it.
Console.WriteLine("Instantiation of original color and shallow cloning:\n");
Color OriginalRed = new Color("Red", new int[] { 255, 0, 0 });
Color ShallowRed = (Color)OriginalRed.ShallowClone();

Console.WriteLine($"\t{OriginalRed.ToString()}");
Console.WriteLine($"\t{ShallowRed.ToString()}");



//Console.WriteLine("\n-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/\n");

//Altering shallow copy values.
Console.WriteLine("\nAltering values of shallow copy in turn alters original referencial values such as RGB values:\n");
ShallowRed.Name = "Shallow Red";
ShallowRed.RGB.Green = 30;
ShallowRed.RGB.Blue = 30;

Console.WriteLine($"\t{OriginalRed.ToString()}");
Console.WriteLine($"\t{ShallowRed.ToString()}");



Console.WriteLine("\n\n-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/*-/\n\n");

//Instantitation of Original color and making a deep copy of it.
Console.WriteLine("Instantiation of original color and deep cloning:\n");
Color OriginalGreen = new Color("Green", new int[] { 0, 255, 0 });
Color DeepGreen = (Color)OriginalGreen.DeepClone();

Console.WriteLine($"\t{OriginalRed.ToString()}");
Console.WriteLine($"\t{DeepGreen.ToString()}");

//Altering Deep copy values.
Console.WriteLine("\nAltering values of deep copy does not alter the original object because in the new one RGB values " +
    "\nare not referencing the RGB values instance of the old object, but are their own new instance:\n");
DeepGreen.Name = "Deep Green";
DeepGreen.RGB.Green = 150;


Console.WriteLine($"\t{OriginalGreen.ToString()}");
Console.WriteLine($"\t{DeepGreen.ToString()}\n\n\n\n\n");