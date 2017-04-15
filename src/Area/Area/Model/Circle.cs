using System;

namespace Area
{
    public class Circle
    {
        public double Radius { get; private set; }
        public double Area { get; private set; }

        public Circle(double radius)
        {
            Radius = radius;
            Area = Math.PI * (radius * radius);
        }
    }
}
