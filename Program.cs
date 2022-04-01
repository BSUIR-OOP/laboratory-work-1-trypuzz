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
            var figures = new List<_BaseClass>()
            {
                new _ellipse(5, 5, 55, 105),
                new _circle(5, 5, 55),

                new _4angle(10, 20, 15, 25, 30, 30, 15, 15),
                new _parallelogram(10, 20, 15, 25, 30, 30, 15, 15),

                new _rectangle(10, 20, 15, 25),
                new _square(10, 20, 30, 40),
            };

            foreach (var f in figures)
            {
                f.ShowFigure();
            }
        }
    }
}

