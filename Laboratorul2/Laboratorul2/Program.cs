using System;

namespace Laboratorul2
{
     class Program
     {
          static void Main(string[] args)
          {
               // Utilizare modelul Singleton pentru a obține o instanță de Calculator
               Calculator calculator = Calculator.GetInstance();

               Console.WriteLine("Calculator");
               Console.WriteLine("==========");
               Console.WriteLine();

               while (true)
               {
                    Console.Write("Introduceti primul numar: ");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.Write("Introduceti al doilea numar: ");
                    double num2 = double.Parse(Console.ReadLine());

                    Console.Write("Introduceti operatia (+, -, *, /) sau 'q' pentru a iesi din program:  ");
                    string op = Console.ReadLine();

                    if (op.ToLower() == "q")
                    {
                         break;
                    }

                    // Utilizare modelul Builder pentru a construi o instanță de Calculator cu atributele specificate
                    CalculatorBuilder builder = new CalculatorBuilder();
                    Calculator newCalculator = builder.WithNum1(num1).WithNum2(num2).WithOp(op).Build();

                    // Utilizare modelul Prototype pentru a clona instanța de Calculator și a o utiliza pentru a face calculele
                    CalculatorPrototype prototype = new CalculatorPrototype(newCalculator);
                    Calculator clonedCalculator = prototype.Clone();
                    double result = clonedCalculator.Calculate();

                    Console.WriteLine($"Rezultatul este: {result}");
                    Console.WriteLine();
               }
          }
     }
}
