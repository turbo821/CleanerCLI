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
        private string firstName;
        private string lastName;
        private string secondName;
        private bool regular = false;
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
        public bool Regular
        {
            get { return regular; }
        }
        public void IncreaseCounter(){ hitСounter++; }
        public override string ToString()
        {
            if (regular)
            {
                return $"{FirstName} {secondName} {LastName} (constansy client)";
            }
            else
            {
                return $"{FirstName} {secondName} {LastName} (not constansy client)";
            }
        }
        public Order MakeOrder(Service service, Branch branch)
        {
            return new Order(this, service, branch);
        }
    }
}