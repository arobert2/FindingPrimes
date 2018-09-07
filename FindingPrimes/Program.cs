using System;

namespace FindingPrimes
{
    class Program
    {
        public const int LOWER_BOUNDS = 0;
        public const int UPPER_BOUNDS = 2000;

        static void Main(string[] args)
        {
            Console.WriteLine("Prime Numbers Between {0} and {1}", LOWER_BOUNDS, UPPER_BOUNDS);
            for (int i = LOWER_BOUNDS; i <= UPPER_BOUNDS; i++)
                if (PrimeFinder.IsPrime(i))
                    Console.WriteLine("{0} is prime!", i);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
