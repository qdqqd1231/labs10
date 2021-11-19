using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs10
{
    class Oracle : Point
    {
        public double radius { get; private set; }


        public double square { get; private set; }

        public Oracle(double xCenter, double yCenter, ConsoleColor color, double radius) : base(xCenter, yCenter, color)
        {
            this.radius = radius;
            square = Math.PI * radius * radius;
        }
        public Oracle(double xCenter, double yCenter, double radius) : base(xCenter, yCenter)
        {
            this.radius = radius;
            square = Math.PI * radius * radius;
        }
        public  void PrintInfo()
        {
            Console.WriteLine($"Цвет фигуры {color}");
            Console.WriteLine($"Абсцисса точки центра окружности {x}, ордината точки окружности {y}");
            Console.WriteLine($"Видимость фигуры {visibleStatus}");
            Console.WriteLine($"Радиус окружности {radius}");
            Console.WriteLine($"Площадь круга {square}");
        }

    }
}
