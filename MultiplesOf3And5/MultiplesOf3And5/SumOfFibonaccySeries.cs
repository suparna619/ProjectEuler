using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3And5
{
    class SumOfFibonaccySeries
    {
        public long SumOfEvenValuedTermsInTheFibonaccySeriesLessThanFourMillion()
        {
            var prev = 1; 
            var curr = 2;
            var term = 3;
            var total = 2;
            while (term <= 4000000)
            {
                var mid = prev;
                prev = curr;
                curr += mid; 
                if (term%2 == 0)
                {
                    total += curr;
                }
                term++;
            }
            return total;
        }
    }
}
