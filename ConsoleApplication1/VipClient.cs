using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class VipClient : Client
    {
        public readonly QualityAndSpeed privilege = new QualityAndSpeed(new List<int>() { 0, 0, 0, 15, 35 }, 1.25);

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
        public override void DisplayInfo()
        {
            if (Regular)
            {
                Console.WriteLine($"Vip Client: {FirstName} {SecondName} {LastName} (regular client)");
            }
            else
            {
                Console.WriteLine($"Vip Client: {FirstName} {SecondName} {LastName} (not regular client)");
            }
        }
    }
}