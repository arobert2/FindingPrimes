using System;
using System.Collections.Generic;
using System.Text;

namespace FindingPrimes
{
    public class PrimeFinder
    {
        private static int[] _divisibles = new int[]
        {
            2,3,4,5,6,7,8,9,10
        };

        private static List<int> _primes = new List<int>();

        public static bool IsPrime(int testNum)
        {
            bool prime = true;

            //test if 1
            if (testNum == 1 || testNum == 0)
                return false;

            //test if 2 through 10 are divisible and testNum doesn't equal 2 through 10
            foreach(var i in _divisibles)
                if (testNum % i == 0 && testNum != i)
                    prime = false;

            //test if testNum is divisible by another prime and testNum doesn't equal what is dividing it
            foreach (var i in _primes)
                if (testNum % i == 0 && testNum != i)
                    prime = false;

            //If it cannot disprove it's a prime it adds it to the prime list
            if (!prime)
                _primes.Add(testNum);

            return prime;
        }
    }
}
