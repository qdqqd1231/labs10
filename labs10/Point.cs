using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs10
{
    class Point: Figure
    {
        public Point(double x, double y) : base(x, y)
        {

        }
        public Point(double x, double y, ConsoleColor color) : base(color, x, y)
        {

        }
        public Point()
        {

        }

    }
}
