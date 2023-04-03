using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Calculator
{

     public class CalculatorApp
     {
          private readonly Calculator _calculator;

          public CalculatorApp(Calculator calculator)
          {
               _calculator = calculator;
          }

          public void Run()
          {
               Console.WriteLine("Calculator App\n");

               bool exit = false;

               do
               {
                    Console.WriteLine("Enter the first number:");
                    double a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the second number:");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nChoose an operation:");
                    Console.WriteLine("1. Add");
                    Console.WriteLine("2. Subtract");
                    Console.WriteLine("3. Multiply");
                    Console.WriteLine("4. Divide");

                    char op = Convert.ToChar(Console.ReadLine());

                    double result = _calculator.Operate(op, a, b);
                    Console.WriteLine($"\nResult: {result}");

                    Console.WriteLine("\nDo you want to perform another operation? (Y/N)");
                    char choice = Convert.ToChar(Console.ReadLine().ToUpper());

                    if (choice == 'N')
                    {
                         exit = true;
                    }

               } while (!exit);

               Console.WriteLine("\nPress any key to exit.");
               Console.ReadKey();
          }
     }
}
