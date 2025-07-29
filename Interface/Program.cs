namespace Interface
{
    internal class Program
    {
        public interface IShape
        {
            public double CalculateArea();
            public double CalculatePerimeter();

        }
        public class Square : IShape
        {
            private double a;
            public Square(double a)
            {
                this.a = a;
            }
            public double CalculateArea()
            {
                return Math.Pow(a, 2);
            }
            public double CalculatePerimeter()
            {
                return 4 * a;
            }
        }
        public class Circle : IShape
        {
            private double r;
            public Circle(double r)
            {
                this.r = r;
            }
            public double CalculateArea()
            {
                return (Math.PI * Math.Pow(r, 2));
            }
            public double CalculatePerimeter()
            {
                return 2 * r * Math.PI;
            }

        }
            static void Main(string[] args)
        {
            var s1 = new Square(10);
            var c1 = new Circle(10);
            Console.WriteLine();
        }
    }
}
