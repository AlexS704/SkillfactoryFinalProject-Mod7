//Основной класс
//Класс для представления организации-клиента, которая делает заказ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClassSystemProject
{
    //Клиент - организация
    internal class OrganizationClient : Delivery
    {    
        
        private byte _organizationCode;
        private int _individualTaxNumber;

        public OrganizationClient(byte OrganizationCode, (string Country, string City, string Street, string NumberHome) address, decimal distance, int IndividualTaxNumber) : base(address, distance)
        {
            _organizationCode = OrganizationCode;
            _individualTaxNumber = IndividualTaxNumber;
        }

        public override void SetDeliveryDate(DateTime deliveryDate)
        {
            DateDelivery = deliveryDate;
        }


    }
}
