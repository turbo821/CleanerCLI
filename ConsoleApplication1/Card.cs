using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Card
    {
        private string number;
        public double Sum { get; private set; }
        public Card(string number, double sum)
        {
            this.number = number;
            this.Sum = sum;
        }
        public bool Take(double sum)
        {
            if (Sum >= sum)
            {
                 Sum -= sum;
                return true;
            }
            return false;
        }
    }
}
