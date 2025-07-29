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
            static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
