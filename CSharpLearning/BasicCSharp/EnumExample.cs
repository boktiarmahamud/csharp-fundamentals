using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCSharp
{
    enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }
    class Order
    {
        public int OrderId { get; set; }
        public OrderStatus Status { get; set; }
    }
    internal class EnumExample
    {
        public static void Main(string[] args)
        {
           Order order = new Order
            {
                OrderId = 12345,
                Status = OrderStatus.Processing
            };
            if(order.Status == OrderStatus.Processing) 
            {
                Console.WriteLine($"Order {order.OrderId} is currently being processed.");
            }
           
        }
    }
}
