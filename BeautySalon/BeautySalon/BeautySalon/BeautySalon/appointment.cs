using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon
{
    class appointment

    {
        private DateTime DT;
        private int numOfappointment;
        private customer appCustomer;
        private staff stylist;
        private Salon appSalon;
        private ServiceClass appservice;

        public appointment(DateTime dt, int Numopp, customer NOC,
                           staff NOStylest, Salon NOSalon, ServiceClass TOServicee)
        {
            DT = dt;
            numOfappointment = Numopp;
            AppCustomer = NOC;
            stylist = NOStylest;
            appSalon = NOSalon;
            Appservice = TOServicee;
        }
        public DateTime dt
        {
            get
            {
                return DT;
            }
            set => DT = DateTime.Now;
        }

        public customer AppCustomer { get => appCustomer; set => appCustomer = value; }
        public staff Stylist { get => Stylist; set => Stylist = value; }
        public Salon AppSalon { get => appSalon; set => appSalon = value; }
        public ServiceClass Appservice { get => appservice; set => appservice = value; }
    }

}


