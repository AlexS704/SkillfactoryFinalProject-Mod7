using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClassSystemProject
{
    internal class HomeDeliveryService : DeliveryService<HomeDelivery>
    {

        private readonly List<Order<Delivery>> _orders = new List<Order<Delivery>>();
        public void CreateOrder(Order<Delivery> order)
        {
          _orders.Add(order);  
        }

        public Order<Delivery> GetOrderById(int id)
        {
            return _orders.Find(o => o.Id == id);
        }

        public void UpdateOrderAddress(int id, (string Country, string City, string Street, string HouseNumber) address)
        {
            var order = GetDeliveryById(id);
            if (order != null)
            {
                order.Address = address;
            }
        }

        public void NotinfiCustomer(int id, OrderStatus status)
        {
            var order = GetOrderById(id);
            if ( order != null)
            {
                //логика уведомления клиента о статусе заказа
                Console.WriteLine($"Статус заказа {id}: {status}");
            }
        }


        public void DeliveryOrder(int id)
        {
            var order = GetOrderById(id);
            if (order != null)
            {
                //логика выполнения доставки
                Console.WriteLine($"Заказ {id} успешно доставлен.");
            }
        }

        //не реализованы:
        public override DateTime EstimateDeliveryDate()
        {
            throw new NotImplementedException();
        }

        public override bool IsAvailable()
        {
            throw new NotImplementedException();
        }

        public override decimal СostСalculation()
        {
            throw new NotImplementedException();
        }

    }
}
