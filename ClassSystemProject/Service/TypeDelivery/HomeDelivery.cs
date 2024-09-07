using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSystemProject
{
    //Доставка на дом
    class HomeDelivery : Delivery
    {

        private readonly decimal _homeDeliveryFee;
        internal (string Country, string City, string Street, string HouseNumber) Address;

        public HomeDelivery(decimal homeDeliveryFee)
        {
            _homeDeliveryFee = homeDeliveryFee;
        }


        public override decimal СostСalculation()
        {

            return base.СostСalculation() + _homeDeliveryFee;
        }

        public override void SetDeliveryDate(DateTime deliveryDate)
        {
            ValidateDeliveryDate(deliveryDate);
            DateDelivery = deliveryDate;
        }



        //Вызываем конструкторы базового класса
        public HomeDelivery() : base(DateTime.Now) { }

        public HomeDelivery(DateTime DateDelivery) : base(DateDelivery) { }

        public HomeDelivery((string Country, string City, string Street, string HouseNumber) address, decimal distance, decimal primeRate) : base(address, distance, primeRate)
        {
            Address = address;

        }






    }
}
