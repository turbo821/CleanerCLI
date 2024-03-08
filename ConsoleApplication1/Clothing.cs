using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Clothing
    {
        private int size;
        private int pollutionLevel;
        public string Title {  get; set; }
        public QualityAndSpeed QualityAndSpeed { get; } = new QualityAndSpeed();

        public Clothing(string title, int size, int pollutionLevel)
        {
            Title = title;
            Size = size;
            PollutionLevel = pollutionLevel;
        }

        public int Size
        {
            get { return size; }
            set
            {
                if (size > 0 && size < 6)
                { size = value; }
                else if (size < 0)
                { size = 1; }
                else
                { size = 5; }
                SetQualityAndSpeed();
            }
        }
        public int PollutionLevel
        { 
            get { return pollutionLevel; } 
            set
            {
                if (pollutionLevel > 0 && pollutionLevel < 6)
                { pollutionLevel = value; }
                else if (pollutionLevel < 0)
                { pollutionLevel = 1; }
                else
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
            { QualityAndSpeed.QualityList = new List<int>() { 0, 0, 5, 10, 15 }; }
            else if (pollutionLevel == 2)
            { QualityAndSpeed.QualityList = new List<int>() { 0, 0, 7, 15, 7 }; }
            else if (pollutionLevel == 3)
            { QualityAndSpeed.QualityList = new List<int>() { 2, 5, 15, 5, 2 }; }
            else if (pollutionLevel == 4)
            { QualityAndSpeed.QualityList = new List<int>() { 7, 15, 5, 2, 0 }; }
            else if (pollutionLevel == 5)
            { QualityAndSpeed.QualityList = new List<int>() { 15, 10, 5, 0, 0 }; }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Clothing - {Title}, size - {Size}, pollution - {PollutionLevel}");
        }
    }
}
