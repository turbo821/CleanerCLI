using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class VipClient : Client
    {
        public VipClient(string firstName, string lastName)
            : base(firstName, lastName)
        { }
        public VipClient(string firstName, string lastName, string secondName)
            : base(firstName, lastName, secondName)
        { }
        public VipClient(string firstName, string lastName, Card card)
            : base(firstName, lastName, card)
        { }
        public VipClient(string firstName, string lastName, string secondName, Card card) :
            base(firstName, lastName, secondName, card)
        { }
    }
}