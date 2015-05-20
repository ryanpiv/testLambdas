using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testLambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            string startStr = "";

            Console.Write("Author: Ryan Piveteau");
            Console.WriteLine();
            Console.WriteLine("5/20/15");
            Console.WriteLine("This is a short program to demonstrate how Lambdas work by using Lists.");
            Console.WriteLine();

            while (startStr == "")
            {
                string myStr = "";
                int myInt = 0;
                bool myParse;
                List<int> numbers = new List<int> { };

                Console.WriteLine("Enter a number and press enter.  When finished entering numbers, type the word 'finished'.");

                while (myStr == "")
                {
                    myStr = Console.ReadLine();
                    myParse = int.TryParse(myStr, out myInt);
                    if (myParse)
                    {
                        numbers.Add(myInt);
                        myStr = "";
                    }
                    else if (myStr.ToUpper() == "FINISHED")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Either you did not enter a number or you misspelled the word 'finished.'  Please try again.");
                        myStr = "";
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Would you like to sort the numbers by even or odd?");
                myStr = "";
                List<int> oddNumbers = new List<int>();
                while (myStr == "")
                {
                    myStr = Console.ReadLine();
                    if (myStr.ToUpper() == "EVEN")
                    {
                        oddNumbers = numbers.Where(n => n % 2 == 0).ToList();
                    }
                    else if (myStr.ToUpper() == "ODD")
                    {
                        oddNumbers = numbers.Where(n => n % 2 == 1).ToList();
                    }
                    else
                    {
                        Console.WriteLine("Please specify if the return values will be even or odd by typing 'even' or 'odd.'");
                        myStr = "";
                    }
                }

                for (int i = 0; i < oddNumbers.Count; i++)
                {
                    Console.Write(oddNumbers[i]);
                    Console.WriteLine();
                }
                Console.WriteLine("Restart?  Y/N");

                startStr = Console.ReadLine();
                if (startStr.ToUpper() == "N" || startStr.ToUpper() == "NO")
                {
                    System.Environment.Exit(1);
                }
                else
                {
                    myStr = "";
                    startStr = "";
                }
            }
        }
    }
}
