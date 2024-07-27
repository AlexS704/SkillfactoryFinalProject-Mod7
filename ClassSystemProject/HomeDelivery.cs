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
        string Name = "Иван";
        string Surname = "Петров";
        private int age = 18; //добавить проверку на 0

       
          public HomeDelivery(string country, string city, string street, string numberHouse, DateTime DateDelivery) : base(DateDelivery)
        {
            Address.Country = country;
            Address.City = city;
            Address.Street = street;
            Address.NumberHome = numberHouse;
                        
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)

                {
                    Console.WriteLine("Для оформления доставки вам должно быть не меньше 18 лет");
                }

                else
                {
                    age = value;
                }
            }

        }

        public HomeDelivery(string name, string surname, int age) 
        {
            name = Name;
            surname = Surname;
            


        }
     
        


    }
}
