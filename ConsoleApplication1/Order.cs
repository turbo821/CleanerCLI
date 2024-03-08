using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Order
    {
        Client client;
        Service service;
        Branch branch;
        DateTime receiptDate;
        DateTime returnDate;
        public Client Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
            }
        }

        public Service Service
        {
            get
            {
                return service;
            }

            set
            {
                service = value;
            }
        }

        public Branch Branch
        {
            get
            {
                return branch;
            }

            set
            {
                branch = value;
            }
        }

        public DateTime ReceiptDate
        {
            get
            {
                return receiptDate;
            }

            set
            {
                receiptDate = value;
            }
        }

        public DateTime ReturnDate
        {
            get
            {
                return receiptDate;
            }

            set
            {
                receiptDate = value;
            }
        }

        public void OrderService()
        {
            throw new System.NotImplementedException();
        }
    }
}