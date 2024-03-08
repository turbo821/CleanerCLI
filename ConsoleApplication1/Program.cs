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
            Client client = new VipClient("ds", "sda", "dsa");
            client.FirstName = "Tom";
            client.LastName = "Fiill";
            client.DisplayInfo();
            Console.ReadKey();
        }

    }
}
