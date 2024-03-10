using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Clothing dress = new Clothing("dress", 2, 3);
            Allowance allowance = new Allowance(5, 5);
            Client client = new CommonClient("Tom", "Smith");
            Card card = new Card("92831924", 113321);
            client.Card = card;
            Console.WriteLine(client);
            Console.ReadKey();
        }

    }
}
