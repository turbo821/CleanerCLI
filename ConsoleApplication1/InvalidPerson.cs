using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class InvalidClient : Client
    {
      public InvalidClient(string firstName, string lastName, string secondName)
    : base(firstName, lastName, secondName)
        { }
    }
}