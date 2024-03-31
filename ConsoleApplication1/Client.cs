using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class Client
    {
        private int hitСounter = 0;

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
        public override string ToString()
        {
            if (Regular)
            {
                return $"{FirstName} {SecondName} {LastName} (constansy client)";
            }
            else
            {
                return $"{FirstName} {SecondName} {LastName} (not constansy client)";
            }
        }
        public Order MakeOrder(Service service, Branch branch)
        {
            return new Order(this, service, branch);
        }
    }
}