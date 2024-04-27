using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Card : INotify
    {
        public event MessageHandler Notify;
        public Card(string number, double sum)
        {
            this.Number = number;
            this.Sum = sum;
        }

        public double Sum { get; private set; }
        public string Number { get; private set; }

        public bool Take(double sum)
        {
            if (Sum >= sum)
            {
                 Sum -= sum;
                Notify?.Invoke(this, new CustomEventArgs($"Amount {sum} withdrawn from card {Number}"));
                return true;
            }
            else
            {
                Notify?.Invoke(this, new CustomEventArgs($"There is not enough money in the card {Number}"));
                return false;
            }
            
        }
        public bool Put(double sum)
        {
            Sum += sum;
            Notify?.Invoke(this, new CustomEventArgs($"Сredited to the card({Number}): {sum}"));
            return true;
        }
    }
}
