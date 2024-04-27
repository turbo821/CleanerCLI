using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class CommonClient : Client, INotify 
    {
        public event MessageHandler Notify;
        public CommonClient(string firstName, string lastName, string secondName, Card card) : 
            base(firstName, lastName, secondName, card)
        { }
        public override void DisplayInfo()
        {
            if (Regular)
            {
                Notify?.Invoke(this, new CustomEventArgs($"Common Client: {FirstName} {SecondName} {LastName} (regular client)"));
            }
            else
            {
                Notify?.Invoke(this, new CustomEventArgs($"Common Client: {FirstName} {SecondName} {LastName} (not regular client)"));
            }
        }
    }
}
