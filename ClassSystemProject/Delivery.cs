using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSystemProject
{
   //Доставка
    abstract class Delivery
    {
        public (string Country, string City, string Street, string HouseNumber) Adress;
        public (string Month, byte Day) DeliveryTime;

        static double gasMileage = 15;
        static double theCostOfGasoline = 55;
        
        //расчет расхода на доставку автотранспортом на 1 км пути.
        //4 - коэффициент по стандартам на затрату расходов ГСМ и ремонт подвески + время на перевозку.
        double costOfTheMile = (gasMileage * theCostOfGasoline)/100 * 4;

        public static (string bicycleСourier, string footСourier, string transportDelivery, string deliveryByAir, string selfDelivery) TypeDelevery;





        //расчет стоимости
        public static double BillDeliveryStability(double costOfTheMile)
        {
            string userDelivery;          
            
            if (userDelivery = TypeDelevery.selfDelivery)
            {
                return 0;
            }

        }
    }
}
