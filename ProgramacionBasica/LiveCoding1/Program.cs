using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCoding1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int menuChoice = 0;

            while(menuChoice != 4)
            {

                Console.WriteLine("Select an option:" +
                    "\n\t1 - Pairs in a 2 digit number N." +
                    "\n\t2 - Perfect numbers between 1 and N." +
                    "\n\t3 - Give me a name until it is 'NetMentor'." +
                    "\n\t4 - Exit.");

                menuChoice = Convert.ToInt32(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:

                        Console.WriteLine("\n\t\tInsert a 2 digit Number: ");
                        int N1 = Convert.ToInt32(Console.ReadLine());
                        GetPairs(N1);
                        break;

                    case 2:

                        Console.WriteLine("\n\t\tInsert a Number to get the perfect numbers between 1 and it: ");
                        int N2 = Convert.ToInt32(Console.ReadLine()); 
                        Console.WriteLine("\n\t\tResult: ");
                        bool ArePerfectNumbers = false;
                        for(int i = 1; i <= N2; i++)
                        {
                            if (isPerfectNumber(i))
                            {   
                                Console.WriteLine(i);
                                ArePerfectNumbers = true;
                            }
                        }

                        if (! ArePerfectNumbers) { Console.WriteLine("No perfect numbers here..."); }


                        break;
                    case 3:
                        keyWord();
                        break;
                    default:
                        Console.WriteLine("\n\t\tInvalid choice, choose from 1 to 4.");
                        break;
                }
            }

            Console.WriteLine("Exiting...");

            

        }

        public static void GetPairs(int N)
        {
            if(N > 9 && N < 100)
            {
                Console.WriteLine("\n\t\tPairs between 1 and " + N + " are:\n\t\t");
                for (int i = 0; i < N; i++)
                {
                    if (i % 2 == 0) Console.WriteLine(i + " ");
                }
            }
            else { Console.WriteLine("--ERROR: Invalid input, you must give a 2 digit number...--"); }
        }

        public static bool isPerfectNumber(int N)
        {
            int perfectsSum = 1;

            for (int i = 2; i * i <= N; i++)
            {
                if (N%i == 0)
                {
                    perfectsSum += (i + (N/i));
                }
            }

            if (N == perfectsSum && N != 1) { return true; }
            return false;
        }

        public static void keyWord()
        {
            String keyWordInput = "";

            do
            {
                Console.WriteLine("\n\t\t" + keyWordInput);
                Console.WriteLine("\n\t\tWhats the keyword?");
                keyWordInput = Console.ReadLine();
            } while (keyWordInput != "NetMentor");

            Console.WriteLine("\t\n\nCorrect! Come in!");
            return;
        }
    }
}
