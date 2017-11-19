using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Crypto_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RNG.Next(10));
        }

        static int[] primes = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 39, 41, 43 };
        

        static bool IsPrime(BigInteger p)
        {
            foreach (int prime in primes)
                if (p % prime == 0)
                    return false;

            int s = 0;
            BigInteger p1 = p - 1;
            while (p1 % 2 == 0)
                s++;

            return false;
        }
    }
}
