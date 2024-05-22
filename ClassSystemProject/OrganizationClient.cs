using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSystemProject
{
    //Клиент - организация
    internal class OrganizationClient : Delivery
    {
        private string _name;     
        

        public OrganizationClient(string name, string country, string city, string street, string numberHouse) : base(country, city, street, numberHouse)   
        {

            _name = name;
            
        }

        
        //!!!
        public override (string _country, string _city, string _street, string _houseNumber) GetAddress()
        {
         
            (string _country, string _city, string _houseNumber) _address;

        }
    }
}
