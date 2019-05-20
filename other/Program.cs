using Cafe.Environment;
using Cafe.Environment.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Cafe.Other
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new GameForm(new GameModel(10)));
        }
    }
}
