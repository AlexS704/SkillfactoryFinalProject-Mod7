//Основной класс
//Класс для описания заказа, включая товары, адрес доставки и другие параметры.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassSystemProject
{
    public enum OrderStatus
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


        public int Id { get; set; }


        public (string Name, string Surname, byte AgeInYars) Client;

        public Order(IndividualClient individualClient)
        {
            Client.Name = individualClient.Client._name;
            Client.Surname = individualClient.Client._surname;
            Client.AgeInYars = individualClient.Client._age;
        }



        public List<Product> Products { get; private protected set; }

        public OrderStatus Status { get; private set; }


        private Order()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product) { Products.Add(product); }

        public bool RemoveProduct(Product product) { return Products.Remove(product); }

        public List<Product> GetProducts() { return Products; }

        public double CalculateTotalPrice()
        {
            double totalPrice = 0.0;
            foreach (var product in Products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }




    }
}
