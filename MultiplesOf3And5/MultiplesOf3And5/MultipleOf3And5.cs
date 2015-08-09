using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3And5
{
    public class MultipleOf3And5
    {
        public long SumOfTheMultiplesOf3And5BelowRange(long Range)
        {
            long sum = 0;
            for (int i = 1; i < Range; i++)
            {
                if (i%3 == 0 || i%5==0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
