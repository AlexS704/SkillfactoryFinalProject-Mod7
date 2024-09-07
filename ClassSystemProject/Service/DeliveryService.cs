using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSystemProject
{
    public abstract class DeliveryService<T> where T : Delivery
    {
        public abstract decimal СostСalculation();
        public abstract DateTime EstimateDeliveryDate();
        public abstract bool IsAvailable();

        private readonly List<T> _deliveries = new List<T>();

        public void CrateDelivery(T delivery)
        {
            _deliveries.Add(delivery);
        }

        public T GetDeliveryById(int id)
        {
            return _deliveries.Find(d => d.Id == id); //пока не пойму в чем ошибка
        }

    }

}
