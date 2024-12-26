using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1CS.Graph
{
    public class Scene
    {
        private List<GraphObject> objects;
        public static Scene instance = new Scene();

        private Scene()
        {
            objects = new List<GraphObject>();
        }

        public void add(GraphObject o)
        {
            objects.Add(o);
        }

        public void clear()
        {
            objects.Clear();
        }

        public void draw()
        {
            foreach (GraphObject g in objects)
            {
                g.draw();
            }
        }
    }
}
