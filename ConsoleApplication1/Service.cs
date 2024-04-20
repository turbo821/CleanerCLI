using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Service<TypeClothing> : IDisplayable, IHaveQSList
        where TypeClothing : Clothing
    {
        private TypeClothing clothing;
        private Allowance allowance;
        public Service(TypeClothing clothing, Allowance allowance) 
        {
            Clothing = clothing;
            Allowance = allowance;
            Price = Math.Round(clothing.DefaultPrice * allowance.PriceFactor, 2);
            QualityAndSpeed = clothing.QualityAndSpeed + allowance.QualityAndSpeed;
        }

        public TypeClothing Clothing { 
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
                Price = Math.Round(Clothing.DefaultPrice * Allowance.PriceFactor, 2);
            }
        }
        private void SetQualityAndSpeed()
        {
            if (clothing != null && allowance != null)
                QualityAndSpeed = Clothing.QualityAndSpeed + Allowance.QualityAndSpeed;
        }
        public  void DisplayInfo()
        {
            Console.WriteLine($"Service: clothing - {Clothing.Title}, quality list - {QualityAndSpeed.DisplayList()}, speed factor - {QualityAndSpeed.SpeedFactor}, price: {Price}");
        }
    }
}