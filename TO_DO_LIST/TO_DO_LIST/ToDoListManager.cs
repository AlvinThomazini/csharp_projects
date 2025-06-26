using System;
using System.Collections.Generic;
using System.IO;

public class ToDoListManager
{
    private string filePath = "todo_list.csv";
    public List<TaskItem> Tasks { get; private set; }

    public ToDoListManager()
    {
        Tasks = new List<TaskItem>();
        LoadFromFile();
    }

    public void AddTask(string description)
    {
        Tasks.Add(new TaskItem(description));
        SaveToFile();
    }
    
    public void RemoveTask(int index)
    {
        if (index >= 0 && index < Tasks.Count)
        {
            Tasks.RemoveAt(index);
            SaveToFile();
        }
        else
        {
            Console.WriteLine("Invalid task index.");
        }
    }

    public void ShowTasks()
    {
        if (Tasks.Count == 0)
        {
            Console.WriteLine("No tasks available.");
            return;
        }
        for (int i = 0; i < Tasks.Count; i++)
        {
            Console.WriteLine($"{i}.{Tasks[i].Description}");
        }

    }
    private void SaveToFile()
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var task in Tasks)
            {
                writer.WriteLine(task.Description);
            }
        }
    }

    private void LoadFromFile()
    {
        if (!File.Exists(filePath))
        {
            return; // File does not exist, no tasks to load
        }
        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            if (!string.IsNullOrWhiteSpace(line))
            {
                Tasks.Add(new TaskItem(line));
            }
        }
    }
}