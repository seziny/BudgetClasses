using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BudgetClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrencyType test = CurrencyType.EUR;

            Console.WriteLine(test.ToString());

            Console.WriteLine("Done.");
            Console.ReadKey();
        }
    }
}
