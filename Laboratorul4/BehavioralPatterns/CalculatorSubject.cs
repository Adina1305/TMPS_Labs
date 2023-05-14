using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns
{
     public class CalculatorSubject
     {
          private List<ICalculatorObserver> observers = new List<ICalculatorObserver>();

          public void Attach(ICalculatorObserver observer)
          {
               observers.Add(observer);
          }

          public void Detach(ICalculatorObserver observer)
          {
               observers.Remove(observer);
          }

          public void Notify(CalculatorEvent e)
          {
               foreach (ICalculatorObserver observer in observers)
               {
                    observer.OnCalculation(e);
               }
          }
     }
}
