using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSystemProject
{
    public abstract class TypeDelevery
    {
        private static decimal _gasMileage = 0; //на 100км пути
        private static decimal _theCostOfGasoline = 0;
        private static decimal _bicycleCourierFare = 0; //ставка на 1км
        private static decimal _planeFare = 0; //ставка на 1км
        private readonly Delivery _delivery;
        private readonly string _type;

        //расчет расхода на доставку автотранспортом на 1 км пути.
        //4 - коэффициент по стандартам на затрату расходов ГСМ и ремонт подвески + время на перевозку.


        private static (string bicycleСourier, string footСourier, string transportDelivery, string deliveryByAir, string selfDelivery) _typeDelevery;

        protected TypeDelevery(Delivery delivery, string type)
        {
            _delivery = delivery;
            _type = type;
        }

        public string Type => _type;

        public DateTime DateDelivery => _delivery.DateDelivery;
        public decimal СostСalculation(string typeDelevery)
        {
            decimal costOfTheMile;

            decimal resoult = 0;


            if (typeDelevery == _typeDelevery.selfDelivery)
            {
                costOfTheMile = 0;
            }

            if (typeDelevery == _typeDelevery.transportDelivery)
            {
                costOfTheMile = _gasMileage * _theCostOfGasoline / 100 * 4;

                resoult = costOfTheMile * _delivery._distance;

                return resoult;
            }



            return resoult;
        }


    }
}
