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

    public abstract class Delivery
    {
        protected readonly (string Country, string City, string Street, string NumberHome) _address;
        internal readonly decimal _distance; //в км             
        protected decimal _primeRate = 10.0m; //руб. за 1км
        internal DateTime DateDelivery;  //формат вывода: год, день, месяц, час, минуты, секунды
        public Delivery((string Country, string City, string Street, string NumberHome) address, decimal distance, decimal primeRate)
        {
            _address = address;
            _distance = distance;
            _primeRate = primeRate;
            DateDelivery = DateTime.Now;
        }




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
            decimal resultСostСalculation = _primeRate * _distance;

            return resultСostСalculation;
        }

    }
}
