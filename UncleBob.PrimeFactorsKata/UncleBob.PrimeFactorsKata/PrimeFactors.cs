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
            for (var candidate = 2; n > 1; candidate++)
            {
                for (; n % candidate == 0; n/=candidate)
                {
                    primes.Add(candidate);
                }
            }
            return primes;
        }
    }
}
