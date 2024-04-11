using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class Shoes : Clothing
    {
        public new readonly DayOfWeek discountDay = DayOfWeek.Monday;
        public Shoes(string title, int size, int pollutionLevel, double defaultPrice) 
            : base(title, size, pollutionLevel, defaultPrice)
        { }
    }
}
