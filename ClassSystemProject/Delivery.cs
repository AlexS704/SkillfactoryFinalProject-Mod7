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

        static double gasMileage = 15; //на 100км пути
        static double theCostOfGasoline = 55;
        static double bicycleCourierFare = 10; //ставка на 1км
        static double planeFare = 10; //ставка на 1км
        static double distance; //в км ---> это надо откуда-то получать

        //расчет расхода на доставку автотранспортом на 1 км пути.
        //4 - коэффициент по стандартам на затрату расходов ГСМ и ремонт подвески + время на перевозку.
        
        double costOfTheMile = (gasMileage * theCostOfGasoline)/100 * 4;

        public static (string bicycleСourier, string footСourier, string transportDelivery, string deliveryByAir, string selfDelivery) TypeDelevery;





        //расчет стоимости  ---> скорее всего здесь нужен абстрактный метод, а реализацию в своем классе
        public static double BillDeliveryStability(double costOfTheMile, string userDelivery)
        {
                                   
            if (userDelivery == TypeDelevery.bicycleСourier)
            {
                return distance * bicycleCourierFare;

            }

            if (userDelivery == TypeDelevery.footСourier)
            {
                return 0; //заглушка
            }

            if (userDelivery == TypeDelevery.transportDelivery)
            {
                return 0; //заглушка
            }

            if (userDelivery == TypeDelevery.deliveryByAir)
            {
                return 0; //заглушка
            }


            return 0;
        }
    }
}
