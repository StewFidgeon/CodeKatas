using System;
using System.Collections.Generic;
using System.Text;

namespace UncleBob.PrimeFactorsKata
{
    public class PrimeFactors
    {
        public List<int> Generate(int n)
        {
            var primes = new List<int>();
            int candidate = 2;
            while (n > 1)
            {
                while (n % candidate == 0)
                {
                    primes.Add(candidate);
                    n /= candidate;
                }

                candidate++;
            }
            if (n > 1)
            {
                primes.Add(n);
            }
            return primes;
        }
    }
}
