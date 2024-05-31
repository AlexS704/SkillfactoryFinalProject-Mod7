using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSystemProject
{
   
    abstract class Delivery
    {
        public (string Country, string City, string Street, string HouseNumber) Adress;
        public (string Month, byte Day) DeliveryTime;
        public double DeliveryCost;

        private static double _gasMileage = 15; //на 100км пути
        private static double _theCostOfGasoline = 55;
        private static double _bicycleCourierFare = 10; //ставка на 1км
        private static double _planeFare = 10; //ставка на 1км
        
        //расчет расхода на доставку автотранспортом на 1 км пути.
        //4 - коэффициент по стандартам на затрату расходов ГСМ и ремонт подвески + время на перевозку.
        
        private double _costOfTheMile = (_gasMileage * _theCostOfGasoline)/100 * 4;

        private static (string bicycleСourier, string footСourier, string transportDelivery, string deliveryByAir, string selfDelivery) _typeDelevery;


        //расчет стоимости 
        private static double _billDeliveryStability(double distance, string UserSelectedDelivery)
        {

            if (UserSelectedDelivery == _typeDelevery.bicycleСourier)
            {
                return distance * bicycleCourierFare;

            }

            if (UserSelectedDelivery == _typeDelevery.footСourier)
            {
                return 0; //заглушка
            }

            if (UserSelectedDelivery == _typeDelevery.transportDelivery)
            {
                return 0; //заглушка
            }

            if (UserSelectedDelivery == _typeDelevery.deliveryByAir)
            {
                return 0; //заглушка
            }


            return 0;
        }

        public Delivery(double distance, string UserSelectedDelivery)
        {
            if (UserSelectedDelivery == _typeDelevery.selfDelivery)
            {
                _billDeliveryStability(distance, UserSelectedDelivery);
                return;
            }


            if (UserSelectedDelivery == _typeDelevery.bicycleСourier)
            {
                _billDeliveryStability(distance, UserSelectedDelivery);
                return;
            }

            if (UserSelectedDelivery == _typeDelevery.footСourier)
            {
                _billDeliveryStability(distance, UserSelectedDelivery);
                return;
            }

            if (UserSelectedDelivery == _typeDelevery.transportDelivery)
            {
                _billDeliveryStability(distance, UserSelectedDelivery);
                return;
            }

            if (UserSelectedDelivery == _typeDelevery.deliveryByAir)
            {
                _billDeliveryStability(distance, UserSelectedDelivery);
                return;
            }
        }

    }
}
