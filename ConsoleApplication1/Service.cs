using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Service
    {
        ServiceType serviceType;
        Allowance allowance;
        public ServiceType ServiceType
        {
            get
            {
                return serviceType;
            }

            set
            {
                serviceType = value;
            }
        }

        public Allowance Allowance
        {
            get
            {
                return allowance;
            }

            set
            {
                allowance = value;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {serviceType.Name} - Complexity: {allowance.Complexity}");
        }
    }
}