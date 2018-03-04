using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 2;
            int last = 2;
            int beforeLast = 1;
            for (int i = last + beforeLast; i < 4000000; i = last+beforeLast)
            {
                beforeLast = last;
                last = i;
                if (isEven(i))
                    sum += i;
            }
            Console.WriteLine(sum);
            Console.Read();
        }

        public static bool isEven(int n)
        {
            return (n % 2 == 0);
        }
    }
}
