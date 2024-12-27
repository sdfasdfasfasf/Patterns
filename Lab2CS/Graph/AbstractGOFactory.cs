using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CS.Graph
{
    public abstract class AbstractGOFactory
    {
        public abstract Point createPoint(CompositeShape parent);

        //public abstract Line createLine();

        public abstract Circle createCircle(CompositeShape parent);

        public abstract TriangleAdapter createTriangle(CompositeShape parent);

        public abstract CompositeShape createRoot();

        public abstract CompositeShape createContainer(CompositeShape parent);
    }
}
