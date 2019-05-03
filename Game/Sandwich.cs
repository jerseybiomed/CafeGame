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
        public enum State
        {
            Nothing,

        }

        public string Name { get; set; } // whot does "name" mean???

        public Image Stripe { get; set; }

        public Rectangle Location { get; set; }

        public State state;

        public Sandwich(string name)
        {
            Name = name;
        }
    }
}
