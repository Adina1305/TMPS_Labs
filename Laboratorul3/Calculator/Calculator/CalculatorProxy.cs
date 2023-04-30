using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
     public class CalculatorProxy : ICalculator
     {
          private readonly ICalculator _calculator;  // obiectul calculatorului original care va fi proxy
          private readonly LoggingCalculatorDecorator _loggingDecorator; // decoratorul pentru înregistrarea în fișierul de log

          // Constructorul inițializează obiectul calculatorului original și obiectul decoratorului de înregistrare
          public CalculatorProxy(ICalculator calculator)
          {
               _calculator = calculator;
               _loggingDecorator = new LoggingCalculatorDecorator(calculator, "calculation.log");
          }
          // Această metodă calculează expresia, înregistrează operația în fișierul de log și returnează rezultatul
          public double Calculate(string expression)
          {
               var result = _calculator.Calculate(expression);
               _loggingDecorator.CloseLogFile();
               return result;
          }
     }

}
