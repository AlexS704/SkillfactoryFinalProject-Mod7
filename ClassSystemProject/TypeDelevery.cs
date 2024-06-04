using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSystemProject
{
    internal class TypeDelevery : Delivery
    {
        private static double _gasMileage = 0; //на 100км пути
        private static double _theCostOfGasoline = 0;
        private static double _bicycleCourierFare = 0; //ставка на 1км
        private static double _planeFare = 0; //ставка на 1км

        //расчет расхода на доставку автотранспортом на 1 км пути.
        //4 - коэффициент по стандартам на затрату расходов ГСМ и ремонт подвески + время на перевозку.

        

        private static (string bicycleСourier, string footСourier, string transportDelivery, string deliveryByAir, string selfDelivery) _typeDelevery;


        public override double СostСalculation(string typeDelevery)
        {
            double costOfTheMile;

            double resoult;

                        
            if (typeDelevery == _typeDelevery.selfDelivery)
            {
                costOfTheMile = 0;
            }

            if (typeDelevery == _typeDelevery.transportDelivery)
            {
                costOfTheMile = (_gasMileage * _theCostOfGasoline) / 100 * 4;

                resoult = costOfTheMile * Distance;

                return resoult;
            }
            
            

            
            
            return resoult;
        }


        //расчет стоимости 

        //private static double _billDeliveryStability(double distance, string UserSelectedDelivery)
        //{

        //    if (UserSelectedDelivery == _typeDelevery.bicycleСourier)
        //    {
        //        return distance * bicycleCourierFare;

        //    }

        //    if (UserSelectedDelivery == _typeDelevery.footСourier)
        //    {
        //        return 0; //заглушка
        //    }

        //    if (UserSelectedDelivery == _typeDelevery.transportDelivery)
        //    {
        //        return 0; //заглушка
        //    }

        //    if (UserSelectedDelivery == _typeDelevery.deliveryByAir)
        //    {
        //        return 0; //заглушка
        //    }


        //    return 0;
        //}

        //public static Delivery(double distance, string UserSelectedDelivery)
        //{
        //    if (UserSelectedDelivery == _typeDelevery.selfDelivery)
        //    {
        //        _billDeliveryStability(distance, UserSelectedDelivery);
        //        return;
        //    }


        //    if (UserSelectedDelivery == _typeDelevery.bicycleСourier)
        //    {
        //        _billDeliveryStability(distance, UserSelectedDelivery);
        //        return;
        //    }

        //    if (UserSelectedDelivery == _typeDelevery.footСourier)
        //    {
        //        _billDeliveryStability(distance, UserSelectedDelivery);
        //        return;
        //    }

        //    if (UserSelectedDelivery == _typeDelevery.transportDelivery)
        //    {
        //        _billDeliveryStability(distance, UserSelectedDelivery);
        //        return;
        //    }

        //    if (UserSelectedDelivery == _typeDelevery.deliveryByAir)
        //    {
        //        _billDeliveryStability(distance, UserSelectedDelivery);
        //        return;
        //    }
        //}


    }
}
