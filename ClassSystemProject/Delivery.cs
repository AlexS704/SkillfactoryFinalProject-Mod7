//Основной класс
//Класс, описывающий процесс доставки заказа.
//Может включать информацию о времени, стоимости и способе доставки.
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassSystemProject
{
    enum TypeDelivery
    {
        HomeDelivery,
        PointDelivery,
        MarketplaceDelivery
    }
    
    public abstract class Delivery
    {
        public (string Country, string City, string Street, string NumberHome) Address;
        public decimal Distance; //в км             
        private decimal _primeRate = 10.0m; //руб. за 1км
        public Delivery((string Country, string City, string Street, string NumberHome) address, decimal distance)    
        {
            Address = address;
            Distance = distance;
        }

        public static DateTime DateDelivery { get; protected set; }  //формат вывода: год, день, месяц, час, минуты, секунды
        //public string Client; - получить из класса IndividualClient

        public abstract void SetDeliveryDate(DateTime deliveryDate);


        // Конструктор по умолчанию, который устанавливает текущую дату доставки.
        public Delivery()
        {
            SetDeliveryDate(DateTime.Now);
        }

        // Конструктор с параметрами, который позволяет установить пользовательскую дату доставки.
        public Delivery(DateTime deliveryDate)
        {
            SetDeliveryDate(deliveryDate);
        }

        
        // Метод для проверки корректности даты доставки.
        protected void ValidateDeliveryDate(DateTime deliveryDate)
        {
            if (deliveryDate < DateTime.MinValue || deliveryDate > DateTime.MaxValue)
            {
                throw new ArgumentOutOfRangeException("Некорректная дата доставки");
            }
        }

        // Метод расчета стоимости доставки.
        public virtual decimal СostСalculation()
        {
            
            decimal resultСostСalculation = _primeRate * Distance;
            
            return resultСostСalculation;
        }
       
    }
}
