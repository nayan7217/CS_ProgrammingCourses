using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Interface;

namespace CS_Interface
{
    public interface IShippingCalculator
    {
        // All methods of interface are public and abstract hence we do not use use public and abstract

        float CalculateShipping(Order order);
    }
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
            {
                return order.TotalPrice * .1f;
            }
            else
                return 0;
        }
    }
}
