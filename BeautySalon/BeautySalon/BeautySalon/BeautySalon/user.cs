using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon
{
   public abstract class user
    {
        public string UserName
        {
            get;
            private set;
        }
        public string Password
        {
            get;
            private set;
        }
        public user(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

       
        public abstract string identified();

         
          
          
           
        }
    }


