/////////////////////////////
// Coding is Fun :)         /
// x2Beef Coding Productions/
/////////////////////////////







using System;
using System.Collections.Generic;

class Program
{
    // Define a class to represent a Task
    public class Task
    {
        public string Name { get; set; }
        public bool IsCompleted { get; set; }

        public Task(string name)
        {
            Name = name;
            IsCompleted = false;
        }

        public override string ToString()
        {
            return $"{Name} - {(IsCompleted ? "Completed" : "Pending")}";
        }
    }

    static void Main()
    {
        List<Task> tasks = new List<Task>();
        int choice;

        do
        {
            Console.Clear();
            Console.WriteLine("To-Do List by x2Beef Coding Productions");
            Console.WriteLine("----------------------");
            Console.WriteLine("1. View Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Mark Task as Completed");
            Console.WriteLine("4. Delete Task");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ViewTasks(tasks);
                    break;
                case 2:
                    AddTask(tasks);
                    break;
                case 3:
                    MarkTaskCompleted(tasks);
                    break;
                case 4:
                    DeleteTask(tasks);
                    break;
                case 5:
                    Console.WriteLine("Goodbye! See you next time on one of my projects!");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Choice not found.....");
                    break;
            }

            if (choice != 5)
            {
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
            }

        } while (choice != 5);
    }

    // Method to view all tasks
    static void ViewTasks(List<Task> tasks)
    {
        Console.Clear();
        Console.WriteLine("Your To-Do List:");
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks in your list.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }

    // Method to add a new task
    static void AddTask(List<Task> tasks)
    {
        Console.Clear();
        Console.Write("Enter the task name: ");
        string taskName = Console.ReadLine();
        tasks.Add(new Task(taskName));
        Console.WriteLine("Task added successfully.");
    }

    // Method to mark a task as completed
    static void MarkTaskCompleted(List<Task> tasks)
    {
        Console.Clear();
        ViewTasks(tasks);
        if (tasks.Count == 0) return;

        Console.Write("Enter the task number to mark as completed: ");
        int taskNumber = int.Parse(Console.ReadLine()) - 1;

        if (taskNumber >= 0 && taskNumber < tasks.Count)
        {
            tasks[taskNumber].IsCompleted = true;
            Console.WriteLine("Task marked as completed.");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }

    // Method to delete a task
    static void DeleteTask(List<Task> tasks)
    {
        Console.Clear();
        ViewTasks(tasks);
        if (tasks.Count == 0) return;

        Console.Write("Enter the task number to delete: ");
        int taskNumber = int.Parse(Console.ReadLine()) - 1;

        if (taskNumber >= 0 && taskNumber < tasks.Count)
        {
            tasks.RemoveAt(taskNumber);
            Console.WriteLine("Task deleted successfully.");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
}
