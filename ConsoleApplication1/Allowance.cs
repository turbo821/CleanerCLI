using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Allowance
    {
        private string title;
        private QualityAndSpeed complexity;
        private double urgency;
        private decimal price;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public QualityAndSpeed Complexity
        {
            get { return complexity; }
            set { complexity = value; }
        }
        public double Urgency
        {
            get { return urgency; }
            set { urgency = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public void DisplayInfo()
        {
           
        }
    }
}