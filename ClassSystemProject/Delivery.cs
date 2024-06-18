using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassSystemProject
{
   
    abstract class Delivery
    {
        public (string Country, string City, string Street, string NumberHome) Address;
        public double Distance; //в км
        public DateTime DateDelivery { get; private set; }  //формат: год, день, месяц, час, минуты, секунды
        public string Client;

        public abstract void SetDeliveryDate(DateTime deliveryDate);


        public Delivery()
        {
            SetDeliveryDate(DateTime.Now);
        }

        public Delivery(DateTime deliveryDate)
        {
            SetDeliveryDate(deliveryDate);
        }

        protected void ValidateDeliveryDate(DateTime deliveryDate)
        {
            if (deliveryDate < DateTime.MinValue || deliveryDate > DateTime.MaxValue)
            {
                throw new ArgumentOutOfRangeException("Некорректная дата доставки");
            }
        }

       


        public abstract void СostСalculation();


        //public Delivery(string Client, double Distance, string Address, double DateTimeDelivery)
        //{
        //    this.Client = Client;
        //    this.Distance = Distance;
        //    this.Address = Address;
        //    this.DateTimeDelivery = DateTimeDelivery;
        //}
    }
}
