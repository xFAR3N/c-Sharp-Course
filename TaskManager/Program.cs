namespace TaskManager
{
    internal class Program
    {
        public class TaskManager
        {
            private List<string> _tasks = new List<string>();

            public void AddTask(string task)
            {
                _tasks.Add(task);
            }

            public void RemoveTask(string task)
            {
                if (_tasks.Contains(task))
                {
                    _tasks.Remove(task);
                }
            }

            public List<string> GetTasks() => _tasks;
        }
        static void Main(string[] args)
        {
            var tasks = new TaskManager();
            tasks.AddTask("Portfolio");
            foreach(string task in tasks.GetTasks())
            {
                Console.WriteLine(task);
            }
        }
    }
}
