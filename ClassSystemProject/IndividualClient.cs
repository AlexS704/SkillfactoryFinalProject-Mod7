﻿//Основной класс
//Класс для представления индивидуального клиента, который делает заказ.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSystemProject
{
    //Частный клиент
    public class IndividualClient
    {
                
        internal (string _name, string _surname, byte _age) Client;
        internal (string Country, string City, string Street, string NumberHome) Address;

        public IndividualClient(string name, string surname, byte age)
        {

            Client._name = name;
            Client._surname = surname;

            if (age < 18)
            {
                Console.WriteLine("Вам еще нет 18 лет. Вы не можете оформить доставку!");
            }
            else
            {
                Client._age = age;
            }
                      

        }

        public IndividualClient(Address address)
        {
            Address = address.AddressClient;
        }
              
        public IndividualClient() { }

        

    }
}
