using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Underwear : Clothing
    {
        public override DayOfWeek DiscountDay { get; set; } = DayOfWeek.Saturday;
        public Underwear(string title, int size, int pollutionLevel, double defaultPrice)
            : base(title, size, pollutionLevel, defaultPrice)
        { }
    }
}
