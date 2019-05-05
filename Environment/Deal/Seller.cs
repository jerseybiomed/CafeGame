using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Environment.Deal
{
    class Seller
    {
        public Tray Tray { get; } = new Tray();

        public Point Location { get; set; }

        public void TakeIngredient(Storage storage)
        {
            Tray.Add(storage.GetIngredient());
        }

        public DealResult Complete(Customer customer) =>
            customer.Complete(Tray);

        public void GetNewOrder()
        {
            Tray.GetNewSandwich();
        }
    }
}
