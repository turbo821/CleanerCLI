using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface IClient : IDisplayable
    {
        Card Card { get; set; }
        bool Regular { get; }
        void IncreaseCounter();
        Order MakeOrder(Service service, Branch branch);
    }
}
