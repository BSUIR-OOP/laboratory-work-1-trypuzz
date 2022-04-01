using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _ellipse: _BaseClass
    {
        private protected int x, y;
        private protected int f_axle, s_axle;

        public virtual int f_ax { get { return f_axle; } set { f_axle = value; } }
        public virtual int s_ax { get { return s_axle; } set { s_axle = value; } }

        public int p_x { get { return x; } set { x = value; } }
        public int p_y { get { return y; } set { y = value; } }

        public _ellipse(int x1, int y1, int axle1, int axle2)
        {
            x = x1;              y = y1;
            f_axle = axle1;      s_axle = axle2;
        }

        public override string FigureName() 
        { return "Эллипс"; }

        public override void ShowFigure()
        {Console.WriteLine(
            $"{FigureName()}\n" +
            $"Центр в точке ({x},{y}); \n" +
            $"Большая полуось: {f_axle}; \n" +
            $"Малая полуось: {s_axle}. \n\n");
        }
    }
}
