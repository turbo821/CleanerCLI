using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Clothing
    {
        private string title;
        private int size;
        private int pollutionLevel;

        public Clothing(string title, int size, int pollutionLevel)
        {
            this.title = title;
            this.size = size;
            this.pollutionLevel = pollutionLevel;
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
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
            }
        }
    }
}
