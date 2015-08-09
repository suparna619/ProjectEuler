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
            var SumOfTheMultiplesOf3And5 = new MultipleOf3And5();
            Console.WriteLine(SumOfTheMultiplesOf3And5.SumOfTheMultiplesOf3And5BelowRange(1000));
            Console.ReadLine();
        }
    }
}
