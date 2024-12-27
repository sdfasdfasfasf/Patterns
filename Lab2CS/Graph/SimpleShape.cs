using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CS.Graph
{
    public abstract class SimpleShape : GraphObject
    {
        public static String DEFAULT_COLOR = "black";
        private String color;

        public String getColor()
        {
            return color;
        }

        public void setColor(String color)
        {
            this.color = color;
        }

        public SimpleShape()
        {
            this.color = DEFAULT_COLOR;
        }

        public SimpleShape(String color)
        {
            this.color = color;
        }
    }
}
