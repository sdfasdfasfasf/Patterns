using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CS.Graph
{
    public class CompositeShape : GraphObject
    {
        private List<GraphObject> children;

        public List <GraphObject> getChildren()
        {
            if(children == null)
            {
                children = new List<GraphObject>();
            }

            return children;
        }

        public override void draw()
        {
            foreach (GraphObject g in getChildren())
            {
                g.draw();
            }
        }
    }
}
