using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3And5
{
    public class LargestPrimeFactor
    {
        public long FindLargestPrimeFactor(long num)
        {
            var factorsOfNum = FindFactors(num);
            var listOfPrimeFactors = new List<long>();
            factorsOfNum.ForEach(factor =>
            {
                if (isPrime(factor))
                {
                    listOfPrimeFactors.Add(factor);
                }
            });
            return listOfPrimeFactors.Max();
        }

        private bool isPrime(long num)
        {
            
        }

        private List<long> FindFactors(long num)
        {
            var listOfFactors = new List<long>();

            for (int i = 2; i <= num/2; i++)
            {
                if (num%i == 0)
                {
                    listOfFactors.Add(i);
                }
                
            }

            return listOfFactors;
        }
    }
}
