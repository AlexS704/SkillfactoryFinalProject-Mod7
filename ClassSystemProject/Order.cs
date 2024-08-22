//Основной класс
//Класс для описания заказа, включая товары, адрес доставки и другие параметры.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSystemProject
{
    //Заказ
    public enum OrderStatus : byte
    {
        Accepted,
        InProgress,
        Delivered,
        Completed,
        Cancelled,
        Pending,
        ReturnOrder
    }
    
    class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery Delivery { get; private set; }

        public int IdOrder { get; private set; }

        //public string Description;

        public (string Name, string Surname, byte AgeInYars) Client;

       
        public List<Product> Products { get; private protected set; }
                       
        public OrderStatus Status { get; private set; }

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        private Order()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product) { Products.Add(product); }

        public bool RemoveProduct(Product product) { return Products.Remove(product); }

        public List<Product> GetProducts() {  return Products; }

        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0m;
            foreach (var product in Products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }

        
    }
}
