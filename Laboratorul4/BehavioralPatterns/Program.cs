using System;
using System.Collections.Generic;

namespace BehavioralPatterns
{
     class Program
     {
          static void Main(string[] args)
          {
               // 1. Strategy
               Calculator calculator = new Calculator(new AddStrategy());

               // 2. Observer
               CalculatorSubject calculatorSubject = new CalculatorSubject();
               Display display = new Display();
               calculatorSubject.Attach(display);

               // menu loop
               bool exit = false;
               while (!exit)
               {
                    Console.WriteLine("Please select an operation:");
                    Console.WriteLine("1. Add");
                    Console.WriteLine("2. Subtract");
                    Console.WriteLine("3. Exit");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                         case "1":
                              Console.Write("Enter the first number: ");
                              double num1 = Convert.ToDouble(Console.ReadLine());

                              Console.Write("Enter the second number: ");
                              double num2 = Convert.ToDouble(Console.ReadLine());

                              CalculatorEvent addEvent = new CalculatorEvent();
                              CalculatorCommand addCommand = new CalculatorCommand(calculatorSubject, num1, num2, new AddStrategy(), addEvent);
                              addCommand.Execute();
                              break;
                         case "2":
                              Console.Write("Enter the first number: ");
                              num1 = Convert.ToDouble(Console.ReadLine());

                              Console.Write("Enter the second number: ");
                              num2 = Convert.ToDouble(Console.ReadLine());

                              CalculatorEvent subtractEvent = new CalculatorEvent();
                              CalculatorCommand subtractCommand = new CalculatorCommand(calculatorSubject, num1, num2, new SubtractStrategy(), subtractEvent);
                              subtractCommand.Execute();
                              break;
                         case "3":
                              exit = true;
                              break;
                         default:
                              Console.WriteLine("Invalid choice. Please try again.");
                              break;
                    }

                    Console.WriteLine();
               }
          }
     }

}

