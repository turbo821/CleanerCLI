using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;

namespace ConsoleApplication1
{
    public class Allowance
    { 
        private int complexity;
        private int velocity;
        public string Title { get; set; }
        public double priceFactor;
        public QualityAndSpeed QualityAndSpeed { get; } = new QualityAndSpeed();

        public Allowance(string title, int complexity, int velocity)
        {
            Title = title;
            Complexity = complexity;
            Velocity = velocity;
        }

        public int Complexity
        {
            get { return complexity; }
            set { 
                if (complexity > 0 && complexity < 6)
                { complexity = value; }
                else if (complexity < 0)
                { complexity = 1; }
                else
                { complexity = 5; }
                SetQualityAndSpeed(); SetPrice();
            }
        }
        public int Velocity
        {
            get { return velocity; }
            set {
                if (velocity > 0 && velocity < 6)
                { velocity = value; }
                else if (velocity < 0)
                { velocity = 1; }
                else
                { velocity = 5; }
                SetQualityAndSpeed(); SetPrice();
            }
        }
        public double PriceFastor
        {
            get { return priceFactor; }
        }

        private void SetQualityAndSpeed()
        {
            if (velocity == 1)
            { QualityAndSpeed.SpeedFactor = 0.6; }
            else if (velocity == 2)
            { QualityAndSpeed.SpeedFactor = 0.8; }
            else if (velocity == 3)
            { QualityAndSpeed.SpeedFactor = 1; }
            else if (velocity == 4)
            { QualityAndSpeed.SpeedFactor = 1.2; }
            else if (velocity == 5)
            { QualityAndSpeed.SpeedFactor = 1.4; }

            if (complexity == 1)
            { QualityAndSpeed.QualityList = new List<int>() { 25, 15, 5, 0, 0 }; }
            else if (complexity == 2)
            { QualityAndSpeed.QualityList = new List<int>() { 15, 20, 10, 0, 0 }; }
            else if (complexity == 3)
            { QualityAndSpeed.QualityList = new List<int>() { 0, 13, 20, 13, 0 }; }
            else if (complexity == 4)
            { QualityAndSpeed.QualityList = new List<int>() { 0, 0, 5, 20, 15 }; }
            else if (complexity == 5)
            { QualityAndSpeed.QualityList = new List<int>() { 0, 0, 5, 15, 25 }; }
        }
        private void SetPrice()
        {
            priceFactor = 1 + 0.20 * complexity + 0.18 * velocity;

        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Allowance - {Title}, Velocity - {velocity}, complexity - {complexity}, priceFactor - {priceFactor}");
        }
    }
}