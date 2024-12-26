using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1CS.Graph
{
    public class Circle : GraphObject
    {
        private String color;
        private Coords center;
        private int r;

        public String getColor()
        {
            return color;
        }

        public void setColor(String color)
        {
            this.color = color;
        }

        public Circle(int x, int y, int r)
        {
            this.color = DEFAULT_COLOR;
            center = new Coords(x, y);
            this.r = r;
        }

        public Circle(int x, int y, int r, String color)
        {
            this.color = color;
            center = new Coords(x, y);
            this.r = r;
        }

        public Circle(Circle c)
        {
            this.color = c.getColor();
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
