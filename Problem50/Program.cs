using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace _50ConsecutivePrimeSum
{
    class Program
    {
        private static int _CAP;

        static void Main(string[] args)
        {
            for (int i = primes.Count; i>=0; i--)
            {

            }
        }

        static bool canConsecutivePrimeSum(int index)
        {
            
        }

        private static List<int> primes
        {
            get
            {
                if (primes == null)
                {
                    for (int i = 0; i < 1000000; i++)
                    {
                        if (isPrime(i))
                        {
                            primes.Add(i);
                        }
                    }
                }
                return primes;
            }
        }

        static bool isPrime(int num)
        {
            if (num <= 1)
                return false;

            else if (num <= 3)
                return true;

            else if (num % 2 == 0 || num % 3 == 0)
                return false;

            int i = 5;
            while (i * i <= num)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                    return false;

                i += 6;
            }

            return true;
        }
    }
}