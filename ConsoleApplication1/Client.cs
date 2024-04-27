using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{

    public abstract class Client : IClient 
    {
        private int hitСounter = 0;

        public Client(string firstName, string lastName, string secondName, Card card)
        {
            FirstName = firstName;
            LastName = lastName;
            SecondName = secondName;
            Card = card;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondName { get; set; }
        public Card Card { get; set; }
        public bool Regular { get; private set; } = false;

        public void IncreaseCounter()
        { 
            hitСounter++;
            if (hitСounter  >= 3)
            {
                Regular = true;
            }
        }
        public abstract void DisplayInfo();
    }
}