using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSystemProject
{
    //Мягкая игрушка
    internal class SoftToy : Product
    {
        public int CurrentSoftToyQuantity { get; set; }

        private Dictionary<Product, int> quantities = new Dictionary<Product, int>();

        public void AddProduct(Product product, int quantity)
        {
            if (product.SoftToyType != null)
            {
                quantities[product] = quantity;
            }
            else
            {
                throw new ArgumentException("Product must have a soft toy type.");
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

        public static Dictionary<string, Guid> GenerateIDForSoftToyType(Type SoftToyYype)
        {
            if (!SoftToyYype.IsEnum)
            {
                throw new ArgumentException("Type must be an enumeration.");
            }

            var dictionarySoftToy = new Dictionary<string, Guid>();

            foreach (var value in Enum.GetValues(SoftToyYype))
            {
                string name = Enum.GetName(SoftToyYype, value.ToString());

                Guid id = Guid.NewGuid();

                dictionarySoftToy[name] = id;
            }

            return dictionarySoftToy;
        }

        public SoftToy(int quantity, int currentSoftToyQuantity)
        {
            Quantity = quantity;
            CurrentSoftToyQuantity = currentSoftToyQuantity;
        }

        public bool CheckAvailableQuantity(int CurrentSoftToyQuantity, int Quantity)
        {
            if (CurrentSoftToyQuantity < Quantity) { return false; }
            else { return true; }

        }


    }
}
