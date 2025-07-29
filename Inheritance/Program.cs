namespace Inheritance
{
    public abstract class Vehicle
    {
        // TODO: zdefiniuj wspólne części klas pochodnych
        public string Model { get; set; }
        public abstract void Start();
        public abstract void Stop();
    }

    public class Car : Vehicle
    {
        public override void Start() => Console.WriteLine($"Starting the car: {Model}");
        public override void Stop() => Console.WriteLine($"Stoppping the car: {Model}");
    }

    public class Motorcycle : Vehicle
    {
        public override void Start() => Console.WriteLine($"Starting the motorcycle: {Model}");
        public override void Stop() => Console.WriteLine($"Stoppping the motorcycle: {Model}");

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Model = "BMW";
            car.Start();
            car.Stop();
        }
    }
}
