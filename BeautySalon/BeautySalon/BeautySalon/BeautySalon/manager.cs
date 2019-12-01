using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon
{
    public class manager : user
    {
        public string FirstName
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

        public manager(string firstname, string lastname, string salonWork, string userName, string password)
              : base(userName, password)
        {
            FirstName = firstname;
            LastName = lastname;
            SalonWork = salonWork;

            

        }

        private manager Manager;


        public override string identified()
        {
            {

                return "Type of user: ";
            }

        }

    }
}
