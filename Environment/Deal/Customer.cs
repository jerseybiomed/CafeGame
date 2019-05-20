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
        public int Time { get; private set; }
        private readonly int maxTime;

        public Customer(int orderTime)
        {
            maxTime = orderTime;
            Time = 0;
            Order = Order.CreateRandomOrder();
        }

        public Customer(Order order)
        {
            Order = order;
        }

        public void UpdateOrderTime()
        {
            Time += 1;
        }

        public bool CheckOrderTime()
        {
            return Time <= maxTime;
        }

        public DealResult Complete(Tray tray)
        {
            return new DealResult(Order.Equals(tray));
        }
    }
}
