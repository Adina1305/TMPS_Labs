using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns
{
     // 3. Command
     public interface ICommand
     {
          void Execute();
          void Undo();
     }

     public class CalculatorCommand : ICommand
     {
          private CalculatorSubject calculatorSubject;
          private double num1;
          private double num2;
          private ICalculatorStrategy strategy;
          private CalculatorEvent calculatorEvent;

          public CalculatorCommand(CalculatorSubject calculatorSubject, double num1, double num2, ICalculatorStrategy strategy, CalculatorEvent calculatorEvent)
          {
               this.calculatorSubject = calculatorSubject;
               this.num1 = num1;
               this.num2 = num2;
               this.strategy = strategy;
               this.calculatorEvent = calculatorEvent;
          }

          public void Execute()
          {
               double result = strategy.Calculate(num1, num2);
               calculatorEvent.Result = result;
               calculatorSubject.Notify(calculatorEvent);
          }

          public void Undo()
          {
               calculatorEvent.Result = Double.NaN;
               calculatorSubject.Notify(calculatorEvent);
          }
     }
}
