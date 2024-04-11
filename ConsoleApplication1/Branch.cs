using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Branch : IDisplayable
    {
        public Branch(string title) { Title = title; }

        public string Title { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Branch in {Title}");
        }
    }

}