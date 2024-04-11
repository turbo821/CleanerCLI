using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Service : IDisplayable, IHaveQSList
    {
        private Clothing clothing = null;
        private Allowance allowance = null;
        public Service(Clothing clothing, Allowance allowance) 
        {
            Clothing = clothing;
            Allowance = allowance;
        }

        public Clothing Clothing { 
            get  { return clothing; }
            set  { clothing = value; SetPrice(); SetQualityAndSpeed(); } }
        public Allowance Allowance
        {
            get { return allowance; }
            set { allowance = value; SetPrice(); SetQualityAndSpeed(); }
        }
        public double Price { get; private set; }
        public QualityAndSpeed QualityAndSpeed { get; private set; }

        private void SetPrice()
        {
            if (clothing != null && allowance != null)
            {
                Price = Clothing.DefaultPrice * Allowance.PriceFactor;
            }
        }
        private void SetQualityAndSpeed()
        {
            if (clothing != null && allowance != null)
                QualityAndSpeed = Clothing.QualityAndSpeed + Allowance.QualityAndSpeed;
        }
        public  void DisplayInfo()
        {
            Console.WriteLine($"Service: clothing - {Clothing.Title}, quality list - {QualityAndSpeed.DisplayList()}, speed factor - {QualityAndSpeed.SpeedFactor}");
        }
    }
}