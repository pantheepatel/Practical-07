// Liskov Substitution Principle - a subclass should be able to replace its base class without affecting the correctness of the program.
namespace SOLIDPrinciples
{
    // making common interface that would restrict class to have GetArea method compulsory
    public interface IShape
    {
        double GetArea();
    }
    // making class rectangle and square different as they both need different number of argument to calculate area
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double GetArea()
        {
            return Width * Height;
        }
    }

    public class Square : IShape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public double GetArea()
        {
            return Side * Side;
        }
    }
}
