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
        public override void DisplayInfo()
        {
            if (Regular)
            {
                Console.WriteLine($"Common Client:\n{FirstName} {SecondName} {LastName} (regular client)");
            }
            else
            {
                Console.WriteLine($"Common Client:\n{FirstName} {SecondName} {LastName} (not regular client)");
            }
        }
    }
}
