namespace Area
{
    class Triangle : Shape
    {

        public double Base { get; private set; }
        public double Height { get; private set; }

        public Triangle(double b, double h)
        {
            Base = b;
            Height = h;
            Area = .5 * ( Base * Height);
        }

    }
}
