using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class VipClient : Client
    {
        public VipClient(string firstName, string lastName, string secondName)
            : base(firstName, lastName, secondName)
        { }
    }
}