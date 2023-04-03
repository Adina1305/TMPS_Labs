using System;

namespace Laboratorul2
{
     public class Calculator
     {
          private static Calculator instance;
          public double Num1 { get; set; }
          public double Num2 { get; set; }
          public string Op { get; set; }

          public Calculator() { }

          public static Calculator GetInstance()
          {
               if (instance == null)
               {
                    instance = new Calculator();
               }
               return instance;
          }

          public Calculator(double num1, double num2, string op)
          {
               Num1 = num1;
               Num2 = num2;
               Op = op;
          }

          public double Calculate()
          {
               switch (Op)
               {
                    case "+":
                         return Num1 + Num2;
                    case "-":
                         return Num1 - Num2;
                    case "*":
                         return Num1 * Num2;
                    case "/":
                         return Num1 / Num2;
                    default:
                         throw new InvalidOperationException("Operatorul specificat nu este valid");
               }
          }

          public object Clone()
          {
               return new Calculator(Num1, Num2, Op);
          }
     }
}
