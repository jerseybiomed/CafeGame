using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Environment.Deal
{
    public class Customer
    {
        public Order Order { get; }

        public Customer()
        {
            Order = Order.CreateRandomOrder();
        }

        public Customer(Order order)
        {
            Order = order;
        }

        public DealResult Complete(Tray tray)
        {
            return new DealResult(Order.Equals(tray));
        }
    }
}
