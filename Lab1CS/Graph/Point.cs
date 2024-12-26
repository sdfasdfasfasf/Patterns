using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1CS.Graph
{
    public class Point : BWPoint
    {
        private String color;

        public String getColor()
        {
            return color;
        }

        public void setColor(String color)
        {
            this.color = color;
        }

        public Point(int x, int y) : base(x, y)
        {
            this.color = DEFAULT_COLOR;
        }

        public Point(int x, int y, String color) : base(x, y)
        {
            this.color = color;
        }

        public Point(Point p) : base(p.getX(), p.getY())
        {
            this.color = p.getColor();
        }

        public override void draw()
        {
            Console.WriteLine("Point ({0}, {1})  {2}", getX(), getY(), getColor());
        }
    }
}
