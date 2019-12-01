using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon
{
    public class staff:user
    {
        public string FirsttName
        {
            get;
            private set;
        }
        public string LastName
        {
            get;
            private set;
        }
        public string SalonWork
        {
            get;
            private set;
        }
        public string StaffMem
        {
            get;
            private set;
        }
        public string Service
        {
            get;
            private set;
        }

        public staff(string firstName, string lastName, string salonWork, string staffMem, string service
                  , string UserName, string password)
                  : base(UserName, password)
        {
            FirsttName = firstName;
            LastName = lastName;
            SalonWork = salonWork;
            StaffMem = staffMem;
            Service = service;
        }
        public override string identified()
        {

            return "Type of user: ";
        }
    }
}


