using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorul2
{
     class ConcreteCreator : ICreator
     {
          public Calculator Create()
          {
               return Calculator.GetInstance();
          }
     }
}
