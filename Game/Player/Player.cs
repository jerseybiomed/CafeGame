using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game.PlayerClasses
{
    public class Player
    {
        public Rectangle Location { get; set; }

        public Player(Point startLocation)
        {
            Location = new Rectangle(startLocation, new Size(100, 200));
        }

        public void DrawPlayer(Graphics graphics) => Animation.Stand(this, graphics);

        public void Move(int x, int y)
        {
            Location = new Rectangle(new Point(x, y), Location.Size);
        }

        private Ingredient ExprctedIngredient
        {
            get =>
        }

        public void Get(Storage storage)
        {
            if (storage.TryGet(out var p))
                ;
        }
    }
}
