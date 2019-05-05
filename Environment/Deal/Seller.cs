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
        Tray Tray { get; } = new Tray();

        public Point Location { get; set; }
    }
}
