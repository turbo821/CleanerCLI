using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Clothing : IDisplayable, IHaveQSList //shoes, outerwear, underwear, headdress
    {
        private int size;
        private int pollutionLevel;
        public readonly DayOfWeek discountDay;

        public Clothing(string title, int size, int pollutionLevel, double defaultPrice)
        {
            Title = title;
            Size = size;
            PollutionLevel = pollutionLevel;
            DefaultPrice = defaultPrice;
        }
        public string Title {  get; set; }
        public double DefaultPrice { get; set; }
        public QualityAndSpeed QualityAndSpeed { get; private set; } = new QualityAndSpeed();
        public int Size
        {
            get { return size; }
            set
            {
                if (value > 0 && value < 6)
                { size = value; }
                else if (value < 0)
                { size = 1; }
                else if(value > 5) 
                { size = 5; }
                SetQualityAndSpeed();
            }
        }
        public int PollutionLevel
        { 
            get { return pollutionLevel; } 
            set
            {
                if (value > 0 && value < 6)
                { pollutionLevel = value; }
                else if (value < 0)
                { pollutionLevel = 1; }
                else if (value > 5)
                { pollutionLevel = 5; }
                SetQualityAndSpeed();
            }
        }

        private void SetQualityAndSpeed()
        {
            if (size == 1)
            { QualityAndSpeed.SpeedFactor = 1.4; }
            else if (size == 2) 
            { QualityAndSpeed.SpeedFactor = 1.2; }
            else if (size == 3)
            { QualityAndSpeed.SpeedFactor = 1; }
            else if (size == 4)
            { QualityAndSpeed.SpeedFactor = 0.8; }
            else if (size == 5)
            { QualityAndSpeed.SpeedFactor = 0.6; }

            if (pollutionLevel == 1)
            { QualityAndSpeed.QualityList = new List<int>() { -20, -10, 0, 10, 20 }; }
            else if (pollutionLevel == 2)
            { QualityAndSpeed.QualityList = new List<int>() { -10, 0, 10, 10, 15 }; }
            else if (pollutionLevel == 3)
            { QualityAndSpeed.QualityList = new List<int>() { -7, -5, 17, 5, 2 }; }
            else if (pollutionLevel == 4)
            { QualityAndSpeed.QualityList = new List<int>() { 7, 15, 5, -5, -10 }; }
            else if (pollutionLevel == 5)
            { QualityAndSpeed.QualityList = new List<int>() { 20, 15, 0, -10, -15 }; }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Clothing: {Title}, size - {Size}, pollution - {PollutionLevel}, default price washing - {DefaultPrice} rub");
        }
    }
}
