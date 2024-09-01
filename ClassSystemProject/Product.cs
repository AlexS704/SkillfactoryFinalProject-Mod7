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
        protected int IdProduct {get; set;}
        protected string NameProduct { get; set;}
        internal int Quantity {  get; set;}
        public double Price { get; private set; }
        public ConfectionerysType ConfectionerysType {  get; set; }
        public SoftToysType SoftToyType { get; set; }
        
        

    }

    public enum ConfectionerysType
    {
        CakeNapoleon,
        Сupcake,
        Сake
    }

    public enum SoftToysType
    {
        CatAndGuitar,
        SailorCat,
        BullyDog
    }





}
 