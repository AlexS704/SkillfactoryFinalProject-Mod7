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
   
    abstract class Delivery
    {
        public (string Country, string City, string Street, string NumberHome) Address;
        public double Distance; //в км
        
        // Свойство для установки даты доставки.
        public DateTime DateDelivery { get; protected set; }  //формат: год, день, месяц, час, минуты, секунды
        public string Client;



        // Абстрактный метод для установки даты доставки.
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

        public Delivery((string Country, string City, string Street, string NumberHome) Address, double Distance, string Client) { }



        // Метод для проверки корректности даты доставки.
        protected void ValidateDeliveryDate(DateTime deliveryDate)
        {
            if (deliveryDate < DateTime.MinValue || deliveryDate > DateTime.MaxValue)
            {
                throw new ArgumentOutOfRangeException("Некорректная дата доставки");
            }
        }
         
        // Метод расчета стоимости доставки (нет полей).
        public abstract void СostСalculation();


        //public Delivery(string Client, double Distance, string Address, double DateTimeDelivery)
        //{
        //    this.Client = Client;
        //    this.Distance = Distance;
        //    this.Address = Address;
        //    this.DateTimeDelivery = DateTimeDelivery;
        //}
    }
}
