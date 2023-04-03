using System;

namespace Laboratorul2
{
     // Clasa care construiește instanțe ale Calculatorului
     public class CalculatorBuilder
     {
          private Calculator calculator;

          public CalculatorBuilder()
          {
               calculator = new Calculator();
          }

          public CalculatorBuilder WithNum1(double num1)
          {
               calculator.Num1 = num1;
               return this;
          }

          public CalculatorBuilder WithNum2(double num2)
          {
               calculator.Num2 = num2;
               return this;
          }

          public CalculatorBuilder WithOp(string op)
          {
               calculator.Op = op;
               return this;
          }

          public Calculator Build()
          {
               // Validare pentru a se asigura ca toate atributele Calculatorului au fost setate
               if (calculator.Num1 == 0 || calculator.Num2 == 0 || string.IsNullOrEmpty(calculator.Op))
               {
                    throw new InvalidOperationException("Nu au fost setate toate atributele Calculatorului");
               }

               return calculator;
          }
     }

}
