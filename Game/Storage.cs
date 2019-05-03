using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    public class Storage
    {
        private readonly int maxCount;
        public int Count { get; set; }
        private Ingredient Ingredient { get; set; } // place for object not equals object

        public Image Stripe { get; set; }

        public Rectangle Location { get; set; }

        public Storage(int value, Ingredient ingredient)
        {
            maxCount = value;
            Count = value;
            Ingredient = ingredient;
        }

        public void Add()
        {
            Count = maxCount;
        }

        public bool TryGet(out Ingredient ingredient)
        {
            if(Count > 0)
            {
                --Count;
                ingredient = Ingredient;
                return true;
            }
            ingredient = null;
            return false;
        }
    }
}
