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
        public string Adress;
        public string DeliveryTime;

        static double gasMileage;
        static double theCcostOfGasoline;
        double costOfTheMile = gasMileage * theCcostOfGasoline;



        public (string bicycleСourier, string footСourier, string transportDelivery, string deliveryByAir, string selfDelivery) TypeDelevery;

        

        //расчет стоимости
        public static double BillDeliveryStability()
        {
            if UserDelevery == TypeDelevery.Item5
            {
                return 0;
            }
            
            if UserDelevery == TypeDelevery.Item1
            {



            }

            

        }
    }
}
