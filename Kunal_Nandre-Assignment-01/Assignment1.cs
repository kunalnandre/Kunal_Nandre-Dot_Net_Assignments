using System;
using System.Collections.Generic;

namespace Assignment1
{
    class Program
    {
        static List<TaskItem> tasks = new List<TaskItem>();

        static void Main(string[] args)
        {
            bool isRunning = true;

            do
            {
                Console.WriteLine("\n\nTask List Application");
                Console.WriteLine("======================");
                Console.WriteLine("1. Create a task");
                Console.WriteLine("2. Read tasks");
                Console.WriteLine("3. Update a task");
                Console.WriteLine("4. Delete a task");
                Console.WriteLine("5. Exit");
                Console.WriteLine("======================");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateTask();
                        break;
                    case 2:
                        ReadTasks();
                        break;
                    case 3:
                        UpdateTask();
                        break;
                    case 4:
                        DeleteTask();
                        break;
                    case 5:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            } while (isRunning);
        }

        static void CreateTask()
        {
            Console.Write("Enter task title: ");
            string title = Console.ReadLine();
            Console.Write("Enter task description: ");
            string description = Console.ReadLine();
            TaskItem newTask = new TaskItem(title, description);
            tasks.Add(newTask);
            Console.WriteLine("Task added successfully!");
        }

        static void ReadTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
            }
            else
            {
                Console.WriteLine("\nList of Tasks:");
                Console.WriteLine("__________________________\n");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"Task {i + 1} --------> Title: {tasks[i].Title}, Description: {tasks[i].Description}");
                }
            }
        }

        static void UpdateTask()
        {
            Console.Write("Enter task title to update: ");
            string titleToUpdate = Console.ReadLine();
            TaskItem taskToUpdate = tasks.Find(task => task.Title == titleToUpdate);
            if (taskToUpdate != null)
            {
                Console.Write("Enter new title: ");
                string newTitle = Console.ReadLine();
                Console.Write("Enter new description: ");
                string newDescription = Console.ReadLine();
                taskToUpdate.Title = newTitle;
                taskToUpdate.Description = newDescription;
                Console.WriteLine("Task updated successfully!");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        static void DeleteTask()
        {
            Console.Write("Enter task title to delete: ");
            string titleToDelete = Console.ReadLine();
            TaskItem taskToDelete = tasks.Find(task => task.Title == titleToDelete);
            if (taskToDelete != null)
            {
                tasks.Remove(taskToDelete);
                Console.WriteLine("Task deleted successfully!");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }
    }

    class TaskItem
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public TaskItem(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
