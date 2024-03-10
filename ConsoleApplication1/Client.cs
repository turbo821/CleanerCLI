using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class Client
    {
        private int hitСounter = 0;
        private string firstName;
        private string lastName;
        private string secondName;
        private bool signConstancy = false;
        private Card card;

        public Client(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Client(string firstName, string lastName, Card card) : this(firstName, lastName)
        {
            Card = card;
        }
        public Client(string firstName, string lastName, string secondName) : this(firstName, lastName)
        {
            SecondName = secondName;
        }
        public Client(string firstName, string lastName, string secondName, Card card) : this(firstName, lastName, secondName)
        {
            Card = card;
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }
        public Card Card 
        { 
            get { return card; } 
            set { card = value; } 
        }
        public bool SignConstancy
        {
            get { return signConstancy; }
        }

        public override string ToString()
        {
            if (signConstancy)
            {
                return $"{FirstName} {secondName} {LastName} - constansy";
            }
            else
            {
                return $"{FirstName} {secondName} {LastName} - not constansy";
            }
            
        }
    }
}