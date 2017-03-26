namespace Area
{
    public  class Rectangle : Shape
    {
        public double Height { get; private set; }
        public double Width { get; private set; }
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
            Area = height * width;           
        }
    }
}
