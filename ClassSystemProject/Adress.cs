using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSystemProject
{
    class Address : Delivery
    {
        
        internal string _country;
        internal string _city;
        internal string _street;
        internal string _houseNumber;

       

         //принимаем данные об адресе и передаем в поля       
        public Address(string country, string city, string street, string houseNumber)
        {
            _country = country;
            _city = city;
            _street = street;
            _houseNumber = houseNumber;
        }

        internal (string _country, string _city, string _street, string _houseNumber) _addressClient;
        
        
    }
}
