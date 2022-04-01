using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class _4angle : _BaseClass
    {
        private protected int x1, y1;
        private protected int x2, y2;
        private protected int x3, y3;
        private protected int x4, y4;

        public int x_x1 { get { return x1; } set { x1 = value; } }
        public int x_x2 { get { return x2; } set { x2 = value; } }
        public virtual int x_x3 { get { return x3; } set { x3 = value; } }
        public virtual int x_x4 { get { return x4; } set { x4 = value; } }

        public int y_y1 { get { return y1; } set { y1 = value; } }
        public int y_y2 { get { return y2; } set { y2 = value; } }
        public virtual int y_y3 { get { return y3; } set { y3 = value; } }
        public virtual int y_y4 { get { return y4; } set { y4 = value; } }

        public _4angle(int x1,int x2, int x3, int x4, int y1, int y2, int y3, int y4)
        {
            this.x1 = x1;            this.x2 = x2;          
            this.x3 = x3;            this.x4 = x4;

            this.y1 = y1;            this.y2 = y2;
            this.y3 = y3;            this.y4 = y4;
        }

        public override string FigureName() { return "Четырехугольник"; }
        public override void ShowFigure()
        {
            Console.WriteLine(
               $"{FigureName()} " +
               $"\nКоординаты вершин: " +
               $"\nА=({x1},{y1}), " +
               $"\nB=({x2},{y2}), " +
               $"\nC=({x3},{y3})," +
               $"\nD=({x4},{y4}). \n\n");
        }
    }
}
