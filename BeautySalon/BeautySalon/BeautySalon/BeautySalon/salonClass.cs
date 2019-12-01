using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon
{
    class salonClass
    {
        public List<appointment> appointmentsList;//array of class appointment.
        
        public string Name
        {
            get;
            private set;
        }
        public string City
        {
            get;
            private set;
        }
        public string Address
        {
            get;
            private set;
        }
        public salonClass(string name, string city, string address)
        {
            Address = address;
            City = city;
            Name = name;

           
        }

      

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
