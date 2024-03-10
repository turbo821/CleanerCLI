using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Service
    {
        private Clothing clothing;
        private Allowance allowance;
        private double price;
        private QualityAndSpeed qualityAndSpeed;
        public Service(Clothing clothing, Allowance allowance) 
        {
            Clothing = clothing;
            Allowance = allowance;
            SetPrice();
            SetQualityAndSpeed();

        }

        public Clothing Clothing
        {
            get
            {
                return clothing;
            }
            set
            {
                clothing = value;
            }
        }
        public Allowance Allowance
        {
            get
            {
                return allowance;
            }

            set
            {
                allowance = value;
            }
        }
        public double Price
        {
            get { return price; }
        }
        public QualityAndSpeed QualityAndSpeed 
        {
            get { return qualityAndSpeed; } 
        }

        private void SetPrice()
        {
            price = Clothing.DefaultPrice * Allowance.PriceFastor;
        }
        private void SetQualityAndSpeed()
        {
            qualityAndSpeed = Clothing.QualityAndSpeed + Allowance.QualityAndSpeed;
        }
        public override string ToString()
        {
            return $"Clothing: {Clothing.Title}, Price washing - {Price}rub";
        }
    }
}