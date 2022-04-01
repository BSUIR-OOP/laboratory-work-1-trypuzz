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
                new Ellipse(5, 5, 55, 105),
                new Circle(5, 5, 55),          
            };

            foreach (var f in figures)
            {
                f.ShowFigure();
            }

           
        }
    }
}

