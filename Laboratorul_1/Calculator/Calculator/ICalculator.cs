using System;

namespace Calculator
{
     public interface ICalculator
     {
          double Operate(double a, double b);
     }

     public class AddOperation : ICalculator
     {
          public double Operate(double a, double b)
          {
               return a + b;
          }
     }

     public class SubtractOperation : ICalculator
     {
          public double Operate(double a, double b)
          {
               return a - b;
          }
     }

     public class MultiplyOperation : ICalculator
     {
          public double Operate(double a, double b)
          {
               return a * b;
          }
     }

     public class DivideOperation : ICalculator
     {
          public double Operate(double a, double b)
          {
               if (b == 0)
               {
                    throw new DivideByZeroException();
               }
               return a / b;
          }
     }
}