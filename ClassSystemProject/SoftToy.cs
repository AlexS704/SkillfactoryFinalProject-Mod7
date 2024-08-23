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
              
        private int QuantityCatAndGuitar = 12;
        private int QuantitySailorCat = 16;
        private int QuantityBullyDog = 9;
        
        //генерация GUID
        static Guid catAndGuitarID = Guid.NewGuid();
        static Guid sailorCatID = Guid.NewGuid();
        static Guid bullyDogID = Guid.NewGuid();

        //сохранение GUID в словаре
       private Dictionary<SoftToys, Guid> softToysIds = new Dictionary<SoftToys, Guid>
                {
                    {SoftToys.CatAndGuitar, catAndGuitarID},
                    {SoftToys.SailorCat, sailorCatID},
                    {SoftToys.BullyDog, bullyDogID},
                };


        private void OutputID()
        {
          //Guid selectedToyId = softToysIds[SoftToys.CatAndGuitar];
           
        }
        public int CheckAvailableQuantity (int quantity, int result)
        {
            bool CheckQuantity;

            //реализация
           
            return result;
        }

        

    }

    public enum SoftToys
    {
        CatAndGuitar,
        SailorCat,
        BullyDog
    }
}
