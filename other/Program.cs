using Cafe.Environment;
using Cafe.Environment.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe.other
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var s = new Sandwich();
            var b = new Bread();
            var m = new Beef();
            var v = new Vegetables();
            s.Add(b);
            s.Add(m);
            s.Add(v);
            //Application.Run(new Game());
        }
    }
}
