using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;

namespace ConsoleApplication1
{
    public class Allowance : IDisplayable, IHaveQSList, INotify
    {
        public event MessageHandler Notify;
        private int quality;
        private int speed;

        public Allowance(int quality, int speed)
        {
            Quality = quality;
            Speed = speed;
            SetTitle();
        }

        public QualityAndSpeed QualityAndSpeed { get; private set; } = new QualityAndSpeed();
        public string Title { get; private set; }
        public double PriceFactor { get; private set; }
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

        private void SetTitle()
        {
            string q = " quality and ";
            string s = " speed washing";
            if (quality == 1)
            { Title = "economy(E)" + q; }
            else if (quality == 2)
            { Title = "satisfactorily(D)" + q; }
            else if (quality == 3)
            { Title = "normal(C)" + q; }
            else if (quality == 4)
            { Title = "good(B)" + q; }
            else if (quality == 5)
            { Title = "great(A)" + q; }

            if (speed == 1)
            { Title = Title + "very slowly" + s; }
            else if (speed == 2)
            { Title = Title + "slowly" + s; }
            else if (speed == 3)
            { Title = Title + "normal" + s; }
            else if (speed == 4)
            { Title = Title + "fast" + s; }
            else if (speed == 5)
            { Title = Title + "very fast" + s; }
        }
        private void SetQualityAndSpeed()
        {
            if (quality == 1)
            { QualityAndSpeed.QualityList = new List<int>() { 25, 15, 5, -5, -10 }; }
            else if (quality == 2)
            { QualityAndSpeed.QualityList = new List<int>() { 15, 20, 10, -5, -5 }; }
            else if (quality == 3)
            { QualityAndSpeed.QualityList = new List<int>() { -3, 13, 20, 13, -3 }; }
            else if (quality == 4)
            { QualityAndSpeed.QualityList = new List<int>() { -15, -10, 5, 20, 15 }; }
            else if (quality == 5)
            { QualityAndSpeed.QualityList = new List<int>() { -20, -15, 5, 15, 25 }; }

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
            PriceFactor = Math.Round(1 + 0.20 * (quality - 1) + 0.18 * (speed - 1), 2);

        }

        public void DisplayInfo()
        {
            Notify?.Invoke(this, new CustomEventArgs($"Allowance: {Title}, default price will increase {PriceFactor} times"));
        }
        public void DescriptionQuality()
        {
            Notify?.Invoke(this, new CustomEventArgs("Quality:\n\t5 -> great(A)\n\t4 -> good(B)\n\t3 -> normal(C)\n\t2 -> satisfactorily(D)\n\t1 -> economy(E)"));
        }
        public void DescriptionSpeed()
        {
            Notify?.Invoke(this, new CustomEventArgs("Speed:\n\t5 -> very fast\n\t4 -> fast\n\t3 -> normal\n\t2 -> slowly\n\t1 -> very slowly"));
        }
    }
}