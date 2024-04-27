﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Branch : IDisplayable, INotify
    {
        public event MessageHandler Notify;
        public Branch(string title) { Title = title; }

        public string Title { get; set; }

        public void DisplayInfo()
        {
            Notify?.Invoke(this, new CustomEventArgs($"Branch in {Title}"));
        }
    }

}