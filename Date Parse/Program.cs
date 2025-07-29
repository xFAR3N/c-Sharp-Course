namespace Date_Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Insert your birth year: ");
            int birthYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert your birth month: ");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert your birth day: ");
            int birthDay = int.Parse(Console.ReadLine());

            DateTime Birthday = new DateTime(birthYear, birthMonth, birthDay);*/
            Console.WriteLine("Podaj date urodzenia w formacie dd.MM.yyyy");
            string dateofBirth = Console.ReadLine();

            DateTime Birthday = DateTime.Parse(dateofBirth);

            TimeSpan timeSpan = DateTime.Now - Birthday;
            Console.WriteLine($"Days since your birthday: {Math.Round(timeSpan.TotalDays, 0)}");
        }
    }
}
