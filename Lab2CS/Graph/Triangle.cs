using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CS.Graph
{
    public class Triangle
    {
        private Coords a1;
        private Coords a2;
        private Coords a3;

        public Coords getA1()
        {
            return a1;
        }

        public Coords getA2()
        {
            return a2;
        }

        public Coords getA3()
        {
            return a3;
        }

        public Triangle(Coords a1, Coords a2, Coords a3)
        {
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;
        }
    }
}
