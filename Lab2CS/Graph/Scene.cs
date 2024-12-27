using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CS.Graph
{
    public class Scene : SceneFacade
    {
        private GraphObject root;
        public static Scene instance = new Scene();

        public GraphObject getRoot()
        {
            return root;
        }

        private Scene()
        {
        }

        public void add(CompositeShape p, GraphObject o)
        {
            if (p == null && root is CompositeShape)
                p = (CompositeShape)root;
            if (p == null)
                root = o;
            else
                p.getChildren().Add(o);
        }

        public void clear()
        {
            root = null;
        }

        public void draw()
        {
            if(root != null)
            {
                root.draw();
            }
        }

        public void showScene(List<String> args)
        {
            root = new CompositeShape();

            foreach (String s in args)
            {
                var mas = s.Split(' ');

                if (s.Contains("point"))
                {                
                    add(null, new Point(Convert.ToInt32(mas[1]), Convert.ToInt32(mas[2])));
                }
                if (s.Contains("circle"))
                {
                    add(null, new Circle(Convert.ToInt32(mas[1]), Convert.ToInt32(mas[2]), Convert.ToInt32(mas[3])));
                }
            }

            draw();
        }
    }
}
