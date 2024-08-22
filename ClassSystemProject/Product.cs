//Основной класс
//Класс для описания товаров, доступных для заказа.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSystemProject
{
    //Продукт
    abstract class Product
    {
        public int IdProduct { get; set; }

        public string NameProduct;
        public decimal Price { get; private set; }

        public string TypeProduct;

        public void Sell ()
        {
            //код для продажи продукта
        }

    }
}
 