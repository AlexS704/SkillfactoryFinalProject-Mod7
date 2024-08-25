using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSystemProject
{
    //Кондитерские изделия
    internal class Confectionery : Product
    {
           
        
        public int CakeNapoleon = 4;
        public int Сupcake = 16;
        public int Сake = 23;

        static Guid CakeNapoleonID = Guid.NewGuid();
        static Guid СupcakenID = Guid.NewGuid();
        static Guid СakeID = Guid.NewGuid();

        private void OutputID()
        {
            //Guid selectedConfectioneryID = ConfectioneryIDs[ConfectioneryList.CakeNapoleon]
        }

        public int CheckAvailableQuantity(int quantity, int result)
        {
            bool CheckQuantity;

            //реализация

            return result;
        }




    }

    public enum ConfectionerysList
    {
        CakeNapoleon,
        Сupcake,
        Сake
    }
}
