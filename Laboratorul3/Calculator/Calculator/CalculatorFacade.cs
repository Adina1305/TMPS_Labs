using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
     public class CalculatorFacade
     {
          //Instanțele claselor Calculator și CalculatorAdapter
          private readonly Calculator _calculator = new Calculator();
          private readonly CalculatorAdapter _calculatorAdapter = new CalculatorAdapter();

          public double Add(double num1, double num2)
          {
               return _calculator.Add(num1, num2);
          }

          public double Subtract(double num1, double num2)
          {
               return _calculator.Subtract(num1, num2);
          }

          public double Multiply(double num1, double num2)
          {
               return _calculator.Multiply(num1, num2);
          }

          public double Divide(double num1, double num2)
          {
               return _calculator.Divide(num1, num2);
          }

          public double Calculate(string expression)
          {
               return _calculatorAdapter.Calculate(expression);
          }
     }

}
