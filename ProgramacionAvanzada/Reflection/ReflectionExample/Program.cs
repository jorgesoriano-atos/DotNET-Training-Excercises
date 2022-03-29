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
            var ExternalAssembly = Assembly.LoadFrom(@"C:\Users\a846809\Documents\Git\DotnetTrainingExercises\ProgramacionAvanzada\Reflection\TestLibrary\bin\Debug\net5.0\ExternalAssembly.dll");
            var ReflectedInstantiationAssembly = Assembly.LoadFrom(@"C:\Users\a846809\Documents\Git\DotnetTrainingExercises\ProgramacionAvanzada\Reflection\ReflectedInstantiation\bin\Debug\net5.0\ReflectedInstantiation.dll");

            //NormalTest(ExternalAssembly);

            //InstantiationTest(ReflectedInstantiationAssembly);

            //GenericClassTest(ExternalAssembly);

        }

        public static void NormalTest(Assembly assembly)
        {
            foreach (var type in assembly.GetTypes())
            {
                Console.WriteLine("\n------------------------ T Y P E ------------------------\n");

                Console.WriteLine($"Type: {type.Name}");

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

        public static void InstantiationTest(Assembly assembly)
        {
            var instance = Activator.CreateInstance(assembly.GetTypes()[0]);
            Console.WriteLine(instance.GetType());

            instance.GetType().GetMethod("Meow").Invoke(instance, null);
            //instance.GetType().GetMethod("Meow2").Invoke(instance, null);

            //instance.GetType().GetProperty("FurColor").SetValue(instance, "Red");
            //instance.GetType().GetMethod("Meow").Invoke(instance, null);
            


        }

    }

}
