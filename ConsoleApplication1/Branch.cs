﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Branch
    {
        string title;

        public Branch(string title) { Title = title; }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public override string ToString()
        {
            return $"Branch in {Title}";
        }
    }

}