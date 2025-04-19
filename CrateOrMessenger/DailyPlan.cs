// Represents a daily plan that manages a list of scheduled tasks without overlaps.
public class DailyPlan
{
    private readonly List<Task> tasks = new List<Task>();

    // Adds a new task to the plan at the specified time and duration. Returns false if the new task overlaps with an existing one.
    public bool Add(int hour, int minute, int duration, string description)
    {
        int start = hour * 60 + minute;
        int end = start + duration;

        int index = 0;
        while (index < tasks.Count)
        {
            var task = tasks[index];
            if (task.end <= start)
            {
                index++;
                continue;
            }
            if (task.start <= end)
            {
                return false;
            }
            break;
        }
        tasks.Insert(index, new Task(start, end, description));
        return true;
    }

    // Displays all scheduled tasks in the plan.
    public void display()
    {
        Console.WriteLine("\nTasks:");
        foreach (Task task in tasks)
        {
            Console.WriteLine(string.Format("{0:00}:{1:00} - {2:00}:{3:00} {4}", task.start / 60, task.start % 60, task.end / 60, task.end % 60, task.description));
            Console.WriteLine("------------------------------------------");
        }
    }

    // Represents a scheduled task with a start time, end time, and description. 
    // Serves as an example of the Crate/Messenger design pattern.
    private class Task
    {
        public readonly int start;
        public readonly int end;
        public readonly string description;
        public Task(int start, int end, string description)
        {
            this.start = start;
            this.end = end;
            this.description = description;
        }
    }
}