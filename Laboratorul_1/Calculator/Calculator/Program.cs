using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator;

namespace Calculator
{
     class Program
     {
          static void Main(string[] args)
          {
               Calculator calculator = new Calculator();
               CalculatorApp calculatorApp = new CalculatorApp(calculator);
               calculatorApp.Run();
          }
     }
}
