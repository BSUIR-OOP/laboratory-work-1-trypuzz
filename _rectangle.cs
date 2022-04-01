using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _rectangle : _parallelogram
    {
        public override int x_x3 { get { return x3; } }
        public override int x_x4 { get { return x4; } }
        public override int y_y3 { get { return y3; } }
        public override int y_y4 { get { return y4; } }
        public _rectangle(int x1, int x2, int y1, int y2) : base(x1, y1, x1, y2, x2, y2, x2, y1)
        {

        }
        public override string FigureName() { return "Прямоугольник"; }

        public override void ShowFigure()
        {
            Console.WriteLine(
                 $"{FigureName()}\n" +
                 $"Координаты вершин:\n" +
                 $"A = ({this.x1},{this.y1}),\n" +
                 $"B = ({this.x2},{this.y1}),\n" +
                 $"C = ({this.x2},{this.y2}) \n" +
                 $"D = ({this.x1},{this.y2}) \n\n");
        }
    }
}

