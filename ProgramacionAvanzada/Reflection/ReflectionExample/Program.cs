using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ReflectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // These are the Assemblies needed for the examples; ExternalAssembly for example 1 and 3, and Reflected... for 2nd example.
            var ExternalAssembly = Assembly.LoadFrom(@"C:\Users\a846809\Documents\Git\DotnetTrainingExercises\ProgramacionAvanzada\Reflection\TestLibrary\bin\Debug\net5.0\ExternalAssembly.dll");
            var ReflectedInstantiationAssembly = Assembly.LoadFrom(@"C:\Users\a846809\Documents\Git\DotnetTrainingExercises\ProgramacionAvanzada\Reflection\ReflectedInstantiation\bin\Debug\net5.0\ReflectedInstantiation.dll");

            //NormalTest(ExternalAssembly);

            //InstantiationTest(ReflectedInstantiationAssembly);

            GenericClassTest(ExternalAssembly);

        }

        // Function that serves as an example of reflection basics.
        public static void NormalTest(Assembly assembly)
        {
            //Get all types in assembly
            foreach (var type in assembly.GetTypes())
            {
                Console.WriteLine("\n------------------------ T Y P E ------------------------\n");

                Console.WriteLine($"Type: {type.Name}");

                //Inside each type get all fields
                //Inside each type get all fields
                foreach (var field in type.GetFields(
                    BindingFlags.NonPublic |
                    BindingFlags.Public |
                    BindingFlags.Instance |
                    BindingFlags.DeclaredOnly
                    ))
                {
                    Console.WriteLine($"-- Property: {field.Name}, type: {field.FieldType}");
                }

                Console.WriteLine();

                //Inside each type get all methods
                foreach (var method in type.GetMethods(
                    BindingFlags.NonPublic |
                    BindingFlags.Public |
                    BindingFlags.Instance |
                    BindingFlags.DeclaredOnly)
                    .Where(m => !m.IsSpecialName)
                    )
                {
                    Console.WriteLine($"-- Method: {method.Name}, return type: {method.ReturnType}");
                }

                Console.WriteLine("\n---------------- E N D   O F   T Y P E ------------------\n\n");
            }
        }

        // Function that serves as an example of using generic classes with reflected objects.
        public static void GenericClassTest(Assembly assembly) 
        {

            List<Wildcard<object>> myList = new List<Wildcard<object>>();

            foreach (var type in assembly.GetTypes())
            {
                myList.Add(new Wildcard<object>(Activator.CreateInstance(type)));
            }

            foreach (var wildcard in myList)
            {
                wildcard.GetReflectedInfo();
            }
        }

        // Function that serves as an example of instantiating a reflected object.
        public static void InstantiationTest(Assembly assembly)
        {
            var instance = Activator.CreateInstance(assembly.GetTypes()[0]);
            Console.WriteLine(instance.GetType());

            instance.GetType().GetMethod("Meow").Invoke(instance, null);
            //instance.GetType().GetMethod("Meow2").Invoke(instance, null);

            instance.GetType().GetProperty("FurColor").SetValue(instance, "Striped");
            instance.GetType().GetMethod("Meow").Invoke(instance, null);
            


        }

    }

}
