using System;
using System.Collections.Generic;

delegate void TaskAction(string task);
class TaskStore<T>
{
    private List<T> tasks = new List<T>();

    public event Action<T> OnTaskAdded;
    public event Action<T> onTaskCompleted;
    
    
    public void AddTask(T task)
    {
        tasks.Add(task);
        OnTaskAdded?.Invoke(task);
    }

    public void CompletedTask(T task)
    {
        onTaskCompleted?.Invoke(task);
    }

    public List<T> GetAllTasks()
    {
        return tasks;
    }
}

class Program
{
    public static void Main()
    {
        TaskStore<string> store = new TaskStore<string>();

        store.OnTaskAdded += Task =>
        {
            Console.WriteLine("Task is added: " + Task);
        };
        store.onTaskCompleted += Task =>
        {
            Console.WriteLine("Task is Completed");
        };
        int completedCount = 0;
        Func<string, string> completeTask = task =>
        {
            completedCount++;
            
            return $"Completed: {task} | Total Completed: {completedCount}";
        };
        
        store.AddTask("Learn C# Generics");
        store.AddTask("Learn Delegates");
        Console.WriteLine(completeTask("Learn C# Generics"));
        Console.WriteLine(completeTask("Learn Delegates"));
        
    }
}