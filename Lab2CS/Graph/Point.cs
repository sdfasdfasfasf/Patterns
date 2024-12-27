using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CS.Graph
{
    public class Point : SimpleShape
    {
        private Coords coords;
        
        public Point(int x, int y) : base(DEFAULT_COLOR)
        {
            coords = new Coords(x, y);
        }

        public Point(int x, int y, String color) : base(color)
        {
            coords = new Coords(x, y);
        }

        public Point(Point p) : base(p.getColor())
        {
            coords = new Coords(p.getX(), p.getY());
        }

        public int getX()
        {
            return coords.getX();
        }

        public void setX(int x)
        {
            coords.setX(x);
        }
        public int getY()
        {
            return coords.getY();
        }

        public void setY(int y)
        {
            coords.setX(y);
        }

        public override void draw()
        {
            Console.WriteLine("Point ({0}, {1})  {2}", getX(), getY(), getColor());
        }
    }
}
