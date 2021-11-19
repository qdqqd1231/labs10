using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs10
{

    enum VisibleStatus
    {
        Visible,
        Invisible
    }
    class Figure
    {
        public Figure()
        {
            visibleStatus = VisibleStatus.Visible;
        }
        public Figure(double x, double y)
        {
            this.x = x;
            this.y = y;
            visibleStatus = VisibleStatus.Visible;
        }
        public Figure(ConsoleColor color, double x, double y)
        {
            this.x = x;
            this.y = y;
            this.color = color;
            visibleStatus = VisibleStatus.Visible;
        }
        public VisibleStatus visibleStatus { get; set; }
        public ConsoleColor color { get; set; }
        public double x { get; private set; }
        public double y { get; private set; }


        public void switchColor(ConsoleColor switchColor)
        {
            this.color = switchColor;
        }
        public void switchVisibility(VisibleStatus switchVisible)
        {
            this.visibleStatus = switchVisible;
        }
        public void MoveRight()
        {
            
                this.x++;
            
        }
        public void MoveLeft()
        { 

                x--;

        }
        public void MoveUp()
        {

                y++;

        }
        public void MoveDown()
        { 
                y--;

        }
        public void ShowInfo()
        {
            Console.WriteLine($"Figure color -->{color} , Visibility Status --> {visibleStatus}, Coordinates --> x = {x}, y = {y}");
        }

    }

}
