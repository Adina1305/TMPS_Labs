using System;
using System.Collections.Generic;

namespace Calculator
{
     public class Calculator
     {
          private readonly Dictionary<char, ICalculator> _operations;

          public Calculator()
          {
               _operations = new Dictionary<char, ICalculator>
            {
                    //selectarea uneia din operații
                {'1', new AddOperation()},
                {'2', new SubtractOperation()},
                {'3', new MultiplyOperation()},
                {'4', new DivideOperation()}
            };
          }

          public double Operate(char op, double a, double b)
          {
               //verificarea existenței operațiilor
               if (!_operations.TryGetValue(op, out var calculator))
               {
                    throw new InvalidOperationException($"Unsupported operation: {op}");
               }

               return calculator.Operate(a, b);
          }
     }
    
}
