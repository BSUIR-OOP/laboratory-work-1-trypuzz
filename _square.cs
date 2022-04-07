using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class _square: _4angle
    {
        public override int x_x4 { get { return x4; } }
        public override int y_y4 { get { return y4; } }

        public _square(int x1, int x2, int y1, int y2) : base(x1, x2, y1, y2,x2,y2,x1,y1)
        {
        }
        public override string FigureName() { return "Квадрат"; }
        public override void ShowFigure()
        {
            Console.WriteLine(
                $"{FigureName()}\n" +
                $"Координаты вершин:\n" +
                $"(A = {x1},{y1}),\n" +
                $"(B = {x1},{y2}),\n" +
                $"(C = {x2},{y2}) \n"+
                $"(D = {x2},{y1}),\n\n");
        }
    }
}
