using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.Model
{
    internal class Aboniment
    {
        private readonly List<ClubServices> services;
        public string Name { get; }
        public float TotalPrice { get; }
        public int Duration { get; }
        private readonly PaymentType PaymentType;

        public Aboniment(string Name,int Duration,List<ClubServices> services, PaymentType PaymentType)
        {
            this.Name = Name;
            this.services = services;
            this.Duration = Duration;
            this.PaymentType = PaymentType;
            foreach (ClubServices service in this.services) 
            {
                if(service.PaymentType == PaymentType) 
                {
                    TotalPrice += service.Price * Duration;
                }
                if(service.PaymentType == PaymentType.OnePayTime)
                {
                    TotalPrice += service.Price;
                }
            }
        }
    }
}
