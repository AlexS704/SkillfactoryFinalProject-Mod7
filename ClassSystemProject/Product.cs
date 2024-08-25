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
    class Product
    {
        protected int IdProduct;

        protected string NameProduct;
        public decimal Price { get; private set; }

        protected string TypeProduct;

        public void Sell ()
        {
            //код для продажи продукта
        }

    }
}
 