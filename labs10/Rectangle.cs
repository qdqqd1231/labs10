using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs10
{
    class Rectangle : Point
    {
        public double y2 { get; private set; }
        public double x2 { get; private set; }
        public double height { get; private set; }
        public double width { get; private set; }
        public double square { get; private set; }

        public Rectangle(double x1, double y1, double x2, double y2, ConsoleColor color) : base(x1, y1, color)
        {
            this.y2 = y2;
            this.x2 = x2;
            width = Math.Abs(x2 - x1);
            height = Math.Abs(y2 - y1);
            square = width * height;
        }
        public Rectangle(double x1, double y1, double x2, double y2) : base(x1, y1)
        {
            this.y2 = y2;
            this.x2 = x2;
            width = Math.Abs(x2 - x1);
            height = Math.Abs(y2 - y1);
            square = width * height;
        }
      
        public void PrintInfo()
        {
            Console.WriteLine($"Цвет фигуры {color}");
            Console.WriteLine($"Две точки, по которым задается прямоугольник ({x},{y}); ({x2},{y2})");
            Console.WriteLine($"Высота прямоугольника {height}, длина {width}");
            Console.WriteLine($"Видимость фигуры {visibleStatus}");
            Console.WriteLine($"Площадь прямоугольника {square}");
        }

    }
}
