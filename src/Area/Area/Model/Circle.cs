using System;

namespace Area
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            Radius = radius;
            Area = Math.PI * (radius * radius);
        }
    }
}
