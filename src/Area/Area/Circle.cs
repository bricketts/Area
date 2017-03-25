using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }
        public double Diameter { get; private set; }

        public Circle(double radius)
        {
            Radius = radius;
            Area = Math.PI * (radius * radius);
        }
    }
}
