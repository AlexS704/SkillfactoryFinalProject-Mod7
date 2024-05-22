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
        public (string CakeNapoleon, string Сupcake, string Сake) toyList;

        public int CakeNapoleon = 4;
        public int Сupcake = 16;
        public int Сake = 23;
    }
}
