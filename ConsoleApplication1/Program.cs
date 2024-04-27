using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;
using System.IO;
using System.Text.Json;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // <creating objects>
            Card card1 = new Card("38492182", 800);
            CommonClient client1 = new CommonClient("Evgeny", "Terekhov", "Igorevich", card1);
            IClient client2 = new VipClient("Bill", "Gates", null, new Card("82912384", 120000));
            IClient client3 = new LegalEntity("Google", new Card("67235114", 16000000));

            Clothing cap = new Headdress("Cap", 1, 2, 300);
            Clothing t_shirt = new Underwear("T-shirt", 3, 3, 440);
            Clothing winterCoat = new Outerwear("Winter coat", 5, 4, 660);
            Clothing hat = new Headdress("Hat", 2, 1, 400);
            Clothing trousers = new Outerwear("Trousers", 4, 3, 640);
            Clothing costume = new Outerwear("Costume", 5, 5, 1120);

            Branch moscow = new Branch("Moscow");
            Branch berlin = new Branch("Berlin");
            Branch london = new Branch("London");

            Allowance allowance = new Allowance(3, 4);

            Service<Underwear> service = new Service<Underwear>((Underwear)t_shirt, allowance);

            Order<Underwear, VipClient> order = new Order<Underwear, VipClient>((VipClient)client2, service, berlin);

            // <list of objects that implement the interface INotify>
            List<INotify> listToAddNotify = new List<INotify>() { client1, costume, service, order };

            // <add an event handler DisplayRedToConsole to items>
            foreach (INotify item in listToAddNotify)
            {
                item.Notify += StaticMethods.DisplayRedToConsole;
                item.Notify += StaticMethods.LogToFile;
            }
            // <client events>
            client1.Notify += StaticMethods.DisplayToConsole;
            client1.DisplayInfo();
            Console.WriteLine();

            // <clothing events>
            costume.Notify += (sender, e) => Console.WriteLine(e.Message);
            costume.DisplayInfo();
            Console.WriteLine();

            // <service events>
            service.Notify += (sender, e) => Console.WriteLine(e.Message);
            service.Notify -= StaticMethods.DisplayRedToConsole;
            service.DisplayInfo();
            Console.WriteLine();

            // <order events>
            order.Notify += StaticMethods.DisplayToConsole;
            order.Notify -= StaticMethods.DisplayRedToConsole;
            order.Washing();
            order.DisplayInfo();
            Console.WriteLine("The End");

            Console.ReadKey();
        }

    }
}
