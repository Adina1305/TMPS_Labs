using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns
{
     public class Calculator
     {
          private ICalculatorStrategy strategy;

          public Calculator(ICalculatorStrategy strategy)
          {
               this.strategy = strategy;
          }

          public void SetStrategy(ICalculatorStrategy strategy)
          {
               this.strategy = strategy;
          }

          public double Calculate(double num1, double num2)
          {
               return strategy.Calculate(num1, num2);
          }
     }
}
