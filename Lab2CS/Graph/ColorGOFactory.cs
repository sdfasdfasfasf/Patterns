using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CS.Graph
{
    public class ColorGOFactory : AbstractGOFactory
    {
        public static Point DEFAULT_POINT = new Point(0, 0);

        public override Point createPoint(CompositeShape parent)
        {
            Point p = DEFAULT_POINT;
            Scene.instance.add(parent, p); //hook

            return p;
        }

        //public override Line createLine()
        //{
        //    Line l = new Line(0, 0, 1, 1);
        //    Scene.instance.add(l);

        //    return l;
        //}

        public override Circle createCircle(CompositeShape parent)
        {
            Circle c = new Circle(0, 0, 1);
            Scene.instance.add(parent, c);

            return c;
        }
        
        public override TriangleAdapter createTriangle(CompositeShape parent)
        {
            TriangleAdapter t = new TriangleAdapter(0, 0, 0, 1, 1, 0, "black");
            Scene.instance.add(parent, t);

            return t;
        }

        public override CompositeShape createRoot()
        {
            CompositeShape cs = new CompositeShape();
            Scene.instance.add(null, cs);

            return cs;
        }

        public override CompositeShape createContainer(CompositeShape parent)
        {
            CompositeShape cs = new CompositeShape();
            Scene.instance.add(parent, cs);

            return cs;
        }
    }
}
