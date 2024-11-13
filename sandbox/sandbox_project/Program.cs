using System;
using System.Collections.Generic;

public class RoundRobinScheduler<T>
{
    private Queue<T> tasks = new Queue<T>();

    // Adds a task to the scheduler
    public void AddTask(T task)
    {
        tasks.Enqueue(task);
    }

    // Returns the next task in line, and moves it to the back of the queue
    public T GetNextTask()
    {
        if (tasks.Count == 0)
        {
            throw new InvalidOperationException("No tasks in the scheduler.");
        }

        T task = tasks.Dequeue();
        tasks.Enqueue(task);  // Move the task to the back of the queue
        return task;
    }
}

// Usage
public class Program
{
    public static void Main()
    {
        RoundRobinScheduler<string> scheduler = new RoundRobinScheduler<string>();
        scheduler.AddTask("Task 1");
        scheduler.AddTask("Task 2");
        scheduler.AddTask("Task 3");

        for (int i = 0; i < 6; i++) // Run for two full cycles
        {
            Console.WriteLine("Next Task: " + scheduler.GetNextTask());
        }
    }
}