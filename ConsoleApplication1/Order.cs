using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    public class Order<TypeClothing, TypeClient> : IDisplayable, IHaveQSList
        where TypeClothing : Clothing
        where TypeClient : IClient
    {
        private double discountOfDay = 0.02;
        private double discountOfRegular = 0.05;
        public Order(TypeClient client, Service<TypeClothing> service, Branch branch)
        {
            Client = client;
            Service = service;
            Branch = branch;
            ReceiptDate = DateTime.Now;

            FinalPrice = Service.Price;
            if (Service.Clothing.DiscountDay == ReceiptDate.DayOfWeek) FinalPrice *= 1 - discountOfDay;
            if (Client.Regular) FinalPrice = Math.Round(FinalPrice * 1 - discountOfRegular, 2);

            QualityAndSpeed = QualityAndSpeed + Service.QualityAndSpeed;
            if (Client is VipClient) { QualityAndSpeed += (Client as VipClient).privilege; }

            ResultTime = Math.Round(10 / (QualityAndSpeed.SpeedFactor), 3);
        }

        public TypeClient Client { get; private set; }
        public Service<TypeClothing> Service { get; private set; }
        public Branch Branch { get; private set; }
        public DateTime ReceiptDate { get; private set; }
        public DateTime? ReturnDate { get; private set; } = null;
        public double FinalPrice { get; private set; }
        public double ResultTime { get; private set; }
        public string QualityResult { get; private set; }
        public QualityAndSpeed QualityAndSpeed { get; private set; } = new QualityAndSpeed(new List<int> { 50, 50, 50, 50, 50 }, 1);

        private string SetQualityResult(int q)
        {
            if (q == 1) { return "Washed badly"; }
            else if (q == 2) { return "Washed satisfactorily"; }
            else if (q == 3) { return "Washed fine"; }
            else if (q == 4) { return "Washed well"; }
            else { return "Washed perfectly"; }
        }
        public void Washing()
        {
            if (ReturnDate == null)
            {
                bool paymentCompleted = Client.Card.Take(FinalPrice);
                if (paymentCompleted)
                {
                    Console.WriteLine("Washing in progress...");

                    List<int> extendQualityList = QualityAndSpeed.MakeExtendQualityList();

                    int qualityResultNumber = extendQualityList[new Random().Next(0, extendQualityList.Count)];
                    QualityResult = SetQualityResult(qualityResultNumber);


                    Thread.Sleep(Convert.ToInt32(ResultTime * 1000)); // wait time..

                    Client.IncreaseCounter();
                    ReturnDate = DateTime.Now;
                    Console.WriteLine("Washing done!");
                }
                else
                {
                    Console.WriteLine($"There is not enough money on the card, top up your account with {FinalPrice - Client.Card.Sum} rubles");
                }
            }
            else
            {
                Console.WriteLine("Order completed");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Order: final price: {FinalPrice}, wash time: {ResultTime}, final quality list: {QualityAndSpeed.DisplayList()}");
        }

        public void GetResult()
        {
            if (ReceiptDate != null)
            {
                Console.WriteLine($"The resulting wash quality: {QualityResult}\nLead time wash: {ResultTime}s");
                Console.WriteLine($"-{FinalPrice} rubles from the card, {Client.Card.Sum}rub remained");
            }
            else { Console.WriteLine($"Washing not completed"); }
        }
    }
}