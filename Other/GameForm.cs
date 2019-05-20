using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cafe.Properties;
using Cafe.Environment;
using Cafe.Environment.Deal;
using Cafe.Environment.Ingredients;

namespace Cafe.Other
{
    public partial class GameForm : Form
    {
        public GameForm(GameModel game)
        {
            DoubleBuffered = true;
            ClientSize = new Size(800, 600);
            BackColor = Color.Aquamarine;
            Text = "Cafe Game";

            var time = 0;
            var timer = new Timer();
            timer.Interval = 500;
            timer.Tick += (sender, args) =>
            {
                time++;
                Invalidate();
            };
            timer.Start();

            Paint += (sender, args) =>
            {
                var graphics = args.Graphics;

                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.DrawImage(Resources.tableHalf, new Point(0, 350));
                graphics.DrawImage(Resources.tableHalf, new Point(400, 350));
                graphics.DrawImage(Resources.whiteBreadBeefTomato, new Point(150, 325));
                for (var i = 0; i < 3; i++)
                    for (var j = 0; j < 3; j++)
                        graphics.DrawImage(Resources.storage, new Point(j * 100, i * 100));
                foreach (var storage in game.storages)
                {
                    if (storage.Ingredient is WhiteBread)
                        for (var i = 0; i < storage.Count; i++)
                            graphics.DrawImage(Resources.whiteBread, new Point(i * 10, 50));
                    if (storage.Ingredient is GreyBread)
                        for (var i = 0; i < storage.Count; i++)
                            graphics.DrawImage(Resources.greyBread, new Point(100 + i * 10, 50));
                    if (storage.Ingredient is RyeBread)
                        for (var i = 0; i < storage.Count; i++)
                            graphics.DrawImage(Resources.ryeBread, new Point(200 + i * 10, 50));
                    if (storage.Ingredient is Beef)
                        for (var i = 0; i < storage.Count; i++)
                            graphics.DrawImage(Resources.beef, new Point(i * 10, 140));
                    if (storage.Ingredient is Pork)
                        for (var i = 0; i < storage.Count; i++)
                            graphics.DrawImage(Resources.pork, new Point(100 + i * 10, 140));
                    if (storage.Ingredient is Hen)
                        for (var i = 0; i < storage.Count; i++)
                            graphics.DrawImage(Resources.hen, new Point(200 + i * 10, 140));
                    if (storage.Ingredient is Tomato)
                        for (var i = 0; i < storage.Count; i++)
                            graphics.DrawImage(Resources.tomato, new Point(i * 10, 240));
                    if (storage.Ingredient is Cucumber)
                        for (var i = 0; i < storage.Count; i++)
                            graphics.DrawImage(Resources.cucumber, new Point(100 + i * 10, 240));
                    if (storage.Ingredient is Salad)
                        for (var i = 0; i < storage.Count; i++)
                            graphics.DrawImage(Resources.salad, new Point(200 + i * 10, 240));
                }
            };
        }
    }
}
