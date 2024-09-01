using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSystemProject
{
    //Кондитерские изделия
       
    internal class Confectionery : Product
    {
        public int CurrentConfectioneryQuantity { get; set; }
        
        //создаем связь продукт-количество
        private Dictionary<Product, int> quantities = new Dictionary<Product, int>();

        public void AddProduct(Product product, int quantity)
        {
            if (product.ConfectionerysType != null)
            {
                quantities[product] = quantity;
            }

            else
            {
                throw new ArgumentException("Product must have a confectionery type.");
            }
        }
        public int GetQuantity(Product product)
        {
            if (quantities.ContainsKey(product))
            {
                return quantities[product];
            }
            else return 0;
        }          
                
        //метод перебирает элементы перечисления, генерирует ID для каждого, добавляет в словарь и возвращает его
        public static Dictionary<string, Guid> GenerateIDForConfectionerysType(Type ConfectionerysType)
        {
            if (!ConfectionerysType.IsEnum)
            {
                throw new ArgumentException("Type must be an enumeration.");
            }

            var dictionaryConfectionery = new Dictionary<string, Guid>();

            
            foreach (var value  in Enum.GetValues(ConfectionerysType))
            {
                
                string name = Enum.GetName(ConfectionerysType, value.ToString);
                
                Guid id = Guid.NewGuid();                
                
                dictionaryConfectionery[name] = id;
            }

            return dictionaryConfectionery;
        }

        //получаем желаемое количество товара и текущее количество
        public Confectionery(int quantity, int currentConfectioneryQuantity)
        {
            Quantity = quantity;
            CurrentConfectioneryQuantity = currentConfectioneryQuantity;
        }

        //метод для проверки достумного количества типа кондитерского изделия
        public bool CheckAvailableQuantity(int CurrentConfectioneryQuantity, int Quantity)
        {
            if (CurrentConfectioneryQuantity > Quantity) {  return false; }
            else { return true; }            
                       
        }

    }

    
}
