using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1CS.Graph
{
    public abstract class AbstractGOFactory
    {
        public abstract BWPoint createPoint();

        public abstract Line createLine();

        public abstract Circle createCircle();
    }
}
