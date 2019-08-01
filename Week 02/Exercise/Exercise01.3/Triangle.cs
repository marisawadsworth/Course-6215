namespace Exercise013
{
    public class Triangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area()
        {
            return Width * Height * 2;
        }

        public Triangle(double w, double h)
        {
            Width = w;
            Height = h;
        }
    }
}