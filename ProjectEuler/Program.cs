using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Find multiples of 3 or 5 below what number?."); //ask for input
            string input = Console.ReadLine(); //store input
            int maxNumber;
            Int32.TryParse(input, out maxNumber); //convert to int


            int sum = FindMultiples(maxNumber); //execute method
            //FizzBuzz(maxNumber); //execute fizzbuz

            Console.WriteLine($"{sum} is the sum.");
            Console.ReadLine();
        }

        private static int FindMultiples(int maxNumber) //finding the multiples
        {

            int sum = 0;

            for (int i = 0; i < maxNumber; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine($"{i} is a multiple of 3 or 5.");
                    sum += i;
                }
            }

            return sum;
        }

        private static void FizzBuzz(int maxNumber) //doing fizzbuzz
        {
            for (int i = 0; i < maxNumber; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }
        }
    }
}
