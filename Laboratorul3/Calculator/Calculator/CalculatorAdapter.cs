using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
     public interface ICalculator
     {
          double Calculate(string expression);
     }

     public class CalculatorAdapter : ICalculator
     {
          private readonly Calculator _calculator = new Calculator();

          public double Calculate(string expression)
          {
               // Verificăm dacă expresia este într-un format corect
               var regex = new Regex(@"^\d+(\.\d+)?\s*[-+*/]\s*\d+(\.\d+)?$");
               if (!regex.IsMatch(expression))
               {
                    throw new ArgumentException("Invalid input format");
               }

               // Parsăm expresia și calculăm rezultatul
               var operands = expression.Split(' ');
               var operand1 = double.Parse(operands[0]);
               var operand2 = double.Parse(operands[2]);
               var op = operands[1];
               double result;

               switch (op)
               {
                    case "+":
                         result = operand1 + operand2;
                         break;
                    case "-":
                         result = operand1 - operand2;
                         break;
                    case "*":
                         result = operand1 * operand2;
                         break;
                    case "/":
                         result = operand1 / operand2;
                         break;
                    default:
                         throw new ArgumentException("Invalid operator");
               }

               return result;
          }

     }
}
