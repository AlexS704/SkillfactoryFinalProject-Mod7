using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassSystemProject
{
    //Корзина покупок
    internal class ShoppingCart
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public bool RemoveProduct(Product product)
        {
            return products.Remove(product);
        }

        public double CalculateTotalPrice()
        {
            double totalPrice = 0.0;
            foreach (var product in products)
            {
                totalPrice += product.Price * product.Quantity;
            }

            return totalPrice;
        }

        public void Clear() { products.Clear(); }

        public override string ToString()
        {
            return $"Товары в корзине: {string.Join(",", products)}";
        }
    }
}
