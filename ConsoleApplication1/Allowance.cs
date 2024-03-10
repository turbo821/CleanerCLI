using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;

namespace ConsoleApplication1
{
    public class Allowance
    {
        private string title;
        private int quality;
        private int speed;
        private double priceFactor;
        public QualityAndSpeed QualityAndSpeed { get; } = new QualityAndSpeed();

        public Allowance(int quality, int speed)
        {
            Quality = quality;
            Speed = speed;
            SetTitle();
        }

        public string Title { get { return title; } }
        public int Quality
        {
            get { return quality; }
            set { 
                if (value > 0 && value < 6)
                { quality = value; }
                else if (value < 0)
                { value = 1; }
                else if (value > 5)
                { quality = 5; }
                SetQualityAndSpeed(); SetPrice();
            }
        }
        public int Speed
        {
            get { return speed; }
            set {
                if (value > 0 && value < 6)
                { speed = value; }
                else if (value < 0)
                { value = 1; }
                else if (value > 5)
                { speed = 5; }
                SetQualityAndSpeed(); SetPrice();
            }
        }
        public double PriceFastor
        {
            get { return priceFactor; }
        }
        private void SetTitle()
        {
            string q = " quality and ";
            string s = " speed washing";
            if (quality == 1)
            { title = "economy(E)" + q; }
            else if (quality == 2)
            { title = "satisfactorily(D)" + q; }
            else if (quality == 3)
            { title = "normal(C)" + q; }
            else if (quality == 4)
            { title = "good(B)" + q; }
            else if (quality == 5)
            { title = "great(A)" + q; }

            if (speed == 1)
            { title = title + "very slowly" + s; }
            else if (speed == 2)
            { title = title + "slowly" + s; }
            else if (speed == 3)
            { title = title + "normal" + s; }
            else if (speed == 4)
            { title = title + "fast" + s; }
            else if (speed == 5)
            { title = title + "very fast" + s; }
        }
        private void SetQualityAndSpeed()
        {
            if (quality == 1)
            { QualityAndSpeed.QualityList = new List<int>() { 25, 15, 5, 0, 0 }; }
            else if (quality == 2)
            { QualityAndSpeed.QualityList = new List<int>() { 15, 20, 10, 0, 0 }; }
            else if (quality == 3)
            { QualityAndSpeed.QualityList = new List<int>() { 0, 13, 20, 13, 0 }; }
            else if (quality == 4)
            { QualityAndSpeed.QualityList = new List<int>() { 0, 0, 5, 20, 15 }; }
            else if (quality == 5)
            { QualityAndSpeed.QualityList = new List<int>() { 0, 0, 5, 15, 25 }; }

            if (speed == 1)
            { QualityAndSpeed.SpeedFactor = 0.6; }
            else if (speed == 2)
            { QualityAndSpeed.SpeedFactor = 0.8; }
            else if (speed == 3)
            { QualityAndSpeed.SpeedFactor = 1; }
            else if (speed == 4)
            { QualityAndSpeed.SpeedFactor = 1.2; }
            else if (speed == 5)
            { QualityAndSpeed.SpeedFactor = 1.4; }
        }
        private void SetPrice()
        {
            priceFactor = 1 + 0.20 * (quality - 1) + 0.18 * (speed - 1);

        }
        public override string ToString()
        {
            return $"{Title}, default price will increase {priceFactor} times";
        }
        public static void DescriptionQuality()
        {
            Console.WriteLine("Quality:\n\t5 -> great(A)\n\t4 -> good(B)\n\t3 -> normal(C)\n\t2 -> satisfactorily(D)\n\t1 -> economy(E)");
        }
        public static void DescriptionSpeed()
        {
            Console.WriteLine("Speed:\n\t5 -> very fast\n\t4 -> fast\n\t3 -> normal\n\t2 -> slowly\n\t1 -> very slowly");
        }
    }
}