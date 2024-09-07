using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSystemProject
{
    //Доставка в маркетплейс
    class MarketplaceDelivery : Delivery
    {
        public int DeliveryPointNumber;


        public override void SetDeliveryDate(DateTime deliveryDate)
        {
            ValidateDeliveryDate(deliveryDate);
            DateDelivery = deliveryDate;
        }

        public MarketplaceDelivery() : base(DateTime.Now) { }

        public MarketplaceDelivery(int deliveryPointNumber)
        {
            DeliveryPointNumber = deliveryPointNumber;
        }
    }

    enum NameMarketplace
    {
        Ozon,
        WB,
        Yandex
    }
}
