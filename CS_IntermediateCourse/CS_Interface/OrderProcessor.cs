using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Interface;

namespace CS_Interface
{
    public  class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;


        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }
        public void Process(Order order)
        {
            if (order.IsShipped)
            {
                throw new InvalidOperationException("This Order is Already Processed");
            }
            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShipmentDate = DateTime.Today.AddDays(2)
            };

        }

    }
}
