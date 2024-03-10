using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class CommonClient : Client 
    {
        public CommonClient(string firstName, string lastName) 
            : base(firstName, lastName)
        { }
        public CommonClient(string firstName, string lastName, string secondName)
            : base(firstName, lastName, secondName)
        { }
        public CommonClient(string firstName, string lastName, Card card) 
            : base(firstName, lastName, card)
        { }
        public CommonClient(string firstName, string lastName, string secondName, Card card) : 
            base(firstName, lastName, secondName, card)
        { }
    }
}
