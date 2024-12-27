using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CS.Graph
{
    public class FillDecorator : SimpleShape
    {
        private SimpleShape elementForDecorate;
        private String endColor;
        

        public FillDecorator(SimpleShape elementForDecorate, String color) : base(color)
        {
            this.elementForDecorate = elementForDecorate;
        }

        public FillDecorator(SimpleShape elementForDecorate, String startColor, String endColor) : base(startColor)
        {
            this.endColor = endColor;
            this.elementForDecorate = elementForDecorate;
        }

        public String getEndColor()
        {
            return endColor;
        }

        public override void draw()
        {
            this.elementForDecorate.draw();

            if (endColor != null)
            {
                Console.WriteLine("Gradient fill from {0} to {1}", getColor(), getEndColor());
            }
            else 
            {
                Console.WriteLine("Solid fill {0} with {1}", elementForDecorate.GetType().Name, getColor());
            }
        }
    }
}
