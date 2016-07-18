using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (isMultipleOfFive(i) || isMultipleOfThree(i))
                {
                    sum += i;
                }
            }

            Console.WriteLine("Sum of all multiples of 3 or 5 under 1000: " + sum);
            Console.Read();
        }

        static bool isMultipleOfFive(int num)
        {
            return (num % 5) == 0;
        }

        static bool isMultipleOfThree(int num)
        {
            return (num % 3) == 0; 
        }
    }
}
