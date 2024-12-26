using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1CS.Graph
{
    public class BWGOFactory : AbstractGOFactory
    {
        public override BWPoint createPoint()
        {
            BWPoint p = new BWPoint(1, 1);
            Scene.instance.add(p);

            return p;
        }

        public override Line createLine()
        {
            Line l = new Line(0, 0, 1, 1);
            Scene.instance.add(l);

            return l;
        }

        public override Circle createCircle()
        {
            Circle c = new Circle(0, 0, 1);
            Scene.instance.add(c);

            return c;
        }
    }
}
