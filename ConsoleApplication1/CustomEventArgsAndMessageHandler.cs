using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public delegate void MessageHandler(object sender, CustomEventArgs e);

    public class CustomEventArgs : EventArgs
    {
        public string Message { get; }
        public DateTime DateTime { get; }

        public CustomEventArgs(string message)
        {
            Message = message;
            DateTime = DateTime.Now;
        }
    }
}
