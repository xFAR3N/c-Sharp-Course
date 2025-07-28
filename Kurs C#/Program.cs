namespace Kurs_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert numbers: ");
            int number;
            int? max = null;
            int sum = 0;
            do
            {
                number = int.Parse(Console.ReadLine());
                sum = sum + number;
                if(number > max)
                {
                    max = number;
                }
            } while (number != 0);
            Console.WriteLine($"Sum of numbers: {sum}");
            if (max is null)
            {
                Console.WriteLine("No vaalues entered");
            }
            else
            {
                Console.WriteLine($"Max value: {max}");
            }
        }
    }
}
