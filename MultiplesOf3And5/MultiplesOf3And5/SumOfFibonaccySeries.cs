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
            var total = 2;
            while (curr <= 4000000)
            {
                var mid = prev;
                prev = curr;
                curr += mid; 
                if (curr%2 == 0)
                {
                    total += curr;
                }
            }
            return total;
        }
    }
}
