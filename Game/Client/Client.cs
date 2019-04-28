using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game.ClientClasses
{
    public class Client
    {
        public Rectangle Location { get; set; }

        public Sandwich Order { get; set; }

        public Client(Point startLocation)
        {
            Location = new Rectangle(startLocation, new Size(100, 200));
        }
    }
}
