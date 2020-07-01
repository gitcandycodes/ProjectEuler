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
            FizzBuzz(1000);

            Console.ReadLine();
        }

        private static void FizzBuzz(int maxNumber)
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
