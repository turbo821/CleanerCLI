using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    public class Order
    {
        private bool completed = false;
        private double priceFinal;
        private QualityAndSpeed qsList = new QualityAndSpeed(new List<int> { 50, 50, 50, 50, 50 }, 1);
        private DateTime receiptDate;
        private DateTime returnDate;
        private double timeResult;
        private string qualityResult;
        public Client Client { get; }
        public Service Service { get; }
        public Branch Branch { get; }

        public Order(Client client, Service service, Branch branch)
        { 
            Client = client;
            Service = service;
            Branch = branch;
        }

        public DateTime ReceiptDate
        {
            get
            {
                return receiptDate;
            }
        }
        public DateTime ReturnDate
        {
            get
            {
                return receiptDate;
            }
        }
        private string Check(int q)
        {
            if (q == 1) { return "Washed badly"; }
            else if (q == 2) { return "Washed satisfactorily"; }
            else if (q == 3) { return "Washed fine"; }
            else if (q == 4) { return "Washed well"; }
            else{ return "Washed perfectly"; }
        }
        public void Washing()
        {
            if(!completed) 
            {
                receiptDate = DateTime.Now;
                priceFinal = Service.Price;
                if (Client.Regular) { priceFinal *= 0.95; }
                bool paymentCompleted = Client.Card.Take(priceFinal);
                if (paymentCompleted)
                {
                    Console.WriteLine("Washing in progress...");
                    timeResult = 30 / (Service.QualityAndSpeed.SpeedFactor * qsList.SpeedFactor);
                    QualityAndSpeed qualityAndSpeed = qsList + Service.QualityAndSpeed;
                    List<int> extendQualityList = qualityAndSpeed.MakeExtendQualityList();
                    int qualityResultNumber = extendQualityList[new Random().Next(0, extendQualityList.Count)];
                    qualityResult = Check(qualityResultNumber);
                    Thread.Sleep(Convert.ToInt32(Math.Round(timeResult*1000)));
                    Client.IncreaseCounter();
                    completed = true;
                    returnDate = DateTime.Now;
                    Console.WriteLine("Washing done!");
                }
                else
                {
                    Console.WriteLine($"There is not enough money on the card, top up your account with {priceFinal - Client.Card.Sum} rubles");
                }
            }
        }
        public void GetResult()
        {
            if(completed)
            {
                Console.WriteLine($"The resulting wash quality: {qualityResult}\nLead time wash: {timeResult}s");
                Console.WriteLine($"-{priceFinal} rubles from the card, {Client.Card.Sum}rub remained");
            }
            else { Console.WriteLine($"Washing not completed"); }
        }
    }
}