using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class LegalEntity : IClient, INotify
    {
        public event MessageHandler Notify;
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
                Notify?.Invoke(this, new CustomEventArgs($"Legal Entity:\nCompany {Company} (regular company)"));
            }
            else
            {
                Notify?.Invoke(this, new CustomEventArgs($"Legal Entity:\nCompany {Company} (not regular company)"));
            }
            
        }

        public void IncreaseCounter()
        {
            hitСounter++;
            if (hitСounter >= 3)
            {
                Notify?.Invoke(this, new CustomEventArgs($"{Company} is now a regular company"));
                Regular = true;
            }
        }
    }
}
