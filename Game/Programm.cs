﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    static class Programm
    {
        /// <summary>
        /// главная точка входа для приложения.
        /// </summary>
        [STAThread]//comment 2.0
        static void Main()
        {
            Application.Run(new Game());
        }
    }
}