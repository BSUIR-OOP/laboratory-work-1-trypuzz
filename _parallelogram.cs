using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _parallelogram : _4angle
    {
        public _parallelogram(int x1, int x2, int x3, int x4, int y1, int y2, int y3, int y4) : base(x1, x2, x3, x4, y1, y2, y3, y4)
        {
        }
        public override string FigureName() { return "Параллелограм"; }

    }
}
