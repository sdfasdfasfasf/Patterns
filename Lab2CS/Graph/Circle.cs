using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CS.Graph
{
    public class Circle : SimpleShape
    {
        private Coords center;
        private int r;

        public Circle(int x, int y, int r)
        {
            setColor(DEFAULT_COLOR);
            center = new Coords(x, y);
            this.r = r;
        }

        public Circle(int x, int y, int r, String color)
        {
            setColor(color);
            center = new Coords(x, y);
            this.r = r;
        }

        public Circle(Circle c)
        {
            setColor(c.getColor());
            center = new Coords(c.getX(), c.getY());
            this.r = c.getR();
        }
        
        public int getR()
        {
            return r;
        }

        public void setR(int r)
        {
            this.r = r;
        }

        public int getX()
        {
            return center.getX();
        }

        public void setX(int x)
        {
            center.setX(x);
        }

        public int getY()
        {
            return center.getY();
        }

        public void setY(int y)
        {
            center.setY(y);
        }


        public override void draw()
        {
            Console.WriteLine("Circle ({0}, {1}) R: {2} {3}", getX(), getY(), getR(), getColor());
        }
    }
}
