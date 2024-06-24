using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSystemProject
{
    //Доставка на дом
    class HomeDelivery : Delivery
    {
        string Name = "Иван";
        string Surname = "Петров";
        int Age = 18; //добавить проверку на 0


        public override void SetDeliveryDate(DateTime deliveryDate)
        {
            ValidateDeliveryDate(deliveryDate);
            DateDelivery = deliveryDate;
        }


        //!!
        public override void СostСalculation()
        {
            throw new NotImplementedException();
        }

        //Вызываем конструкторы базового класса
        public HomeDelivery() : base(DateTime.Now) { }

        public HomeDelivery(DateTime DateDelivery) : base(DateDelivery) { }

        public HomeDelivery(string country, string city, string street, string numberHouse) : base(DateDelivery) //исправить
        {
            Address.Country = country;
            Address.City = city;
            Address.Street = street;
            Address.NumberHome = numberHouse;
                        
        }

        public HomeDelivery(string name, string surname, int age) 
        {
            name = Name;
            surname = Surname;
            

            if (age < 18) { Console.WriteLine("Вам нет 18 лет. Заказ невозможен"); }

            else age = Age;

        }
     
        


    }
}
