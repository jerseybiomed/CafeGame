using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    public class Ingredient
    {
        private readonly int maxCount;
        public int Count { get; set; }
        public string Name { get; set; }

        public Image Stripe { get; set; }

        public Rectangle Location { get; set; }

        public Ingredient(int value, string name)
        {
            maxCount = value;
            Count = value;
            Name = name;
        }

        public void Add()
        {
            Count = maxCount;
        }
    }
}
