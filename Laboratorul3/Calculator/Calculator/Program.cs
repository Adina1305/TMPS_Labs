using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
     class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine("Calculator Adapter");
               Console.WriteLine("-------------------");
               Console.WriteLine("Enter an expression (e.g. 2 + 3):");

               var input = Console.ReadLine();
               Console.WriteLine($"Input: {input}");

               var adapter = new CalculatorAdapter();
               try
               {
                    var result = adapter.Calculate(input);
                    Console.WriteLine($"Result: {result}");
               }
               catch (Exception ex)
               {
                    Console.WriteLine($"Error: {ex.Message}. Expression: {input}");
               }

               Console.WriteLine("-------------------");
               Console.WriteLine("Press any key to exit...");
               Console.ReadKey();
          }


     }
}
