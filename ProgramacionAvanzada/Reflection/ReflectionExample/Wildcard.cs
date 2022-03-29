using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    public class Wildcard<T>
    {
        public T Content { get; set; }

        public Wildcard(T t)
        {
            Content = t;
        }

        public void GetReflectedInfo()
        {
            Console.WriteLine("\n------------------------ T Y P E ------------------------\n");
            Console.WriteLine($"> TYPE RECEIVED: {Content.GetType()}");

            Console.WriteLine("> METHODS IN THE ORIGINAL TYPE: ");
            foreach (var method in Content.GetType().GetMethods(BindingFlags.NonPublic |
                    BindingFlags.Public |
                    BindingFlags.Instance |
                    BindingFlags.DeclaredOnly)
                    .Where(m => !m.IsSpecialName)
                    )
            {
                Console.WriteLine($"-- Method: {method.Name}, return type: {method.ReturnType}");
            }

            Console.WriteLine("> PROPERTIES IN THE ORIGINAL TYPE: ");
            foreach (var field in Content.GetType().GetFields(BindingFlags.NonPublic |
                    BindingFlags.Public |
                    BindingFlags.Instance |
                    BindingFlags.DeclaredOnly
                    ))
            {
                Console.WriteLine($"-- Property: {field.Name}, type: {field.FieldType}");
            }

            Console.WriteLine("\n--------------- E N D   O F   T Y P E ------------------\n\n");
        }

    }
}
