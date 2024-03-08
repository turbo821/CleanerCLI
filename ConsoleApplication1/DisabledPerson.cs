using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class DisabledClient : Client
    {
        public override void DisplayInfo()
        {
            throw new System.NotImplementedException();
        }
    }
}