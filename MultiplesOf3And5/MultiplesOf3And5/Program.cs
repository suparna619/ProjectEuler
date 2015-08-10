using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Sum Of The Multiples Of 3 And 5 below 1000*/
//            var SumOfTheMultiplesOf3And5 = new MultipleOf3And5();
//            Console.WriteLine(SumOfTheMultiplesOf3And5.SumOfTheMultiplesOf3And5BelowRange(1000));

            /*Sum Of Even Valued Terms In TheFibonaccy Series where term is less than Four Million*/
            var sumOfFibonaccySeries = new SumOfFibonaccySeries();
            Console.WriteLine(sumOfFibonaccySeries.SumOfEvenValuedTermsInTheFibonaccySeriesLessThanFourMillion());
            Console.ReadLine();
        }
    }
}
