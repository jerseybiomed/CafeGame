using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe.Other
{
    static public class Visualizer
    {
        public static Point ConvertMathToWindow(Form form, Point mathPoint)
        {
            return new Point(mathPoint.X, form.ClientSize.Height - mathPoint.Y);
        }

        public static Point ConvertWindowToMath(Form form, Point windowPoint)
        {
            return new Point(windowPoint.X, form.ClientSize.Height - windowPoint.Y);
        }
    }
}
