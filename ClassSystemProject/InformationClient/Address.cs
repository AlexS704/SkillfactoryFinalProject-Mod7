//Основной класс
//Класс для хранения адреса клиента или пункта доставки.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSystemProject
{
    public class Address
    {
        internal (string _country, string _city, string _street, string _houseNumber) AddressClient;


        //принимаем данные об адресе и передаем в поля       
        public Address(string country, string city, string street, string houseNumber)
        {
            AddressClient._country = country;
            AddressClient._city = city;
            AddressClient._street = street;
            AddressClient._houseNumber = houseNumber;
        }

        public Address()
        {

        }



    }

}
