using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassSystemProject
{
   
    abstract class Delivery
    {
        public string Address;
        public double Distance;
        public double DateTimeDelivery;


        public abstract void СostСalculation();
    }
}
