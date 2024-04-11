using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Outerwear : Clothing
    {
        public new readonly DayOfWeek discountDay = DayOfWeek.Friday;
        public Outerwear(string title, int size, int pollutionLevel, double defaultPrice) 
            : base(title, size, pollutionLevel, defaultPrice) 
        { }
    }
}
