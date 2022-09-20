using System;
using CS_Interface;

namespace CS_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());

            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };

            orderProcessor.Process(order);

        }
    }
}