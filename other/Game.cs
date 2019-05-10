using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cafe.Environment;
using Cafe.Environment.Deal;
using Cafe.Environment.Ingredients;

namespace Cafe.other
{
    public class GameModel
    {
        public readonly Customer customer = new Customer(new Order(rye, hen, salad));
        public readonly Seller seller = new Seller();
        public static readonly BrownBread brown = new BrownBread();
        public static readonly RyeBread rye = new RyeBread();
        public static readonly WhiteBread white = new WhiteBread();
        public static readonly Beef beef = new Beef();
        public static readonly Hen hen = new Hen();
        public static readonly Pork pork = new Pork();
        public static readonly Tomato tomato = new Tomato();
        public static readonly Cucumber cucumber = new Cucumber();
        public static readonly Salad salad = new Salad();

        public readonly Storage[,] storages = { 
            { new Storage(rye), new Storage(brown), new Storage(white) }, 
            { new Storage(beef), new Storage(hen), new Storage(pork) }, 
            { new Storage(tomato), new Storage(cucumber), new Storage(salad) } };
        public readonly int Size;

        public GameModel(int size)
        {
            Size = size;
        }
    }

    public partial class Game : Form
    {
        GameModel game;

        public Game(GameModel game)
        {
            this.game = game;
            game.seller.GetNewOrder();
            var breadBox = new TextBox();
            breadBox.Location = new Point(400, 0);
            breadBox.Size = new Size(100, 100);
            Controls.Add(breadBox);
            for (int row = 0; row < 3; row++)
            {
                var icolumn = 0;
                var irow = row;
                var button = new Button();
                button.Location = new Point(row * 100, 0);
                button.Size = new Size(100, 100);
                button.Dock = DockStyle.None;
                button.Text = game.storages[icolumn, irow].Ingredient.ToString() + ' ' + game.storages[icolumn, irow].Count.ToString();
                button.Click += (sender, args) =>
                {
                    game.seller.TakeIngredient(game.storages[icolumn, irow]);
                    var text = button.Text.Split(' ');
                    button.Text = text[0] + ' ' + game.storages[icolumn, irow].Count.ToString();
                    if (game.storages[icolumn, irow].Ingredient == game.seller.Tray.Sandwich.Bread)
                        breadBox.Text = text[0];
                };
                Controls.Add(button);
            }
            var meatBox = new TextBox();
            meatBox.Location = new Point(400, 100);
            meatBox.Size = new Size(100, 100);
            Controls.Add(meatBox);
            for (int row = 0; row < 3; row++)
            {
                var icolumn = 1;
                var irow = row;
                var button = new Button();
                button.Location = new Point(row * 100, 100);
                button.Size = new Size(100, 100);
                button.Dock = DockStyle.None;
                button.Text = game.storages[icolumn, irow].Ingredient.ToString() + ' ' + game.storages[icolumn, irow].Count.ToString();
                button.Click += (sender, args) =>
                {
                    game.seller.TakeIngredient(game.storages[icolumn, irow]);
                    var text = button.Text.Split(' ');
                    button.Text = text[0] + ' ' + game.storages[icolumn, irow].Count.ToString();
                    if (game.storages[icolumn, irow].Ingredient == game.seller.Tray.Sandwich.Meat)
                        meatBox.Text = text[0];
                };
                Controls.Add(button);
            }
            var vegetableBox = new TextBox();
            vegetableBox.Location = new Point(400, 200);
            vegetableBox.Size = new Size(100, 100);
            Controls.Add(vegetableBox);
            for (int row = 0; row < 3; row++)
            {
                var icolumn = 2;
                var irow = row;
                var button = new Button();
                button.Location = new Point(row * 100, 200);
                button.Size = new Size(100, 100);
                button.Dock = DockStyle.None;
                button.Text = game.storages[icolumn, irow].Ingredient.ToString() + ' ' + game.storages[icolumn, irow].Count.ToString();
                button.Click += (sender, args) =>
                {
                    game.seller.TakeIngredient(game.storages[icolumn, irow]);
                    var text = button.Text.Split(' ');
                    button.Text = text[0] + ' ' + game.storages[icolumn, irow].Count.ToString();
                    if (game.storages[icolumn, irow].Ingredient == game.seller.Tray.Sandwich.Vegetables)
                        vegetableBox.Text = text[0];
                };
                Controls.Add(button);
            }
            var respectBox = new TextBox();
            respectBox.Location = new Point(600, 0);
            respectBox.Size = new Size(100, 100);
            Controls.Add(respectBox);
            var completeButton = new Button();
            completeButton.Location = new Point(600, 400);
            completeButton.Size = new Size(100, 25);
            completeButton.Dock = DockStyle.None;
            completeButton.Text = "Complete";
            completeButton.Click += (sender, args) =>
            {
                var changeRespect = game.seller.Complete(game.customer).ChangeRespect;
                if (changeRespect < 0)
                    respectBox.Text = "-rep";
                else
                    respectBox.Text = "+rep";
                game.seller.GetNewOrder();
                breadBox.Text = "";
                meatBox.Text = "";
                vegetableBox.Text = "";
            };
            Controls.Add(completeButton);
            for (var i = 0; i < 3; i++)
            {
                var customerBox = new TextBox();
                customerBox.Location = new Point(400, 450 + i * 50);
                customerBox.Size = new Size(100, 50);
                customerBox.Text = game.customer.Order.Sandwich.Ingredients.ElementAt(i).ToString();
                Controls.Add(customerBox);
            }
        }

        //public Game()
        //{
        //    ClientSize = new Size(800, 600);
        //    MouseMove += (sender, args) =>
        //        Text = $"Cafe: {args.X,3} {ClientSize.Height - args.Y,3}";
        //}
    }
}
