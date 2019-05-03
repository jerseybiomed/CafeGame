using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game.PlayerClasses
{
    public static class Animation
    {
        public static void Stand(Player player, Graphics graphics)
        {
            var image = Image.FromFile(@"W:\github\CafeGame\Game\Images\Player.png");
            graphics.DrawImage(image, player.Location);
        }
    }
}
