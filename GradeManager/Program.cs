namespace GradeManager
{
    internal class Program
    {
        public class GradeManager
        {
            private Dictionary<string, List<int>> grades = new Dictionary<string, List<int>>();
            public void AddGrade(string studentName, int grade)
            {
                if (!grades.ContainsKey(studentName))
                {
                    grades[studentName] = new List<int>();
                }
                grades[studentName].Add(grade);
            }
            public void RemoveGrade(string studentName, int grade)
            {
                if (grades.ContainsKey(studentName))
                {
                    grades[studentName].Remove(grade);
                }
            }
            public double CalculateAverageGrade(string studentName)
            {
                if(grades.ContainsKey(studentName) && grades[studentName].Count > 0)
                {
                    return grades[studentName].Average();
                }
                return 0.0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
