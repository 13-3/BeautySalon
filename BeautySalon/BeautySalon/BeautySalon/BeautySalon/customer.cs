using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon
{
    public class customer : user
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
        public string PhoneNum
        {
            get;
            private set;
        }

        public string Email
        {
            get;
            private set;
        }

        public customer(string firstName, string lastName, string phoneNum,string email, string UserName, string password)
            : base(UserName, password)
        {
            LastName = lastName;
            FirstName = firstName;
            PhoneNum = phoneNum;
            Email = email;
        }
        public override string identified()
        {
            {
                return " user as : ";
            }
        }
    }
}

