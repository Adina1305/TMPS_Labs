using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns
{
     // 1. Strategy
     public interface ICalculatorStrategy
     {
          double Calculate(double num1, double num2);
     }

     public class AddStrategy : ICalculatorStrategy
     {
          public double Calculate(double num1, double num2)
          {
               return num1 + num2;
          }
     }

     public class SubtractStrategy : ICalculatorStrategy
     {
          public double Calculate(double num1, double num2)
          {
               return num1 - num2;
          }
     }
}
