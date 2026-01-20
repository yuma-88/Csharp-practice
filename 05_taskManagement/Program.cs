using System;
using System.Collections.Generic;

class Program
{
  private static List<TaskItem> tasks = new List<TaskItem>();
  private static int nextId = 1;

  static void Main()
  {
    Console.WriteLine();
    Console.WriteLine("=== タスク管理アプリ ===");
    Console.WriteLine("1: タスク追加");
    Console.WriteLine("2: タスク一覧");
    Console.WriteLine("3: タスク完了/未完了切替");
    Console.WriteLine("4: タスク削除");
    Console.WriteLine("0: 終了");

    while (true)
    {
      Console.WriteLine();
      Console.Write("選択肢を番号を入力してください:");

      string? input = Console.ReadLine();

      switch (input)
      {
        case "1":
          {
            AddTask();
            break;
          }
        case "2":
          {
            ShowTasks();
            break;
          }
        case "3":
          {
            ToggleTask();
            break;
          }
        case "4":
          {
            DeleteTask();
            break;
          }
        case "0":
          {
            return;
          }
        default:
          {
            Console.WriteLine("正しい番号を入力してください。");
            break;
          }
      }
    }
  }

  /// <summary>
  /// タスク追加
  /// </summary>
  private static void AddTask()
  {
    while (true)
      {
      Console.Write("タスク名を入力してください:");
      string? title = Console.ReadLine();

      if (string.IsNullOrWhiteSpace(title))
      {
        Console.WriteLine("タスク名は空にできません。");
        continue;
      }

      TaskItem task = new TaskItem
      {
        Id = nextId,
        Title = title,
        IsDone = false
      };

      tasks.Add(task);
      nextId++;

      Console.WriteLine("タスクを追加しました。");
      break;
    }
  }

  /// <summary>
  /// タスク一覧
  /// </summary>
  private static void ShowTasks()
  {
    if (tasks.Count == 0)
    {
      Console.WriteLine("タスクがありません。");
      return;
    }

    foreach (TaskItem task in tasks)
    {
      string status = task.IsDone ? "完了" : "未完了";
      Console.WriteLine($"{task.Id}: {task.Title} [{status}]");
    }
  }

  /// <summary>
  /// タスク更新
  /// </summary>
  private static void ToggleTask()
  {
    Console.Write("切り替えるタスクIDを入力してください:");

    if (int.TryParse(Console.ReadLine(), out int id))
    {
      TaskItem? task = tasks.Find(t => t.Id == id);

      if (task != null)
      {
        task.IsDone = !task.IsDone;
        Console.WriteLine("状態を切り替えました。");
      }
      else
      {
        Console.WriteLine("該当するタスクがありません。");
      }
    }
    else
    {
      Console.WriteLine("数字を入力してください。");
    }
  }

  /// <summary>
  /// タスク削除
  /// </summary>
  private static void DeleteTask()
  {
    Console.Write("削除するタスクIDを入力してください:");

    if (int.TryParse(Console.ReadLine(), out int id))
    {
      TaskItem? task = tasks.Find(t => t.Id == id);

      if (task != null)
      {
        tasks.Remove(task);
        Console.WriteLine("タスクを削除しました。");
      }
      else
      {
        Console.WriteLine("該当するタスクがありません。");
      }
    }
    else
    {
      Console.WriteLine("数字を入力してください。");
    }
  }
}