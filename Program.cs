using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var figures = new List<BaseClass>()
            {
                new Ellipse(5, 5, 55, 105),
                new Circle(5, 5, 55),

                new FourAngle(10, 20, 15, 25, 30, 30, 15, 15),
                new Parallelogram(10, 20, 15, 25, 30, 30, 15, 15),

                new Rectangle(10, 20, 15, 25),
                new Square(10, 20, 30, 40),
            };

            foreach (var f in figures)
            {
                f.ShowFigure();
            }
        }
    }
}

