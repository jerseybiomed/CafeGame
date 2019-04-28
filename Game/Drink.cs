using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    public class Drink
    {
        public string Name { get; set; }

        public Image Stripe { get; set; }

        public Drink(string name)
        {
            Name = name;
        }
    }
}
