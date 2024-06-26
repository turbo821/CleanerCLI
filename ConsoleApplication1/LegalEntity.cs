﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class LegalEntity : IClient
    {
        private int hitСounter = 0;

        public LegalEntity(string company, Card card )
        {
            Card = card;
            Company = company;
        }

        public string Company { get; set; }
        public Card Card { get; set; }
        public bool Regular { get; private set; } = false;
        public void DisplayInfo()
        {
            if( Regular )
            {
                Console.WriteLine($"Legal Entity: company {Company} (regular company)");
            }
            else
            {
                Console.WriteLine($"Legal Entity: company {Company} (not regular company)");
            }
            
        }

        public void IncreaseCounter()
        {
            hitСounter++;
            if (hitСounter >= 3)
            {
                Regular = true;
            }
        }

        public Order MakeOrder(Service service, Branch branch) 
        {
            return new Order(this, service, branch);
        }
    }
}
