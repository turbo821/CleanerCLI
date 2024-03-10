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
            Client client1 = new CommonClient("Evgeny", "Terekhov", new Card("38492182", 700));
            Client client2 = new VipClient("Bill", "Gates", new Card("82912384", 120000));
            List<Client> persons = new List<Client>() { client1, client2 };

            Clothing cap = new Clothing("Cap", 1, 2);
            Clothing t_shirt = new Clothing("T-shirt", 3, 3);
            Clothing winterCoat = new Clothing("Winter coat", 5, 4);
            Clothing hat = new Clothing("Hat", 2, 1);
            Clothing trousers = new Clothing("Trousers", 4, 3);
            Clothing costume = new Clothing("Costume", 5, 5);
            List<List<Clothing>> clothings = new List<List<Clothing>>() { new List<Clothing> { cap, t_shirt, winterCoat }, new List<Clothing>{hat, trousers, costume } };
   
            Console.WriteLine("\t\t< < < Tender Cleaners > > >");
            Console.WriteLine("Welcome friend!\n");
            Console.WriteLine("Choose the number of who you are today:\n\t(1) --> Evgeny Terekhov - poor student\n\t(2) --> Bill Gates - Microsoft founder");
            Console.Write(">>> ");
            int persNum = Convert.ToInt32(Console.ReadLine())-1;
            Client client = persons[persNum];
            Console.WriteLine($"You {client}\n");

            Console.WriteLine("Select the number of the clothes:" );
            for (int c = 0; c < clothings[persNum].Count(); c++)
            {
                Console.WriteLine($"({c+1}) --> {clothings[persNum][c]}");
            }
            Console.Write(">>> ");
            int clNum = Convert.ToInt32(Console.ReadLine())-1;
            Clothing clothing = clothings[persNum][clNum];
            Console.WriteLine($"You select: {clothing}\n");

            Console.WriteLine("Select options:");
            Allowance.DescriptionQuality();
            Console.Write(">>> ");
            int quality = Convert.ToInt32(Console.ReadLine());

            Allowance.DescriptionSpeed();
            Console.Write(">>> ");
            int speed = Convert.ToInt32(Console.ReadLine());

            Allowance allowance = new Allowance(quality, speed);
            Console.WriteLine($"You Select options:{allowance}");

            Console.ReadKey();
        }

    }
}
