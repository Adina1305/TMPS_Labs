using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
     // Clasa abstracta CalculatorDecorator care implementeaza interfata ICalculator
     public abstract class CalculatorDecorator : ICalculator
     {
          private readonly ICalculator _calculator;

          //Constructorul pentru clasa abstracta CalculatorDecorator care primeste un obiect de tip ICalculator
          protected CalculatorDecorator(ICalculator calculator)
          {
               _calculator = calculator;
          }

          // Metoda virtuala Calculate care va fi suprascrisa in clasele derivate
          public virtual double Calculate(string expression)
          {
               return _calculator.Calculate(expression);
          }
     }

     //clasa LoggingCalculatorDecorator care mosteneste clasa abstracta CalculatorDecorator
     public class LoggingCalculatorDecorator : CalculatorDecorator
     {
          private readonly StreamWriter _logFile;

          public LoggingCalculatorDecorator(ICalculator calculator, string logFileName) : base(calculator)
          {
               _logFile = new StreamWriter(logFileName, append: true);
          }

          //Metoda Calculate pentru a inregistra operatiile efectuate in fisierul de log
          public override double Calculate(string expression)
          {
               var result = base.Calculate(expression);
               _logFile.WriteLine($"{expression} = {result}");
               return result;
          }

          //Închiderea fișierului log
          public void CloseLogFile()
          {
               _logFile.Close();
          }
     }

}
