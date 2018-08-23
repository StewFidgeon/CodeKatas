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
            if (n > 1)
            {
                primes.Add(2);
            }
            return primes;
        }
    }
}
