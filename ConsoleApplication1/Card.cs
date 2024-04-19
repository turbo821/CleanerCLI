using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Card
    {
        public Card(string number, double sum)
        {
            this.Number = number;
            this.Sum = sum;
        }

        public string Number { get; private set; }
        public double Sum { get; private set; }

        public bool Take(double sum)
        {
            if (Sum >= sum)
            {
                 Sum -= sum;
                return true;
            }
            return false;
        }
        public bool Put(double sum)
        {
            Sum += sum;
            return true;
        }
    }
}
