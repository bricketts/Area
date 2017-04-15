namespace Area
{
    public  class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Area
        {
            get
            {
                return Height * Width;
            }
        }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;          
        }
    }
}
