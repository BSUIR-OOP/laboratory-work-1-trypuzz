using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _circle : _ellipse
    {
        public int radius { get { return f_axle; } set { f_axle = value; s_axle = value; } }

        public _circle(int x1, int y1, int r) : base(x1, y1, r, r)
        {
        }

        public override string FigureName() { return "Окружность"; }
        public override void ShowFigure()
        {
            Console.WriteLine($"{FigureName()}\n" +
                $"Центр в точке ({x},{y}) \n" +
                $"Радиус = {radius} \n\n");
        }
    }
}
