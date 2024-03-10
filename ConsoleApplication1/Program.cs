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
            Allowance allowance = new Allowance(5, 5);
            Console.WriteLine(allowance.Quality);
            Console.WriteLine(allowance.Speed);
            Console.WriteLine(allowance.Title);
            Clothing dress = new Clothing("dress", 2, 3);
            Console.WriteLine(dress);
            Console.ReadKey();
        }

    }
}
