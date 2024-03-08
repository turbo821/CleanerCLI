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
            Allowance allowance = new Allowance("very premium", 5, 5);
            allowance.DisplayInfo();
            Clothing dress = new Clothing("dress", 2, 3);
            dress.DisplayInfo();
            Console.ReadKey();
        }

    }
}
