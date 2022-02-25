using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public sealed class SingletonClass
    {
        /*
         
         */
        private static SingletonClass? instance = null;
        private static int instanceCounter = 0;

        private SingletonClass()
        {
            instanceCounter++;
            Console.WriteLine($"instance count: {instanceCounter}");
        }
        /*
         Private construtor ensures that objects can only be instantiated
         inside this class.
         */

        public static SingletonClass GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonClass();
                }
                return instance;
            }
        }
        /*
         Public property to provide access to the private instance.
         */

        public int getInstanceCounter() { return instanceCounter; }
    }
}
