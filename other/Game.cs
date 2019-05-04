using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe.other
{
    public partial class Game : Form
    {
        public Game()
        {
            ClientSize = new Size(800, 600);
            MouseMove += (sender, args) =>
                Text = $"Cafe: {args.X,3} {ClientSize.Height - args.Y,3}";
        }
    }
}
