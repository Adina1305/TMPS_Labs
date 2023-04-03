using System;

namespace Laboratorul2
{
     // Interfața pentru clonarea instanțelor de Calculator
     interface ICalculatorPrototype
     {
          Calculator Clone();
     }

     // Clasa care implementează clonarea instanțelor de Calculator
     class CalculatorPrototype : ICalculatorPrototype
     {
          private Calculator calculator;

          public CalculatorPrototype(Calculator calculator)
          {
               this.calculator = calculator;
          }

          public Calculator Clone()
          {
               return (Calculator)calculator.Clone();
          }
     }
}
