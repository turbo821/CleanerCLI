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

        public Client(string firstName, string lastName, string secondName) 
        {
            FirstName = firstName;
            LastName = lastName;
            SecondName = secondName;
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

        public bool SignConstancy
        {
            get { return signConstancy; }
        }


        public virtual void DisplayInfo()
        {
            if (signConstancy)
            {
                Console.WriteLine($"{FirstName} {LastName} - постоянный");
            }
            else
            {
                Console.WriteLine($"{FirstName} {LastName} - непостоянный");
            }
            
        }
    }
}