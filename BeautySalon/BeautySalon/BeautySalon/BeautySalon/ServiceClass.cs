using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon
{
    class ServiceClass
    {
        private string serviceName, serviceType;
        private staff staffMem;
        private double servicePrice;

        public ServiceClass(string name, string type, double price, staff member)
        {
            ServiceName = name;
            ServiceType = type;
            ServicePrice = price;
            StaffMem = member;
        }

        public string ServiceType
        {
            get
            {
                return serviceType;
            }

            private set
            {
                if (value.Equals("Hair") || value.Equals("Nails"))
                    serviceType = value;

            }
        }

        public string ServiceName { get; private set; }
        public double ServicePrice { get; private set; }
        public staff StaffMem { get; set; }

        public double serviceTotalPrice()
        {

            return ServicePrice ;
        }
    }
}

