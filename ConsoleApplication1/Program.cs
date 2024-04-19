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
        static async Task Main(string[] args)
        {
            // creating objects
            Card card1 = new Card("38492182", 800);
            IClient client1 = new CommonClient("Evgeny", "Terekhov", "Igorevich", card1);
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
            //Order order = client2.MakeOrder(service, berlin);

            // writing and reading to a json file for each object of a certain class

            // for Branch
            await JsonFileManager.Write<Branch>("json/branch.json", berlin);
            Branch branchFile = await JsonFileManager.Read<Branch>("json/branch.json");
            branchFile.DisplayInfo();
            // for Allowance
            await JsonFileManager.Write<Allowance>("json/allowance.json", allowance);
            Allowance allowanceFile = await JsonFileManager.Read<Allowance>("json/allowance.json");
            allowanceFile.DisplayInfo();
            // for Card
            await JsonFileManager.Write<Card>("json/card.json", card1);
            Card cardFile = await JsonFileManager.Read<Card>("json/card.json");
            Console.WriteLine(cardFile.Number);

            // for Client
            await JsonFileManager.Write<VipClient>("json/client.json", (VipClient)client2);
            VipClient clientFile = await JsonFileManager.Read<VipClient>("json/client.json");
            clientFile.DisplayInfo();

            // for LegalEntity
            await JsonFileManager.Write<LegalEntity>("json/legalEntity.json", (LegalEntity)client3);
            LegalEntity legalEntityFile = await JsonFileManager.Read<LegalEntity>("json/legalEntity.json");
            legalEntityFile.DisplayInfo();

            // for Clothing
            await JsonFileManager.Write<Clothing>("json/clothing.json", t_shirt);
            Underwear clothingFile = await JsonFileManager.Read<Underwear>("json/clothing.json");
            clothingFile.DisplayInfo();

            // for Service
            await JsonFileManager.Write<Service<Underwear>>("json/service.json", service);
            Service<Underwear> serviceFile = await JsonFileManager.Read<Service<Underwear>>("json/service.json");
            serviceFile.DisplayInfo();

            // for Order


            Console.ReadKey();
        }

    }
}
