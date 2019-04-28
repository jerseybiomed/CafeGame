using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    public class Sandwich
    {
        public string Name { get; set; }

        public Image Stripe { get; set; }

        public Rectangle Location { get; set; }

        public Ingredient Bread { get; set; }
        public Ingredient Meat { get; set; }
        public Ingredient Vegetables { get; set; }

        public Sandwich(string name)
        {
            Name = name;
        }
    }
}
