using Game.PlayerClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public class Game : Form
    {
        private Size resolution = Screen.PrimaryScreen.Bounds.Size;

        public Player Player { get; set; }

        public Game()
        {
            ClientSize = new Size(800, 500);
            Text = "Cafe";
            Player = new Player(new Point(350, 150));
            Paint += (sender, args) =>
            {
                Player.DrawPlayer(args.Graphics);
            };
            MouseClicking();
        }

        public void MouseClicking()
        {
            MouseClick += (sender, args) =>
                {
                    if (args.Button == MouseButtons.Left)
                    {
                        Player.Move(MousePosition.X - Location.X, MousePosition.Y - Location.Y);
                        Invalidate();
                    }
                };
        }
    }
}
