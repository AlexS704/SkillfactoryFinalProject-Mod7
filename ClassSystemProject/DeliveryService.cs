using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSystemProject
{
    public abstract class DeliveryService
    {
        public abstract decimal СostСalculation();
        public abstract DateTime EstimateDeliveryDate();
        public abstract bool IsAvailable();

    }

}
