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
        private QualityAndSpeed qsList = new QualityAndSpeed(new List<int> { 50, 50, 50, 50, 50 }, 1);

        public Order(Client client, Service service, Branch branch)
        { 
            Client = client;
            Service = service;
            Branch = branch;
            ReceiptDate = DateTime.Now;

            FinalPrace = Service.Price;
            if (Client.Regular) { FinalPrace *= 0.95; }
            
            qsList = qsList + Service.QualityAndSpeed;
            if (Client is VipClient) { qsList += ((VipClient)Client).privilege; }

            ResultTime = Math.Round(10 / (qsList.SpeedFactor), 3);
        }

        public Client Client { get; private set; }
        public Service Service { get; private set; }
        public Branch Branch { get; private set; }
        public DateTime? ReceiptDate { get; private set; }
        public DateTime? ReturnDate { get; private set; } = null;
        public double FinalPrace { get; private set; }
        public double ResultTime { get; private set; }
        public string QualityResult { get; private set; }

        private string SetQualityResult(int q)
        {
            if (q == 1) { return "Washed badly"; }
            else if (q == 2) { return "Washed satisfactorily"; }
            else if (q == 3) { return "Washed fine"; }
            else if (q == 4) { return "Washed well"; }
            else{ return "Washed perfectly"; }
        }
        public void Washing()
        {
            if(ReturnDate == null) 
            {
                bool paymentCompleted = Client.Card.Take(FinalPrace);
                if (paymentCompleted)
                {
                    Console.WriteLine("Washing in progress...");

                    List<int> extendQualityList = qsList.MakeExtendQualityList();

                    int qualityResultNumber = extendQualityList[new Random().Next(0, extendQualityList.Count)];
                    QualityResult = SetQualityResult(qualityResultNumber);

                    
                    Thread.Sleep(Convert.ToInt32(ResultTime*1000));

                    Client.IncreaseCounter();
                    ReturnDate = DateTime.Now;
                    Console.WriteLine("Washing done!");
                }
                else
                {
                    Console.WriteLine($"There is not enough money on the card, top up your account with {FinalPrace - Client.Card.Sum} rubles");
                }
            }
            else
            {
                Console.WriteLine("Order completed");
            }
        }

        public override string ToString()
        {
            return $"Final price: {FinalPrace}, Wash time: {ResultTime}, Final quality list: {qsList.DisplayList()}";
        }

        public void GetResult()
        {
            if(ReceiptDate != null)
            {
                Console.WriteLine($"The resulting wash quality: {QualityResult}\nLead time wash: {ResultTime}s");
                Console.WriteLine($"-{FinalPrace} rubles from the card, {Client.Card.Sum}rub remained");
            }
            else { Console.WriteLine($"Washing not completed"); }
        }
    }
}