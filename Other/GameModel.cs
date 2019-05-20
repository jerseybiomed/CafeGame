using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafe.Environment;
using Cafe.Environment.Deal;
using Cafe.Environment.Ingredients;
using System.Drawing;
using System.Windows.Forms;

namespace Cafe.Other
{
    public class GameModel
    {
        private List<Customer> customers;
        private int customerNumber;
        private Seller seller;
        private int respect;
        public Storage[] storages { get; }

        public GameModel(int startRespect)
        {
            customers = new List<Customer>();
            customerNumber = 0;
            seller = new Seller();
            respect = startRespect;
            storages = new Storage[] 
                { new Storage(new WhiteBread()), new Storage(new Beef()), new Storage(new Salad()),
                  new Storage(new GreyBread()), new Storage(new Pork()), new Storage(new Tomato()),
                  new Storage(new RyeBread()), new Storage(new Hen()), new Storage(new Cucumber()) };
        }

        public void AddCustomer()
        {
            var currentNumber = customerNumber % 3;
            customers[currentNumber] = new Customer(100);
            customerNumber++;
        }

        public void WaitOrder()
        {
            foreach (var customer in customers)
            {
                customer.UpdateOrderTime();
                if (!customer.CheckOrderTime())
                    respect += (new DealResult(false)).ChangeRespect;
            }
        }

        public void ChangeRespect(int customer)
        {
            respect += seller.Complete(customers[customer]).ChangeRespect;
        }


    }
}
