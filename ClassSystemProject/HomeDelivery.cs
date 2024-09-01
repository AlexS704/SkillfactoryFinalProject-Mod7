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

        public HomeDelivery(string country, string city, string street, string numberHouse) : base(DateDelivery)
        {            
            Address.Country = country;
            Address.City = city;
            Address.Street = street;
            Address.NumberHome = numberHouse;
                        
        }
               

        

    }
}
