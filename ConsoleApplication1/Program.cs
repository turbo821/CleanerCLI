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
            Client client1 = new CommonClient("Evgeny", "Terekhov", "Igorevich", card1);
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

            (client1 as CommonClient).Notify += (sender, e) => Console.WriteLine(e.Message);
            client1.DisplayInfo();

            (client3 as LegalEntity).Notify += (sender, e) => Console.WriteLine(e.Message);
            client3.DisplayInfo();

            costume.Notify += (sender, e) => Console.WriteLine(e.Message);
            costume.DisplayInfo();

            moscow.Notify += (sender, e) => Console.WriteLine(e.Message);
            moscow.DisplayInfo();
            
            allowance.Notify += (sender, e) => Console.WriteLine(e.Message);
            allowance.DisplayInfo();

            service.Notify += (sender, e) => Console.WriteLine(e.Message);
            service.DisplayInfo();

            order.Notify += (sender, e) => Console.WriteLine(e.Message);
            order.Washing();
            order.DisplayInfo();

            Console.ReadKey();
        }

    }
}
