using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class VipClient : Client, INotify
    {
        public event MessageHandler Notify;
        public readonly QualityAndSpeed privilege = new QualityAndSpeed(new List<int>() { 0, 0, 0, 15, 35 }, 1.25);

        public VipClient(string firstName, string lastName, string secondName, Card card) :
            base(firstName, lastName, secondName, card)
        { }
        public override void DisplayInfo()
        {
            if (Regular)
            {
                Notify?.Invoke(this, new CustomEventArgs($"Vip Client: {FirstName} {SecondName} {LastName} (regular client)"));
            }
            else
            {
                Notify?.Invoke(this, new CustomEventArgs($"Vip Client: {FirstName} {SecondName} {LastName} (not regular client)"));
            }
        }
    }
}