using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CS.Graph
{
    public class BWPoint : GraphObject
    {
        private Coords coords;

        public BWPoint(int x, int y)
        {
            coords = new Coords(x, y);
        }

        public BWPoint(BWPoint p)
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
            coords.setY(y);
        }

        public override void draw()
        {
            Console.WriteLine("BWPoint ({0}, {1})", getX(), getY());
        }
    }
}
