using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns
{
     public interface ICalculatorObserver
     {
          void OnCalculation(CalculatorEvent e);
     }

     public class Display : ICalculatorObserver
     {
          public void OnCalculation(CalculatorEvent e)
          {
               Console.WriteLine($"Result: {e.Result}");
          }
     }
}
